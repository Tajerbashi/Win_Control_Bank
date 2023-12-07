using Infrastructure.Library.Patterns;
using System.Data;

namespace Presentation.UserControls
{
    public partial class OnlineExchangeUC : UserControl
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IFacadPattern pattern;

        public OnlineExchangeUC()
        {
            unitOfWork = new UnitOfWork();
            pattern = new FacadPattern();
            InitializeComponent();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = pattern.ExecuteQuery(unitOfWork.CustomerService.ShowAll(unitOfWork.Paging.Order(unitOfWork.Paging.Page)));
            var count = (pattern.ExecuteQuery(unitOfWork.CustomerService.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {unitOfWork.Paging.Page + 1}";
        }

        private void OnlineExchangeUC_Load(object sender, EventArgs e)
        {

        }
    }
}
