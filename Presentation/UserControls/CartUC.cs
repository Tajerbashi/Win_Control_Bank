using Account.Applicatino.Library.Patterns;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Patterns;
using Account.Presentation.Forms;
using Account.Presentation.Generator;
using System.Data;

namespace Account.Presentation.UserControls
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
            GridData.DataSource = Pattern.ExecuteQuery(Pattern.CartRepository.ShowAll(Pattern.Paging.Order(Pattern.Paging.Page)));
            var count = (Pattern.ExecuteQuery(Pattern.CartRepository.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {Pattern.Paging.Page + 1}";
            CartCombo = ComboBoxGenerator<long>.FillData(CartCombo, Pattern.CartRepository.TitleValuesAllParentCart(), Convert.ToByte(CartCombo.Tag));
        }

        private void CartUC_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CartNewForm cartNewForm = new CartNewForm();
            cartNewForm.ShowDialog();
            ShowDataGrid();
        }

        private void CartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Id = ((KeyValue<long>)CartCombo.SelectedItem).Value;
            if (Id != 0)
                GridData.DataSource = Pattern.ExecuteQuery(Pattern.CartRepository.SearchByCartId(Id, Pattern.Paging.Order(Pattern.Paging.Page)));
            else
                GridData.DataSource = Pattern.ExecuteQuery(Pattern.CartRepository.ShowAll(Pattern.Paging.Order(Pattern.Paging.Page)));
        }
    }
}
