using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Patterns;
using Presentation.Generator;
using System.Runtime.InteropServices;

namespace Presentation.Forms
{
    public partial class TransactionNewForm : Form
    {
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
        public TransactionNewForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        private void timer_Tick(object sender, EventArgs e)
        {
        }

        #endregion



        private void TransactionNewForm_Load(object sender, EventArgs e)
        {
            UpdateComboBoxes();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var type = ((KeyValue<long>)TransactionTypeCombo.SelectedItem).Value;
            if (TransactionValidation(type))
            {
                var fromCartId = ((KeyValue<long>)FromCustomerCombo.SelectedItem).Value;
                var fromCartChildId = ((KeyValue<long>)FromAccountCombo.SelectedItem).Value;

                var cash = CashTxt.Text;

                switch (type)
                {

                    case 1: // خرید از کارت
                        {
                            //var CartData = unitOfWork.CartService.GetById(fromCartId);
                            using (var context = unitOfWork.BeginTransaction())
                            {
                                try
                                {
                                    var CartChildData = unitOfWork.CartService.GetById(fromCartChildId);
                                    var transaction = new TransactionDTO
                                    {
                                        CartID = fromCartChildId,
                                        Cash = Convert.ToInt64(cash),
                                        TransactionType = Domain.Library.Enums.TransactionType.Harvesting
                                    };
                                    var TransactionId = unitOfWork.TransactionService.Insert(transaction);
                                    var lastBlance = unitOfWork.BlanceService.GetBlanceCash(fromCartChildId);
                                    var blance = new BlanceDTO
                                    {
                                        BlanceCash = lastBlance - Convert.ToInt64(cash),
                                        BlanceType = Domain.Library.Enums.BlanceType.Banking,
                                        TransactionID = (long)TransactionId,
                                    };
                                    context.Commit();
                                    this.Close();
                                }
                                catch
                                {
                                    context.Rollback();
                                    throw;
                                }
                            }
                            break;
                        }
                    case 2: //  برداشت نقدی
                        {
                            break;
                        }
                    case 3: //  انتقال به کارت دیگر
                        {
                            var toCartId = ((KeyValue<long>)ToCustomerCombo.SelectedItem).Value;
                            var toCartChildId = ((KeyValue<long>)ToAccountCombo.SelectedItem).Value;
                            break;
                        }
                    case 4: // واریزی به کارت
                        {
                            break;
                        }
                    default:
                        {
                            MSG.Text = "هنوز هیچ نوع تراکنشی تایید نشده است";
                            break;
                        }
                }
            }
        }

        private void TransactionTypeCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            var type = ((KeyValue<long>)TransactionTypeCombo.SelectedItem).Value;
            MSG.Text = type.ToString();
            switch (type)
            {
                case 1:
                    {
                        label5.Visible = false;
                        ToCustomerCombo.Visible = false;
                        label7.Visible = false;
                        ToAccountCombo.Visible = false;
                        NewDataBtn.Visible = false;
                        TransactionKindCombo.SelectedIndex = 2;
                        BlanceTypeCombo.SelectedIndex = 2;
                        break;
                    }
                case 2:
                    {
                        label5.Visible = false;
                        ToCustomerCombo.Visible = false;
                        label7.Visible = false;
                        ToAccountCombo.Visible = false;
                        NewDataBtn.Visible = false;
                        TransactionKindCombo.SelectedIndex = 2;
                        BlanceTypeCombo.SelectedIndex = 1;
                        break;
                    }
                case 3:
                    {
                        label5.Visible = true;
                        ToCustomerCombo.Visible = true;
                        label7.Visible = true;
                        ToAccountCombo.Visible = true;
                        NewDataBtn.Visible = true;
                        TransactionKindCombo.SelectedIndex = 2;
                        break;
                    }
                case 4:
                    {
                        label5.Visible = false;
                        ToCustomerCombo.Visible = false;
                        label7.Visible = false;
                        ToAccountCombo.Visible = false;
                        NewDataBtn.Visible = false;
                        TransactionKindCombo.SelectedIndex = 1;
                        BlanceTypeCombo.SelectedIndex = 2;
                        break;
                    }
                default:
                    {
                        MSG.Text = "هنوز هیچ نوع تراکنشی تایید نشده است";
                        label5.Visible = false;
                        ToCustomerCombo.Visible = false;
                        label7.Visible = false;
                        ToAccountCombo.Visible = false;
                        break;
                    }
            }
        }

        private void NewUserCheck_CheckedChanged(object sender, EventArgs e)
        {
            //if (NewUserCheck.Checked)
            //{
            //    PanelNewUser.Visible = true;
            //}
            //else
            //{
            //    PanelNewUser.Visible = false;
            //}
        }



        private void ToCustomerCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            var Id = ((KeyValue<long>)ToCustomerCombo.SelectedItem).Value;
            if (Id != 0)
            {
                ToAccountCombo = ComboBoxGenerator.FillData(ToAccountCombo, unitOfWork.CartService.TitleValuesChild(Id), Convert.ToByte(ToAccountCombo.Tag));
            }
        }

        private void FromAccountCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            var Id = ((KeyValue<long>)FromAccountCombo.SelectedItem).Value;
            if (Id != 0)
            {
                FromAccountLBL.Text = unitOfWork.BlanceService.GetBlance(Id);
            }

        }
        private bool TransactionValidation(long type)
        {
            switch (type)
            {
                case 1:
                    {
                        if (FromAccountLBL.Text.Trim() != null && FromAccountLBL.Text.Trim() != "")
                        {
                            var TransactionCash = Convert.ToDouble(FromAccountLBL.Text);
                            var CurrentCash = Convert.ToDouble(CashTxt.Text);
                            if (CurrentCash > TransactionCash)
                            {
                                MSG.Text = "مبلغ تراکنش از مبلغ موجودی کارت بیشتراست";
                                return false;
                            }
                            //  تراکنش انجام شود
                            return true;
                        }
                        break;
                    }
                case 2:
                    {
                        if (FromAccountLBL.Text.Trim() != null && FromAccountLBL.Text.Trim() != "")
                        {
                            var TransactionCash = Convert.ToDouble(FromAccountLBL.Text);
                            var CurrentCash = Convert.ToDouble(CashTxt.Text);
                            if (CurrentCash > TransactionCash)
                            {
                                MSG.Text = "مبلغ تراکنش از مبلغ موجودی کارت بیشتراست";
                                return false;
                            }
                            //  تراکنش انجام شود
                            return true;
                        }
                        break;
                    }
                case 3:
                    {
                        if (FromAccountLBL.Text.Trim() != null && FromAccountLBL.Text.Trim() != "")
                        {
                            var TransactionCash = Convert.ToDouble(FromAccountLBL.Text);
                            var CurrentCash = Convert.ToDouble(CashTxt.Text);
                            if (CurrentCash > TransactionCash)
                            {
                                MSG.Text = "مبلغ تراکنش از مبلغ موجودی کارت بیشتراست";
                                return false;
                            }
                            //  تراکنش انجام شود
                            return true;
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return true;
        }

        private void SaveNewDataBtn_Click(object sender, EventArgs e)
        {
            var context = unitOfWork.BeginTransaction();
            try
            {
                var Custumer = new CustomerDTO
                {
                    FullName = NewCustomerNameTxt.Text,
                    Description = NewCustomerNameTxt.Text,
                    Title = NewCustomerNameTxt.Text,
                    Key = Guid.NewGuid()
                };
                var customeId = unitOfWork.CustomerService.Insert(Custumer);
                var Bank = new BankDTO
                {
                    BankName = NewBankNameTxt.Text,
                    Description = NewBankNameTxt.Text,
                    Title = NewBankNameTxt.Text,
                };
                var bankId = unitOfWork.BankService.Insert(Bank);
                var Cart = new CartDTO
                {
                    CartType  = Domain.Library.Enums.CartType.Custome,
                    AccountNumber = NewCartNumberTxt.Text,
                    CustomerID = (long)customeId,
                    BankID = (long)bankId,
                    ExpireDate = DateTime.Now,
                    Key = Guid.NewGuid(),
                    ShabaAccountNumber = Guid.NewGuid().ToString(),
                    ParentID = null
                };
                unitOfWork.CartService.Insert(Cart);
                context.CommitAsync();
                UpdateComboBoxes();
            }
            catch
            {
                context.Rollback();
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
        private void UpdateComboBoxes()
        {
            TransactionTypeCombo = ComboBoxGenerator.FillData(TransactionTypeCombo, unitOfWork.TransactionService.TitleValueKind(), Convert.ToByte(TransactionTypeCombo.Tag));
            TransactionKindCombo = ComboBoxGenerator.FillData(TransactionKindCombo, unitOfWork.TransactionService.TitleValue(), Convert.ToByte(TransactionKindCombo.Tag));

            FromCustomerCombo = ComboBoxGenerator.FillData(FromCustomerCombo, unitOfWork.CartService.TitleValuesParent(), Convert.ToByte(FromCustomerCombo.Tag));
            ToCustomerCombo = ComboBoxGenerator.FillData(ToCustomerCombo, unitOfWork.CartService.TitleValuesAllCart(), Convert.ToByte(ToCustomerCombo.Tag));

            BlanceTypeCombo = ComboBoxGenerator.FillData(BlanceTypeCombo, unitOfWork.BlanceService.TitleValue(), Convert.ToByte(BlanceTypeCombo.Tag));
        }

        private void ToCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Id = ((KeyValue<long>)ToCustomerCombo.SelectedItem).Value;
            if (Id != 0)
            {
                ToCustomerCombo.Text = unitOfWork.BlanceService.GetBlance(Id);
                ToAccountCombo = ComboBoxGenerator.FillData(ToAccountCombo, unitOfWork.CartService.TitleValuesChild(Id), Convert.ToByte(ToAccountCombo.Tag));
            }
        }

        private void FromCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Id = ((KeyValue<long>)FromCustomerCombo.SelectedItem).Value;
            if (Id != 0)
            {
                FromCustomerLBL.Text = unitOfWork.BlanceService.GetBlance(Id);
                FromAccountCombo = ComboBoxGenerator.FillData(FromAccountCombo, unitOfWork.CartService.TitleValuesChild(Id), Convert.ToByte(FromAccountCombo.Tag));

            }

        }
    }
}
