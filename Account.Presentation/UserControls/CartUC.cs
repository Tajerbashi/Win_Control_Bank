using Account.Application.Library.Models.Controls;
using Account.Application.Library.Repositories.BUS;
using Account.Presentation.Forms;
using Account.Presentation.Generator;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class CartUC : UserControl
    {
        private readonly ICartRepository _cartRepository;
        private readonly ICustomerRepository _customerRepository;
        private CartNewForm _cartNewForm;
        private byte Index = 0;
        public CartUC(ICartRepository cartRepository, ICustomerRepository customerRepository, CartNewForm cartNewForm)
        {
            _cartRepository = cartRepository;
            _cartNewForm = cartNewForm;
            _customerRepository = customerRepository;
            Index = 0;
            InitializeComponent();
        }

        private void ShowDataGrid()
        {
            GridData.DataSource = _cartRepository.ExecuteQuery(_cartRepository.ShowAll(_cartRepository.Paging.Order(_cartRepository.Paging.Page)));
            var count = (_cartRepository.ExecuteQuery(_cartRepository.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_cartRepository.Paging.Page + 1}";
            CustomerCombo = ComboBoxGenerator<long>.FillData(CustomerCombo, _customerRepository.CustomerTitleValue(), Convert.ToByte(CustomerCombo.Tag));
        }

        private void CartUC_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            _cartNewForm.ShowDialog();
            ShowDataGrid();
        }

        private void CustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Id = ((KeyValue<long>)CustomerCombo.SelectedItem).Value;
            if (Index != Id)
            {
                Index = (byte)Id;
                if (Id != 0)
                    GridData.DataSource = _cartRepository.ExecuteQuery(_cartRepository.SearchByCustomerId(Id, _cartRepository.Paging.Order(_cartRepository.Paging.Page)));
                else
                    ShowDataGrid();
            }
        }
    }
}
