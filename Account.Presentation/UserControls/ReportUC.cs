using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class ReportUC : UserControl
    {
        private readonly ICustomerRepository _customerRepository;
        public ReportUC(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            InitializeComponent();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = _customerRepository.ExecuteQuery(_customerRepository.ShowAll(_customerRepository.Paging.Order(_customerRepository.Paging.Page)));
            var count = (_customerRepository.ExecuteQuery(_customerRepository.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_customerRepository.Paging.Page + 1}";
        }
    }
}
