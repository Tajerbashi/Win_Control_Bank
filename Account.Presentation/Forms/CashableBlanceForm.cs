using Account.Application.Library.Models.Controls;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Infrastructure.Library.Repositories.BUS;
using Account.Presentation.Generator;

namespace Account.Presentation.Forms
{
    public partial class CashableBlanceForm : Form
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IBankRepository _bankRepository;
        private readonly IBlanceRepository _blanceRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CashableBlanceForm(
            ICustomerRepository customerRepository,
            IBankRepository bankRepository,
            IBlanceRepository blanceRepository,
            IUnitOfWork unitOfWork
            )
        {
            _customerRepository = customerRepository;
            _bankRepository = bankRepository;
            _blanceRepository = blanceRepository;
            _unitOfWork = unitOfWork;
            InitializeComponent();
        }
        private void FillComboBoxes()
        {
            CustomerAccountCombo = ComboBoxGenerator<long>.FillData(CustomerAccountCombo, _unitOfWork.CustomerRepository.TitleValue(), Convert.ToByte(CustomerAccountCombo.Tag));
            FromCartCombo = ComboBoxGenerator<long>.FillData(FromCartCombo, _unitOfWork.CartRepository.TitleValuesAllParentCart(), Convert.ToByte(FromCartCombo.Tag));
            TransactionTypeCombo = ComboBoxGenerator<byte>.FillData(TransactionTypeCombo, _unitOfWork.BlanceRepository.TitleValueTransactionType(), Convert.ToByte(TransactionTypeCombo.Tag));
            BlanceTypeCombo = ComboBoxGenerator<byte>.FillData(BlanceTypeCombo, _unitOfWork.BlanceRepository.TitleValueBlanceType(), Convert.ToByte(BlanceTypeCombo.Tag));
            UnitCombo = ComboBoxGenerator<long>.FillData(UnitCombo, _unitOfWork.CartRepository.TitleValue(), Convert.ToByte(UnitCombo.Tag));
        }

        private void CashableBlanceForm_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void FromCartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ID = ((KeyValue<long>)FromCartCombo.SelectedItem).Value;
            if (ID != 0)
            {
                FromAccountCombo = ComboBoxGenerator<long>.FillData(
                    FromAccountCombo,
                    _unitOfWork.CartRepository.TitleValuesChild(ID),
                    Convert.ToByte(FromAccountCombo.Tag));
            }
            else
            {

            }
        }
    }
}
