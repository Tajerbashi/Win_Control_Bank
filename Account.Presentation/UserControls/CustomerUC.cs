using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Domain.Library.Entities.BUS;
using Account.Domain.Library.Enums;
using Account.Presentation.Forms;
using Account.Presentation.Generator;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class CustomerUC : UserControl
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICartRepository _cartRepository;
        private CustomerNewForm customerNewForm;

        public CustomerUC(
            ICustomerRepository customerRepository,
            ICartRepository cartRepository,
            CustomerNewForm customerNewForm
            )
        {
            _customerRepository = customerRepository;
            _cartRepository = cartRepository;
            this.customerNewForm = customerNewForm;
            InitializeComponent();
        }

        private void ShowDataGrid()
        {
            CustomerCombo = ComboBoxGenerator<CartType>.FillData(CustomerCombo, _cartRepository.TitleValuesDegreeCart(), Convert.ToByte(CustomerCombo.Tag));
            GridData.DataSource = _customerRepository.ExecuteQuery(_customerRepository.ShowAll(_customerRepository.Paging.Order(_customerRepository.Paging.Page)));
            var count = (_customerRepository.ExecuteQuery(_customerRepository.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_customerRepository.Paging.Page + 1}";
        }

        private void UserUS_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            customerNewForm.ShowDialog();
            ShowDataGrid();
        }

        private void CustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CustomerType = CustomerCombo.SelectedItem as KeyValue<CartType>;
            if (CustomerType is not null)
            {
                GridData.DataSource = _customerRepository.ExecuteQuery(_customerRepository.ShowAllByCustomerType(CustomerType.Value, _customerRepository.Paging.Order(_customerRepository.Paging.Page)));
            }
            else
            {
                GridData.DataSource = _customerRepository.ExecuteQuery(_customerRepository.ShowAll(_customerRepository.Paging.Order(_customerRepository.Paging.Page)));
            }
        }


    }
}
