using Account.Application.Library.Repositories.BUS;
using Account.Application.Library.Repositories.SEC;
using Account.Infrastructure.Library.Repositories.BUS;
using Account.Presentation.Generator;

namespace Account.Presentation.UserControls
{
    public partial class BlanceUC : UserControl
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICartRepository _cartRepository;
        public BlanceUC(
            ICustomerRepository customerRepository,
            ICartRepository cartRepository
            )
        {
            _customerRepository = customerRepository;
            _cartRepository = cartRepository;
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //var data = _userRepository.GetAll();
            BankingInfoPanelLoading();
            CashableInfoPanelLoading();
            CustomeInfoPanelLoading();
        }

        private void BankingInfoPanelLoading()
        {
            BankingInfoPanel.Controls.Clear();
            ButtonGenerator button = new ButtonGenerator();
            var data = _cartRepository.GetAllCartBankBlancesWithDetails();
            int x = 18,y= 18;
            foreach (var item in data)
            {
                BankingInfoPanel.Controls.Add(button.CreateButton(
                    x,
                    y,
                    $"{item.CustomerName}\n{item.AccountNumber}\n{item.BankName}\n{(item.Blance is null ? 0 : item.Blance.Value).ToString("#,#")}"
                    , 320
                    , 120
                    , Color.DarkBlue
                    , Color.Wheat
                    ));
                y = y + 128;
            }
        }
        private void CashableInfoPanelLoading()
        {
            CashableInfoPanel.Controls.Clear();
            ButtonGenerator button = new ButtonGenerator();
            var data = _cartRepository.GetAllCartCashableWithDetails();
            int x = 18,y= 18;
            foreach (var item in data)
            {
                CashableInfoPanel.Controls.Add(button.CreateButton(
                    x,
                    y,
                    $"نام مشترک : {item.CustomerName}\n نوع : {item.BankName}\n موجودی : {(item.Blance is null ? 0 : item.Blance.Value).ToString("#,#")}"
                    , 320
                    , 120
                    , Color.GreenYellow
                    , Color.Black
                    ));
                y = y + 128;
            }
        }
        private void CustomeInfoPanelLoading()
        {
            CustomInfoPanel.Controls.Clear();
            ButtonGenerator button = new ButtonGenerator();
            var data = _cartRepository.GetAllCartCustomeWithDetails();
            int x = 18,y= 18;
            foreach (var item in data)
            {
                CustomInfoPanel.Controls.Add(button.CreateButton(
                    x,
                    y,
                    $"{item.CustomerName}\n{item.AccountNumber}\n{item.BankName}\n{(item.Blance is null ? 0 : item.Blance.Value).ToString("#,#")}"
                    , 320
                    , 120
                    , Color.MediumSpringGreen
                    , Color.Black
                    ));
                y = y + 128;
            }

        }


        private void BlanceUC_Load(object sender, EventArgs e)
        {
            CustomerCombo = ComboBoxGenerator<long>.FillData(CustomerCombo, _customerRepository.CustomerTitleValue(), Convert.ToByte(CustomerCombo.Tag));
            BankingInfoPanelLoading();
            CashableInfoPanelLoading();
            CustomeInfoPanelLoading();
        }
    }
}
