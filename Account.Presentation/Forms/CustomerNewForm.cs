using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using Account.Presentation.Extentions;
using FluentValidation;
using FluentValidation.Results;
using Presentation.Extentions;
using System.Runtime.InteropServices;

namespace Account.Presentation.Forms
{
    public partial class CustomerNewForm : Form
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

        System.Windows.Forms.Timer Timer =new System.Windows.Forms.Timer();
        #endregion
        private IValidator<CustomerDTO> _validator;
        private readonly IUnitOfWork _unitOfWork;
        public CustomerNewForm(
            IUnitOfWork unitOfWork,
            IValidator<CustomerDTO> validator
            )
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            MSG.Text = "";
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        OpenFileDialog ofd = new OpenFileDialog();
        Image pic;
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ValidationResult result = _validator.Validate(CustomerDTO());
            if (!result.IsValid)
            {
                MSG.Visible = true;
                MSG.Text = result.Errors.Select(x => ($"{x.ErrorMessage} : {x.AttemptedValue}\n")).FirstOrDefault();
                return;
            }
            SaveFormData();
            FormExtentions.ClearTextBoxes(this.Controls);
            MSG.Text = "";
            this.Close();
        }



        private void FullNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SaveBtn_Click(sender, e);
            }
        }

        private void SaveFormData()
        {
            _unitOfWork.BeginTransaction();
            try
            {
                var bankId = _unitOfWork.BankRepository.Insert(BankDTO());
                var customerId = _unitOfWork.CustomerRepository.Insert(CustomerDTO());
                var cartId = _unitOfWork.CartRepository.Insert(CartDTO(bankId,customerId));
                var blanceId = _unitOfWork.BlanceRepository.Insert(BlanceDTO(cartId));
                MSG.Visible = true;
                MSG.Text = "عملیات با موفقیت انجام شد";
                FormExtentions.ClearTextBoxes(this.Controls);
                UserPicture.Image = null;
                MSG.Text = "";
                _unitOfWork.Commit();
                this.Close();
            }
            catch
            {
                MSG.Text = "استثناء بوجود آمده است";
                _unitOfWork.Rollback();
            }
        }

        private void UserPicture_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG(*.JPG)|*.JPG";
            ofd.Title = "تصویر کاربر را انتخاب کنید";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic = Image.FromFile(ofd.FileName);
                UserPicture.Image = pic;
                UserPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private BankDTO BankDTO()
        {
            return new BankDTO
            {
                BankName = $"حساب نقدی مشترک ذیل : {FullNameTxt.Text}",
            };
        }
        private CartDTO CartDTO(long bankId, long customerId)
        {
            return new CartDTO
            {
                AccountNumber = "",
                Picture = "",
                BankID = bankId,
                CustomerID = customerId,
                CartType = Domain.Library.Enums.CartType.Main,
                ExpireDate = DateTime.Now.AddYears(10),
                Key = Guid.NewGuid(),
                ParentID = null,
                ShabaAccountNumber = $"IR-Cashable Cart For CustomerID : {customerId} and BankID : {bankId}",
            };
        }
        private CustomerDTO CustomerDTO()
        {
            return new CustomerDTO
            {
                Key = Guid.NewGuid(),
                FullName = FullNameTxt.Text,
                Picture = FileHandler.SavePic(FullNameTxt.Text, ofd),
            };
        }

        private BlanceDTO BlanceDTO(long cartId)
        {
            return new BlanceDTO
            {
                BlanceType = Domain.Library.Enums.BlanceType.Cashable,
                NewBlanceCash = 0,
                OldBlanceCash = 0,
                TransactionCash = 0,
                TransactionID = Guid.NewGuid(),
                TransactionType = Domain.Library.Enums.TransactionType.Settlemant,
                CartID = cartId,
                Description = $"اولین موجودی نقدی کاربر {FullNameTxt.Text}",
            };
        }
    }
}
