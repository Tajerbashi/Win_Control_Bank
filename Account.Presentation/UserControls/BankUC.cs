using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.IDatabaseContext.DatabaseContext;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Infrastructure.Library.ApplicationContext.GridDataConnection;
using Account.Presentation.Forms;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class BankUC : UserControl
    {
        private readonly UnitOfWork<ContextDbApplication> _unitOfWork;
        private readonly IBankRepository _bankRepository;
        private readonly IExecuteDataTableQuery _executeDataTable;
        //private IFacadPattern Pattern;
        public BankUC()
        {
            InitializeComponent();
            //Pattern = new FacadPattern();
            _unitOfWork = new UnitOfWork<ContextDbApplication>();
            _bankRepository = new BankRepository(_unitOfWork);
            _executeDataTable = new ExecuteDataTableQuery();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = _executeDataTable.Execute(_bankRepository.ShowAll(Pattern.Paging.Order(Pattern.Paging.Page)));
            var count = (Pattern.ExecuteQuery(Pattern.BankRepository.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {Pattern.Paging.Page + 1}";

        }

        private void BankUC_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            BankNewForm bankNewForm = new BankNewForm();
            bankNewForm.ShowDialog();
            ShowDataGrid();
        }
    }
}
