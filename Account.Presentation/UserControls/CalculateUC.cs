using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Presentation.Extentions;
using Account.Presentation.Generator;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class CalculateUC : UserControl
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CalculateUC(
            ICustomerRepository customerRepository,
            IUnitOfWork unitOfWork
            )
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
            InitializeComponent();
        }

        private void ShowDataGrid()
        {
            GridData.DataSource = _customerRepository.ExecuteQuery(_unitOfWork.CartRepository.ShowAll(_customerRepository.Paging.Order(_customerRepository.Paging.Page)));
            var count = (_customerRepository.ExecuteQuery(_customerRepository.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_customerRepository.Paging.Page + 1}";

        }

        private void CalculateUC_Load(object sender, EventArgs e)
        {
            FromDate.UsePersianFormat = true;
            ToDate.UsePersianFormat = true;
            FromDate.Value = DateTime.Now;
            ToDate.Value = DateTime.Now.AddMonths(1);
            ShowDataGrid();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            yearCombo = ComboBoxGenerator<int>.FillData(yearCombo, DateUtilities.TitleValueYear(), Convert.ToByte(yearCombo.Tag));
            monthCombo = ComboBoxGenerator<int>.FillData(monthCombo, DateUtilities.TitleValueMonthPersian(), Convert.ToByte(monthCombo.Tag));
            dayCombo = ComboBoxGenerator<int>.FillData(dayCombo, DateUtilities.TitleValueDay(), Convert.ToByte(dayCombo.Tag));
            CartCombo = ComboBoxGenerator<long>.FillData(CartCombo, _unitOfWork.CartRepository.TitleValuesAllCart(), Convert.ToByte(CartCombo.Tag));
        }

        private void FBlanceTxt_TextChanged(object sender, EventArgs e)
        {
            if (FBlanceTxt.Text == "" || FBlanceTxt.Text == "0") return;
            FBlanceTxt = InputUtilities.Thirth3Numeric(FBlanceTxt);
        }

        private void TBlanceTxt_TextChanged(object sender, EventArgs e)
        {
            if (TBlanceTxt.Text == "" || TBlanceTxt.Text == "0") return;
            TBlanceTxt = InputUtilities.Thirth3Numeric(TBlanceTxt);
        }

        private void FBlanceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TBlanceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void YMDSearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void DateSearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void BlanceSearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
