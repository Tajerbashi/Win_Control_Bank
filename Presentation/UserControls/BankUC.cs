using Infrastructure.Library.Patterns;
using Presentation.Extentions;
using Presentation.Forms;
using Presentation.Generator;
using System.Data;

namespace Presentation.UserControls
{
    public partial class BankUC : UserControl
    {
        private IFacadPattern Pattern;
        private readonly LoggerProvider<BankUC> loggerProvider;
        public BankUC()
        {
            InitializeComponent();
            Pattern = new FacadPattern();
            loggerProvider = new LoggerProvider<BankUC>();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = Pattern.ExecuteQuery(Pattern.BankService.ShowAll(Pattern.Paging.Order(Pattern.Paging.Page)));
            var count = (Pattern.ExecuteQuery(Pattern.BankService.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {Pattern.Paging.Page + 1}";

        }

        private void BankUC_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
            BankCombo = ComboBoxGenerator<long>.FillData(BankCombo, Pattern.BankService.TitleValue(), Convert.ToByte(BankCombo.Tag));
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var data = Pattern.BankService.GetData();
            }
            catch (Exception ex)
            {
                loggerProvider.ExceptionLog(ex);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            BankNewForm bankNewForm = new BankNewForm();
            bankNewForm.ShowDialog();
            ShowDataGrid();
        }
    }
}
