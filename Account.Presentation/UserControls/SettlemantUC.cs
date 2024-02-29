using Account.Application.Library.Models.Controls;
using Account.Application.Library.Patterns;
using Account.Infrastructure.Library.Patterns;
using Account.Presentation.Extentions;
using Account.Presentation.Forms;
using Account.Presentation.Generator;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class SettlemantUC : UserControl
    {
        private SettlemantForm SettlemantForm;
        private readonly IUnitOfWork _unitOfWork;
        public SettlemantUC(
            SettlemantForm SettlemantForm,
            IUnitOfWork unitOfWork
            )
        {
            this.SettlemantForm = SettlemantForm;
            _unitOfWork = unitOfWork;
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SettlemantForm.ShowDialog();
            ShowDataGridView();
        }
        private void UpdateComboBoxes()
        {
            CustomerCombo = ComboBoxGenerator<long>.FillData(CustomerCombo, _unitOfWork.CustomerRepository.CustomerTitleValue(), Convert.ToByte(CustomerCombo.Tag));
            YearCombo = ComboBoxGenerator<int>.FillData(YearCombo, DateUtilities.TitleValueYear(), Convert.ToByte(YearCombo.Tag));
            MonthCombo = ComboBoxGenerator<int>.FillData(MonthCombo, DateUtilities.TitleValueMonthPersian(), Convert.ToByte(MonthCombo.Tag));
        }

        private void SettlemantUC_Load(object sender, EventArgs e)
        {
            UpdateComboBoxes(); 
            ShowDataGridView();
        }

        private void CustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CustomerId = CustomerCombo.SelectedItem as KeyValue<long>;
            if (CustomerId is not null)
            {
                if (CustomerId.Value != 0)
                {
                    AccountCombo = ComboBoxGenerator<long>.FillData(AccountCombo, _unitOfWork.CartRepository.TitleValueByUserID(CustomerId.Value), Convert.ToByte(AccountCombo.Tag));
                }
                else
                {
                    AccountCombo.Items.Clear();
                }
            }
        }
        private void ShowDataGridView()
        {
            GridData.DataSource = _unitOfWork.SettlemantRepository.ExecuteQuery(_unitOfWork.SettlemantRepository.ShowAll(_unitOfWork.SettlemantRepository.Paging.Order(_unitOfWork.SettlemantRepository.Paging.Page)));
            var count = (_unitOfWork.SettlemantRepository.ExecuteQuery(_unitOfWork.SettlemantRepository.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_unitOfWork.SettlemantRepository.Paging.Page + 1}";
        }
    }
}
