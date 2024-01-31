using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Patterns;
using Presentation.Forms;
using Presentation.Generator;
using System.Data;

namespace Presentation.UserControls
{
    public partial class TransactionUC : UserControl
    {
        private readonly IFacadPattern Pattern;
        public TransactionUC()
        {
            InitializeComponent();
            Pattern = new FacadPattern();
        }
        private void ShowDataGrid()
        {
            var cartId = ((KeyValue<long>)CartCombo.SelectedItem).Value;
            if (cartId == 0)
            {
                GridData.DataSource = Pattern.ExecuteQuery(Pattern.BlanceService.Show50LastTransactions(Pattern.Paging.Order(Pattern.Paging.Page)));
            }
            else
            {
                GridData.DataSource = Pattern.ExecuteQuery(Pattern.BlanceService.ShowAllByCartId(cartId, Pattern.Paging.Order(Pattern.Paging.Page)));
            }
            var count = (Pattern.ExecuteQuery(Pattern.BlanceService.GetCount())).Rows[0].Field<int>(0);
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {Pattern.Paging.Page + 1}";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            TransactionNewForm transaction = new TransactionNewForm();
            transaction.ShowDialog();
            ShowDataGrid();
        }

        private void TransactionUC_Load(object sender, EventArgs e)
        {
            CartCombo = ComboBoxGenerator<long>.FillData(CartCombo, Pattern.CartService.TitleValuesAllCart(), Convert.ToByte(CartCombo.Tag));
        }

        private void CartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDataGrid();
        }
    }
}
