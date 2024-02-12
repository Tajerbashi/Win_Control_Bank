using Account.Application.Library.Models.Controls;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Presentation.Forms;
using Account.Presentation.Generator;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class TransactionUC : UserControl
    {
        private readonly IBlanceRepository _blanceRepository;
        private readonly ICartRepository _cartRepository;
        private TransactionNewForm transaction;
        public TransactionUC(IBlanceRepository blanceRepository, ICartRepository cartRepository, TransactionNewForm transaction)
        {
            _blanceRepository = blanceRepository;
            _cartRepository = cartRepository;
            this.transaction = transaction;
            InitializeComponent();
        }
        private void ShowDataGrid()
        {
            var cartId = ((KeyValue<long>)CartCombo.SelectedItem).Value;
            if (cartId == 0)
            {
                GridData.DataSource = _blanceRepository.ExecuteQuery(_blanceRepository.Show50LastTransactions(_blanceRepository.Paging.Order(_blanceRepository.Paging.Page)));
            }
            else
            {
                GridData.DataSource = _blanceRepository.ExecuteQuery(_blanceRepository.ShowAllByCartId(cartId, _blanceRepository.Paging.Order(_blanceRepository.Paging.Page)));
            }
            var count = (_blanceRepository.ExecuteQuery(_blanceRepository.GetCount())).Rows[0].Field<int>(0);
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_blanceRepository.Paging.Page + 1}";
        }


        private void TransactionUC_Load(object sender, EventArgs e)
        {
            CartCombo = ComboBoxGenerator<long>.FillData(CartCombo, _cartRepository.TitleValuesAllCart(), Convert.ToByte(CartCombo.Tag));
            ShowDataGrid();
        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            transaction.ShowDialog();
            ShowDataGrid();
        }

        private void CartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDataGrid();

        }
    }
}
