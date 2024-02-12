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
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBankRepository _bankRepository;
        private readonly IExecuteDataTableQuery _executeDataTable;
        public BankUC(
            IUnitOfWork unitOfWork,
            IBankRepository bankRepository,
            IExecuteDataTableQuery executeDataTable
            )
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _bankRepository = bankRepository;
            _executeDataTable = executeDataTable;
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = _executeDataTable.Execute(_bankRepository.ShowAll(_bankRepository.Paging.Order(_bankRepository.Paging.Page)));
            var count = (_executeDataTable.Execute(_bankRepository.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_bankRepository.Paging.Page + 1}";

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
            BankNewForm bankNewForm = new BankNewForm(_bankRepository);
            bankNewForm.ShowDialog();
            ShowDataGrid();
        }
    }
}
