using Account.Domain.Library.Enums;
using Account.Application.Library.Exceptions;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Presentation.Generator;
using System.Runtime.InteropServices;
using Account.Common.Library.Extentions;
using Account.Application.Library.Repositories.BUS;
using Account.Application.Library.Patterns;
using Account.Presentation.Extentions;
using Microsoft.VisualStudio.Shell.Interop;

namespace Account.Presentation.Forms
{
    public partial class TransactionNewForm : Form
    {
        private Guid TransactionID;

        #region Code
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        private readonly IUnitOfWork _unitOfWork;
        //private readonly ICartRepository _cartRepository;
        //private readonly IBlanceRepository _blanceRepository;
        //private readonly ICustomerRepository _customerRepository;
        //private readonly IBankRepository _bankRepository;
        public TransactionNewForm(
            IUnitOfWork unitOfWork//,
                                  //ICartRepository cartRepository,
                                  //IBlanceRepository blanceRepository,
                                  //ICustomerRepository customerRepository,
                                  //IBankRepository bankRepository

            )
        {
            _unitOfWork = unitOfWork;
            //_cartRepository = cartRepository;
            //_blanceRepository = blanceRepository;
            //_customerRepository = customerRepository;
            //_bankRepository = bankRepository;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        private void TransactionNewForm_Load(object sender, EventArgs e)
        {
            UpdateComboBoxes();
            ProgressHandler(10);
            DisActiveAllConditionControle();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            TransactionID = Guid.NewGuid();
            var type = (TransactionTypeCombo.SelectedItem as KeyValue<byte>);
            if (type == null)
                return;
            switch (type.Value)
            {
                case 1: //خرید از کارت
                    {
                        BuyFromCartTransaction();
                        break;
                    }
                case 2: //خرید نقدی
                    {
                        CashableBuyTransaction();
                        break;
                    }
                case 3: //کارت به کارت
                    {
                        CartToCartTransaction();
                        break;
                    }
                case 4: //برداشت نقدی از کارت واریز به حساب نقدی
                    {
                        FromCartBankToCashBlanceTransaction();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        private void SaveNewDataBtn_Click(object sender, EventArgs e)
        {
            _unitOfWork.BeginTransaction();
            try
            {
                var Custumer = CustomerDTO();
                var customeId = _unitOfWork.CustomerRepository.AddOrUpdate(Custumer);
                var Bank = BankDTO();
                if (Bank.ID == 0)
                {
                    _unitOfWork.BankRepository.Insert(Bank);
                }
                var Cart = CartDTO(customeId,Bank.ID);
                _unitOfWork.CartRepository.AddOrUpdate(Cart);
                _unitOfWork.Commit();
                UpdateComboBoxes();
            }
            catch
            {
                _unitOfWork.Rollback();
                throw;
            }
        }
        private void NewDataBtn_Click(object sender, EventArgs e)
        {
            NewDataPanel.Visible = NewDataPanel.Visible ? false : true;
            if (NewDataPanel.Visible)
            {
                NewDataBtn.Text = "-";
            }
            else
            {
                NewDataBtn.Text = "+";
            }
        }

        #region SelectedIndexChanged
        private void ToCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgressHandler(5);
            ToCustomerLBL.Text = "";
            var Id = ((KeyValue<long>)ToCustomerCombo.SelectedItem).Value;
            if (Id != 0)
            {
                ToCustomerLBL.Text = _unitOfWork.BlanceRepository.GetBankingBlanceByCartId(Id)?.ToString("N");
                ToAccountCombo = ComboBoxGenerator<long>.FillData(ToAccountCombo, _unitOfWork.CartRepository.TitleValuesChild(Id), Convert.ToByte(ToAccountCombo.Tag));
            }
        }

        private void FromCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromCustomerLBL.Text = "";
            var Id = ((KeyValue<long>)FromCustomerCombo.SelectedItem).Value;
            if (Id != 0)
            {
                FromCustomerLBL.Text = _unitOfWork.BlanceRepository.GetBankingBlanceByCartId(Id)?.ToString("N");
                FromAccountCombo = ComboBoxGenerator<long>.FillData(FromAccountCombo, _unitOfWork.CartRepository.TitleValuesChild(Id), Convert.ToByte(FromAccountCombo.Tag));
            }
            ProgressHandler(5);
        }

        private void ToAccountCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgressHandler(5);
            ToAccountLBL.Text = "";
            var Id = ((KeyValue<long>)ToAccountCombo.SelectedItem).Value;
            if (Id != 0)
            {
                ToAccountLBL.Text = _unitOfWork.BlanceRepository.GetBankingBlanceByCartId(Id)?.ToString("N");
            }
        }

        private void TransactionTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgressHandler(10);
            var type = (TransactionTypeCombo.SelectedItem as KeyValue<byte>);
            if (type == null)
            {
                DisActiveAllConditionControle();
                return;
            }
            switch (type.Value)
            {
                case 1: // خرید از کارت
                    {
                        MSG.Text = "عملیات خرید از کارت";
                        BlanceTypeCombo.SelectedIndex = 2;
                        TransactionKindCombo.SelectedIndex = 2;
                        DegreeAccountCombo.SelectedIndex = 1;
                        BuyFromCart();
                        break;
                    }
                case 2: //  خرید نقدی
                    {
                        MSG.Text = "عملیات خرید نقدی";
                        BlanceTypeCombo.SelectedIndex = 1;
                        TransactionKindCombo.SelectedIndex = 2;
                        DegreeAccountCombo.SelectedIndex = 1;
                        CashableBuy();
                        break;
                    }
                case 3: //  کارت به کارت
                    {
                        MSG.Text = "عملیات کارت به کارت";
                        BlanceTypeCombo.SelectedIndex = 2;
                        TransactionKindCombo.SelectedIndex = 2;
                        DegreeAccountCombo.SelectedIndex = 1;
                        CartToCart();
                        break;
                    }
                case 4: //  برداشت از کارت و واریز به حساب نقدی
                    {
                        MSG.Text = "عملیات برداشت از کارت و واریز به حساب نقدی";
                        BlanceTypeCombo.SelectedIndex = 2;
                        TransactionKindCombo.SelectedIndex = 1;
                        DegreeAccountCombo.SelectedIndex = 1;
                        FromCartBankToCashBlance();
                        break;
                    }
                default:
                    {
                        DisActiveAllConditionControle();
                        break;
                    }
            }
        }

        private void BlanceTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgressHandler(10);
        }

        private void TransactionKindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgressHandler(10);
        }

        private void FromAccountCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cart = FromAccountCombo.SelectedItem as KeyValue<long>;
            if (cart.Value != 0)
                FromAccountLBL.Text = _unitOfWork.BlanceRepository.GetBankingBlanceByCartId(cart.Value)?.ToString("N"); ;
            ProgressHandler(5);
        }
        #endregion

        /// <summary>
        /// تراکنش برداشت از کارت
        /// </summary>
        private void BuyFromCartTransaction()
        {
            var fromAccountId = ((KeyValue<long>)FromAccountCombo.SelectedItem).Value;
            var cash = Convert.ToDouble(CashTxt.Text);
            _unitOfWork.BeginTransaction();
            try
            {
                if (_unitOfWork.CartRepository.ValidBlancForTransaction(fromAccountId, cash))
                {
                    var lastBlance = _unitOfWork.BlanceRepository.GetBankingBlanceByCartId(fromAccountId);
                    var blanceDto = BlanceDTO(lastBlance,Convert.ToDouble(cash),fromAccountId,TransactionType.Harvesting,BlanceType.Banking);
                    _unitOfWork.BlanceRepository.DisActiveLastBankingBlanceOfCartById(blanceDto.CartID);
                    blanceDto.ID = _unitOfWork.BlanceRepository.Insert(blanceDto);
                    ClearCloseControl();
                }
                else
                {
                    MSG.Text = MessageProject.NotEnughBlance();
                }
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                MSG.Text = MessageProject.Faild();
                _unitOfWork.Rollback();
                throw;
            }
        }

        /// <summary>
        /// فعال و غیر فعال کردن کنترل ها برای تراکنش برداشت از کارت
        /// </summary>
        /// <param name="SW"></param>
        private void BuyFromCart()
        {
            //  For Active 
            L1.Visible = true;
            L2.Visible = true;
            FromCustomerCombo.Visible = true;
            FromCustomerLBL.Visible = true;
            FromAccountCombo.Visible = true;
            FromAccountLBL.Visible = true;

            //  For DisActive 
            ToCustomerCombo.Visible = false;
            ToCustomerLBL.Visible = false;
            ToAccountCombo.Visible = false;
            ToAccountLBL.Visible = false;

            L3.Visible = false;
            L4.Visible = false;
            L5.Visible = false;
            L6.Visible = false;

            NewDataBtn.Visible = false;
            NewDataPanel.Visible = false;

            FCustomerCombo.Visible = false;
            TCustomerCombo.Visible = false;
        }


        /// <summary>
        /// تراکنش خرید نقدی
        /// </summary>
        private void CashableBuyTransaction()
        {
            var FCustomerId = ((KeyValue<long>)FCustomerCombo.SelectedItem).Value;
            var cash = Convert.ToDouble(CashTxt.Text);
            _unitOfWork.BeginTransaction();
            try
            {
                if (_unitOfWork.CartRepository.ValidBlancForTransaction(FCustomerId, cash))
                {
                    var lastCashBlance = _unitOfWork.BlanceRepository.GetCashableBlanceByCartId(FCustomerId);
                    var blanceDto = BlanceDTO(lastCashBlance,Convert.ToDouble(cash),FCustomerId,TransactionType.Harvesting,BlanceType.Cashable);
                    _unitOfWork.BlanceRepository.DisActiveLastCashableBlanceOfCartById(blanceDto.CartID);
                    blanceDto.ID = _unitOfWork.BlanceRepository.Insert(blanceDto);
                }
                else
                {
                    MSG.Text = MessageProject.NotEnughBlance();
                    return;
                }
                _unitOfWork.Commit();
                ClearCloseControl();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        /// <summary>
        /// فعال و غیر فعال کردن کنترل های خرید نقدی
        /// </summary>
        private void CashableBuy()
        {
            //  For DisActive 
            L1.Visible = false;
            L2.Visible = false;

            FromCustomerCombo.Visible = false;
            FromCustomerLBL.Visible = false;
            FromAccountCombo.Visible = false;
            FromAccountLBL.Visible = false;

            ToCustomerCombo.Visible = false;
            ToCustomerLBL.Visible = false;
            ToAccountCombo.Visible = false;
            ToAccountLBL.Visible = false;

            L3.Visible = false;
            L4.Visible = false;
            L5.Visible = false;
            L6.Visible = false;

            NewDataBtn.Visible = false;
            NewDataPanel.Visible = false;

            FCustomerCombo.Visible = false;
            TCustomerCombo.Visible = false;
            //  For Active 
            L5.Visible = true;
            FCustomerCombo.Visible = true;
        }

        /// <summary>
        /// تراکنش کارت به کارت
        /// </summary>
        private void CartToCartTransaction()
        {
            var fromAccountId = ((KeyValue<long>)FromAccountCombo.SelectedItem).Value;
            var toAccountId = ((KeyValue<long>)ToAccountCombo.SelectedItem).Value;
            var cash = Convert.ToDouble(CashTxt.Text);
            _unitOfWork.BeginTransaction();
            try
            {
                if (_unitOfWork.CartRepository.ValidBlancForTransaction(fromAccountId, cash))
                {
                    //  برداشت از کارت
                    var F_Last_Blance = _unitOfWork.BlanceRepository.GetBankingBlanceByCartId(fromAccountId);
                    var F_Blance_DTO = BlanceDTO(F_Last_Blance,cash,fromAccountId,TransactionType.Harvesting,BlanceType.Banking);
                    _unitOfWork.BlanceRepository.DisActiveLastBankingBlanceOfCartById(fromAccountId);
                    _unitOfWork.BlanceRepository.Insert(F_Blance_DTO);
                    //  واریز به کارت
                    var T_Last_Blance = _unitOfWork.BlanceRepository.GetBankingBlanceByCartId(toAccountId);
                    var T_Blance_DTO = BlanceDTO(T_Last_Blance,cash,toAccountId,TransactionType.Settlemant,BlanceType.Banking);
                    _unitOfWork.BlanceRepository.DisActiveLastBankingBlanceOfCartById(toAccountId);
                    _unitOfWork.BlanceRepository.Insert(T_Blance_DTO);
                }
                else
                {
                    MSG.Text = MessageProject.NotEnughBlance();
                    return;
                }
                _unitOfWork.Commit();
                ClearCloseControl();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        /// <summary>
        /// فعال و غیر فعال کردن کنترل های کارت به کارت
        /// </summary>
        private void CartToCart()
        {
            //  For DisActive 


            FromCustomerCombo.Visible = false;
            FromCustomerLBL.Visible = false;
            FromAccountCombo.Visible = false;
            FromAccountLBL.Visible = false;

            ToCustomerCombo.Visible = false;
            ToCustomerLBL.Visible = false;
            ToAccountCombo.Visible = false;
            ToAccountLBL.Visible = false;
            L5.Visible = false;
            L6.Visible = false;


            NewDataBtn.Visible = false;
            NewDataPanel.Visible = false;

            FCustomerCombo.Visible = false;
            TCustomerCombo.Visible = false;
            //  For Active 
            FromCustomerCombo.Visible = true;
            FromCustomerLBL.Visible = true;
            FromAccountCombo.Visible = true;
            FromAccountLBL.Visible = true;

            ToCustomerCombo.Visible = true;
            ToCustomerLBL.Visible = true;
            ToAccountCombo.Visible = true;
            ToAccountLBL.Visible = true;

            L1.Visible = true;
            L2.Visible = true;
            L3.Visible = true;
            L4.Visible = true;


            NewDataBtn.Visible = true;
            NewDataPanel.Visible = false;

        }

        /// <summary>
        /// برداشت از کارت و واریز به حساب نقدی
        /// </summary>
        private void FromCartBankToCashBlanceTransaction()
        {
            var fromAccountId = ((KeyValue<long>)FromAccountCombo.SelectedItem).Value;
            var cash = Convert.ToDouble(CashTxt.Text);
            if (!_unitOfWork.CartRepository.ValidBlancForTransaction(fromAccountId, cash))
            {
                MSG.Text = MessageProject.NotEnughBlance();
                return;
            }
            var toCartId = ((KeyValue<long>)TCustomerCombo.SelectedItem).Value;
            _unitOfWork.BeginTransaction();
            try
            {
                //  برداشت از کارت
                var lastCash = _unitOfWork.BlanceRepository.GetBankingBlanceByCartId(fromAccountId);
                var blanceCartBank = BlanceDTO(lastCash,cash,fromAccountId,TransactionType.Harvesting, BlanceType.Banking);
                _unitOfWork.BlanceRepository.DisActiveLastBankingBlanceOfCartById(blanceCartBank.CartID);
                var blanceID = _unitOfWork.BlanceRepository.Insert(blanceCartBank);
                //  واریز به حساب نقدی
                var lastCashC = _unitOfWork.BlanceRepository.GetCashableBlanceByCartId(toCartId);
                var blancCartCash = BlanceDTO(lastCashC,cash,toCartId,TransactionType.Settlemant, BlanceType.Cashable);
                _unitOfWork.BlanceRepository.DisActiveLastCashableBlanceOfCartById(toCartId);
                var CashBlanceId = _unitOfWork.BlanceRepository.Insert(blancCartCash);
                _unitOfWork.Commit();
                ClearCloseControl();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        /// <summary>
        /// فعال و غیر فعال کردن کنترل های  برداشت از کارت و واریز به حساب نقدی
        /// </summary>
        /// <param name="SW"></param>
        private void FromCartBankToCashBlance()
        {
            //  For DisActive 


            ToCustomerCombo.Visible = false;
            ToCustomerLBL.Visible = false;
            ToAccountCombo.Visible = false;
            ToAccountLBL.Visible = false;

            L3.Visible = false;
            L4.Visible = false;
            L5.Visible = false;
            L6.Visible = false;

            NewDataBtn.Visible = false;
            NewDataPanel.Visible = false;

            FCustomerCombo.Visible = false;
            TCustomerCombo.Visible = false;
            //  For Active 

            L1.Visible = true;
            L2.Visible = true;

            FromCustomerCombo.Visible = true;
            FromCustomerLBL.Visible = true;
            FromAccountCombo.Visible = true;
            FromAccountLBL.Visible = true;

            L6.Visible = true;
            TCustomerCombo.Visible = true;
        }

        #region Extentions
        private void UpdateComboBoxes()
        {
            TransactionTypeCombo = ComboBoxGenerator<byte>.FillData(TransactionTypeCombo, _unitOfWork.BlanceRepository.TitleValue(), Convert.ToByte(TransactionTypeCombo.Tag));
            TransactionKindCombo = ComboBoxGenerator<byte>.FillData(TransactionKindCombo, _unitOfWork.BlanceRepository.TitleValueTransactionType(), Convert.ToByte(TransactionKindCombo.Tag));

            BlanceTypeCombo = ComboBoxGenerator<byte>.FillData(BlanceTypeCombo, _unitOfWork.BlanceRepository.TitleValueBlanceType(), Convert.ToByte(BlanceTypeCombo.Tag));
            DegreeAccountCombo = ComboBoxGenerator<CartType>.FillData(DegreeAccountCombo, _unitOfWork.CartRepository.TitleValuesDegreeCart(), Convert.ToByte(DegreeAccountCombo.Tag));

            FromCustomerCombo = ComboBoxGenerator<long>.FillData(FromCustomerCombo, _unitOfWork.CartRepository.TitleValuesBankingParent(), Convert.ToByte(FromCustomerCombo.Tag));
            ToCustomerCombo = ComboBoxGenerator<long>.FillData(ToCustomerCombo, _unitOfWork.CartRepository.TitleValuesBankingParent(), Convert.ToByte(ToCustomerCombo.Tag));

            FCustomerCombo = ComboBoxGenerator<long>.FillData(FCustomerCombo, _unitOfWork.CartRepository.TitleValuesCashableParent(), Convert.ToByte(FCustomerCombo.Tag));
            TCustomerCombo = ComboBoxGenerator<long>.FillData(TCustomerCombo, _unitOfWork.CartRepository.TitleValuesCashableParent(), Convert.ToByte(TCustomerCombo.Tag));




        }
        private BankDTO BankDTO()
        {
            var entity = _unitOfWork.BankRepository.GetBankByName(NewBankNameTxt.Text);
            if (entity != null)
            {
                return entity;
            }
            return new BankDTO
            {
                BankName = NewBankNameTxt.Text,

            };
        }
        private CartDTO CartDTO(long customeId, long bankId)
        {
            var entity = _unitOfWork.CartRepository.GetCartByAccountNumber(NewCartNumberTxt.Text);
            if (entity != null)
            {
                return entity;
            }
            return new CartDTO
            {
                CartType = CartType.Main,
                AccountNumber = NewCartNumberTxt.Text,
                CustomerID = customeId,
                BankID = bankId,
                ExpireDate = DateTime.Now,
                Key = Guid.NewGuid(),
                ShabaAccountNumber = Guid.NewGuid().ToString(),
                ParentID = null
            };
        }
        private BlanceDTO BlanceDTO(double? lastblance, double cash, long cartId, TransactionType transaction, BlanceType blanceType)
        {
            double blanceCash = 0;
            if (lastblance > 0)
            {
                blanceCash = lastblance.Value;
                if (transaction == TransactionType.Settlemant)
                    blanceCash = lastblance.Value + cash;
                else
                    blanceCash = lastblance.Value - cash;

            }
            else
            {
                lastblance = 0;
                blanceCash = cash;
            }
            return new BlanceDTO
            {
                NewBlanceCash = blanceCash,
                OldBlanceCash = lastblance.Value,
                BlanceType = blanceType,
                CartID = cartId,
                TransactionType = transaction,
                TransactionCash = cash,
                TransactionID = TransactionID,
                Description = DescTxt.Text,
            };
        }
        private CustomerDTO CustomerDTO()
        {
            var entity = _unitOfWork.CustomerRepository.GetCustomerByName(NewCustomerNameTxt.Text);
            if (entity != null)
            {
                return entity;
            }
            return new CustomerDTO
            {
                FullName = NewCustomerNameTxt.Text,
                Key = Guid.NewGuid()
            };
        }
        private void ClearCloseControl()
        {
            FromCustomerLBL.Text = string.Empty;
            FromAccountLBL.Text = string.Empty;
            ToCustomerLBL.Text = string.Empty;
            ToAccountLBL.Text = string.Empty;
            FromCustomerCombo.Items.Clear();
            FromAccountCombo.Items.Clear();
            ToCustomerCombo.Items.Clear();
            ToAccountCombo.Items.Clear();
            FormExtentions.ClearRichTextBox(this.Controls);
            FormExtentions.ClearTextBoxes(this.Controls);
            MSG.Text = string.Empty;
            DisActiveAllConditionControle();
            this.Close();
        }

        private void ProgressHandler(int a)
        {
            if (ProgressController.Value >= 90)
            {
                ProgressController.Value = 0;
            }
            ProgressController.Value += a;
        }

        #endregion

        private void FCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customerCashableCart = (FCustomerCombo.SelectedItem as KeyValue<long>);
            if (customerCashableCart.Value > 0)
            {
                var blance = _unitOfWork.BlanceRepository.GetCashableBlanceByCartId(customerCashableCart.Value);
                MSG.Text = ($"موجودی حساب نقدی مشترک {customerCashableCart.Key} مبلغ فوق است {blance}");
            }
        }
        private void TCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customerCashableCart = (TCustomerCombo.SelectedItem as KeyValue<long>);
            if (customerCashableCart.Value > 0)
            {
                var blance = _unitOfWork.BlanceRepository.GetCashableBlanceByCartId(customerCashableCart.Value);
                MSG.Text = ($"موجودی حساب نقدی مشترک {customerCashableCart.Key} مبلغ فوق است {blance}");
            }
        }

        private void DisActiveAllConditionControle()
        {
            L1.Visible = false;
            L2.Visible = false;
            L3.Visible = false;
            L4.Visible = false;
            L5.Visible = false;
            L6.Visible = false;

            FromCustomerLBL.Visible = false;
            FromAccountLBL.Visible = false;
            ToCustomerLBL.Visible = false;
            ToAccountLBL.Visible = false;

            FromCustomerCombo.Visible = false;
            FromAccountCombo.Visible = false;

            ToCustomerCombo.Visible = false;
            ToAccountCombo.Visible = false;

            NewDataBtn.Visible = false;
            NewDataPanel.Visible = false;
        }

    }
}
