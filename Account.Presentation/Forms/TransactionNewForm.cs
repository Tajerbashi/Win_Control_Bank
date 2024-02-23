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
        private readonly ICartRepository _cartRepository;
        private readonly IBlanceRepository _blanceRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IBankRepository _bankRepository;
        public TransactionNewForm(
            ICartRepository cartRepository,
            IBlanceRepository blanceRepository,
            IUnitOfWork unitOfWork,
            ICustomerRepository customerRepository,
            IBankRepository bankRepository

            )
        {
            _cartRepository = cartRepository;
            _blanceRepository = blanceRepository;
            _unitOfWork = unitOfWork;
            _customerRepository = customerRepository;
            _bankRepository = bankRepository;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        private void TransactionNewForm_Load(object sender, EventArgs e)
        {
            UpdateComboBoxes();
            ProgressHandler(10);
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
                var customeId = _customerRepository.AddOrUpdate(Custumer);
                var Bank = BankDTO();
                if (Bank.ID == 0)
                {
                    _bankRepository.Insert(Bank);
                }
                var Cart = CartDTO(customeId,Bank.ID);
                _cartRepository.AddOrUpdate(Cart);
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
                ToCustomerLBL.Text = _blanceRepository.GetBankingBlanceByCartId(Id)?.ToString("N");
                ToAccountCombo = ComboBoxGenerator<long>.FillData(ToAccountCombo, _cartRepository.TitleValuesChild(Id), Convert.ToByte(ToAccountCombo.Tag));
            }
        }

        private void FromCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromCustomerLBL.Text = "";
            var Id = ((KeyValue<long>)FromCustomerCombo.SelectedItem).Value;
            if (Id != 0)
            {
                FromCustomerLBL.Text = _blanceRepository.GetBankingBlanceByCartId(Id)?.ToString("N");
                FromAccountCombo = ComboBoxGenerator<long>.FillData(FromAccountCombo, _cartRepository.TitleValuesChild(Id), Convert.ToByte(FromAccountCombo.Tag));
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
                ToAccountLBL.Text = _blanceRepository.GetBankingBlanceByCartId(Id)?.ToString("N");
            }
        }

        private void TransactionTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgressHandler(10);
            var type = (TransactionTypeCombo.SelectedItem as KeyValue<byte>);
            if (type == null)
            {
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
                FromAccountLBL.Text = _blanceRepository.GetBankingBlanceByCartId(cart.Value)?.ToString("N"); ;
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
                if (_cartRepository.ValidBlancForTransaction(fromAccountId, cash))
                {
                    var lastBlance = _blanceRepository.GetBankingBlanceByCartId(fromAccountId);
                    var blanceDto = BlanceDTO(lastBlance,Convert.ToDouble(cash),fromAccountId,TransactionType.Harvesting);
                    _blanceRepository.DisActiveLastBankingBlanceOfCartById(blanceDto.CartID);
                    blanceDto.ID = _blanceRepository.Insert(blanceDto);
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
            var fromAccountId = ((KeyValue<long>)FromAccountCombo.SelectedItem).Value;
            var cash = Convert.ToDouble(CashTxt.Text);
            var toCartId = ((KeyValue<long>)ToCustomerCombo.SelectedItem).Value;
            var toCartAccountId = ((KeyValue<long>)ToAccountCombo.SelectedItem).Value;
            _unitOfWork.BeginTransaction();
            try
            {
                _unitOfWork.Commit();
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
            var cash = Convert.ToDouble(CashTxt.Text);
            MSG.Text = MessageProject.Blance(cash);
            var toCartId = ((KeyValue<long>)ToCustomerCombo.SelectedItem).Value;
            var toCartAccountId = ((KeyValue<long>)ToAccountCombo.SelectedItem).Value;
            _unitOfWork.BeginTransaction();
            try
            {
                _unitOfWork.Commit();
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
            L5.Visible = true;
            L6.Visible = true;

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
            var toCartId = ((KeyValue<long>)ToCustomerCombo.SelectedItem).Value;
            var toCartAccountId = ((KeyValue<long>)ToAccountCombo.SelectedItem).Value;
            _unitOfWork.BeginTransaction();
            try
            {
                _unitOfWork.Commit();
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
            TransactionTypeCombo = ComboBoxGenerator<byte>.FillData(TransactionTypeCombo, _blanceRepository.TitleValue(), Convert.ToByte(TransactionTypeCombo.Tag));
            TransactionKindCombo = ComboBoxGenerator<byte>.FillData(TransactionKindCombo, _blanceRepository.TitleValueTransactionType(), Convert.ToByte(TransactionKindCombo.Tag));

            FromCustomerCombo = ComboBoxGenerator<long>.FillData(FromCustomerCombo, _cartRepository.TitleValuesBankingParent(), Convert.ToByte(FromCustomerCombo.Tag));
            FCustomerCombo = ComboBoxGenerator<long>.FillData(FCustomerCombo, _cartRepository.TitleValuesCashableParent(), Convert.ToByte(FCustomerCombo.Tag));
            ToCustomerCombo = ComboBoxGenerator<long>.FillData(ToCustomerCombo, _cartRepository.TitleValuesBankingParent(), Convert.ToByte(ToCustomerCombo.Tag));

            BlanceTypeCombo = ComboBoxGenerator<byte>.FillData(BlanceTypeCombo, _blanceRepository.TitleValueBlanceType(), Convert.ToByte(BlanceTypeCombo.Tag));

            DegreeAccountCombo = ComboBoxGenerator<CartType>.FillData(DegreeAccountCombo, _cartRepository.TitleValuesDegreeCart(), Convert.ToByte(DegreeAccountCombo.Tag));


        }
        private BankDTO BankDTO()
        {
            var entity = _bankRepository.GetBankByName(NewBankNameTxt.Text);
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
            var entity = _cartRepository.GetCartByAccountNumber(NewCartNumberTxt.Text);
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
        private BlanceDTO BlanceDTO(double? lastblance, double cash, long cartId, TransactionType transaction)
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
                BlanceType = (BlanceType)((KeyValue<byte>)BlanceTypeCombo.SelectedItem).Value,
                CartID = cartId,
                TransactionType = transaction,
                TransactionCash = cash,
                TransactionID = TransactionID,
                Description = DescTxt.Text,
            };
        }
        private CustomerDTO CustomerDTO()
        {
            var entity = _customerRepository.GetCustomerByName(NewCustomerNameTxt.Text);
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
    }
}
