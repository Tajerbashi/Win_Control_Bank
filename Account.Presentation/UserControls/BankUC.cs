using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Presentation.Forms;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class BankUC : UserControl
    {
        private IUnitOfWork _unitOfWork;
        private readonly IBankRepository _bankRepository;
        public BankUC(
            IUnitOfWork unitOfWork,
            IBankRepository bankRepository
            )
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _bankRepository = bankRepository;
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = _bankRepository.ExecuteQuery(_bankRepository.ShowAll(_bankRepository.Paging.Order(_bankRepository.Paging.Page)));
            var count = (_bankRepository.ExecuteQuery(_bankRepository.GetCount())).Rows[0].Field<int>(0); ;
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
