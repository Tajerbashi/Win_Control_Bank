using Account.Application.Library.Models.Controls;
using Account.Application.Library.Repositories.BUS;
using Account.Domain.Library.Enums;
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
        private long CartId;
        private byte TransactionType;
        public TransactionUC(IBlanceRepository blanceRepository, ICartRepository cartRepository, TransactionNewForm transaction)
        {
            _blanceRepository = blanceRepository;
            _cartRepository = cartRepository;
            this.transaction = transaction;
            CartId = 0;
            InitializeComponent();
        }
        private void ShowDataGrid()
        {
            if (CartId == 0)
            {
                GridData.DataSource = _blanceRepository.ExecuteQuery(_blanceRepository.Show50LastBankingTransactions((TransactionType)TransactionType, _blanceRepository.Paging.Order(_blanceRepository.Paging.Page)));
            }
            else
            {
                GridData.DataSource = _blanceRepository.ExecuteQuery(_blanceRepository.ShowBankingTransactionsByCartID(CartId, (TransactionType)TransactionType, _blanceRepository.Paging.Order(_blanceRepository.Paging.Page)));
            }
            var count = (_blanceRepository.ExecuteQuery(_blanceRepository.GetCount())).Rows[0].Field<int>(0);
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_blanceRepository.Paging.Page + 1}";
        }


        private void TransactionUC_Load(object sender, EventArgs e)
        {
            CartCombo = ComboBoxGenerator<long>.FillData(CartCombo, _cartRepository.TitleValuesAllCart(), Convert.ToByte(CartCombo.Tag));
            TransactionKindCombo = ComboBoxGenerator<byte>.FillData(TransactionKindCombo, _blanceRepository.TitleValueTransactionType(), Convert.ToByte(TransactionKindCombo.Tag));
            ShowDataGrid();
        }

        private void CartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartId = (CartCombo.SelectedItem as KeyValue<long>).Value;
            ShowDataGrid();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            transaction.ShowDialog();
            ShowDataGrid();
        }

        private void BlanceTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDataGrid();
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            _blanceRepository.Paging.Prev();
            ShowDataGrid();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            var count = (_blanceRepository.ExecuteQuery(_blanceRepository.GetCount())).Rows[0].Field<int>(0);
            _blanceRepository.Paging.Next(20, count);
            ShowDataGrid();

        }

        private void TransactionKindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = TransactionKindCombo.SelectedItem as KeyValue<byte>;
            if (combo is not null)
            {
                TransactionType = (TransactionKindCombo.SelectedItem as KeyValue<byte>).Value;
            }
            else
            {
                TransactionType = 0;
            }
            ShowDataGrid();
        }
    }
}
