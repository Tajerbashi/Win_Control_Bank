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
        private CartNewForm _cartNewForm;
        private byte Index = 0;
        public CartUC(ICartRepository cartRepository, CartNewForm cartNewForm)
        {
            _cartRepository = cartRepository;
            _cartNewForm = cartNewForm;
            Index = 0;
            InitializeComponent();
        }

        private void ShowDataGrid()
        {
            GridData.DataSource = _cartRepository.ExecuteQuery(_cartRepository.ShowAll(_cartRepository.Paging.Order(_cartRepository.Paging.Page)));
            var count = (_cartRepository.ExecuteQuery(_cartRepository.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_cartRepository.Paging.Page + 1}";
            CartCombo = ComboBoxGenerator<long>.FillData(CartCombo, _cartRepository.TitleValuesParent(), Convert.ToByte(CartCombo.Tag));
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

        private void CartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Id = ((KeyValue<long>)CartCombo.SelectedItem).Value;
            if (Index != Id)
            {
                Index = (byte)Id;
                if (Id != 0)
                    GridData.DataSource = _cartRepository.ExecuteQuery(_cartRepository.SearchByCartId(Id, _cartRepository.Paging.Order(_cartRepository.Paging.Page)));
                else
                    ShowDataGrid();
            }
        }
    }
}
