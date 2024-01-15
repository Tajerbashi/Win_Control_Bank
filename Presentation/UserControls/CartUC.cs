using Infrastructure.Library.Patterns;
using Presentation.Forms;
using System.Data;

namespace Presentation.UserControls
{
    public partial class CartUC : UserControl
    {
        private IFacadPattern Pattern;

        public CartUC()
        {
            InitializeComponent();
            Pattern = new FacadPattern();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = Pattern.ExecuteQuery(Pattern.CartService.ShowAll(Pattern.Paging.Order(Pattern.Paging.Page)));
            var count = (Pattern.ExecuteQuery(Pattern.CartService.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {Pattern.Paging.Page + 1}";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            CartNewForm cartNewForm = new CartNewForm();
            cartNewForm.ShowDialog();
            ShowDataGrid();
        }

        private void CartUC_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
        }
    }
}
