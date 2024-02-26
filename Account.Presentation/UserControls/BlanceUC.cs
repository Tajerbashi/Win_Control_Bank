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
            LoadPanelCartBlance();
            LoadFlowPanelCartBlance();
            LoadTablePanelCartBlance();
        }

        private void LoadPanelCartBlance()
        {
            PanelCartBlance.Controls.Clear();
            ButtonGenerator button = new ButtonGenerator();
            var data = _cartRepository.GetAllCartWithDetails();
            int x = 18,y= 18;
            foreach (var item in data)
            {
                PanelCartBlance.Controls.Add(button.CreateButton(
                    x,
                    y, 
                    $"{item.CustomerName}\n{item.AccountNumber}\n{item.BankName}\n{(item.Blance.Value).ToString("#,#")}" 
                    ,500
                    ,118
                    ));
                y = y + 128;
            }
        }
        private void LoadFlowPanelCartBlance()
        {
            FlowLayout.Controls.Clear();//187, 111
            ButtonGenerator button = new ButtonGenerator();
            var data = _cartRepository.GetAllCartWithDetails();
            int x=3,y=3;
            foreach (var item in data)
            {
                FlowLayout.Controls.Add(button.CreateButton(
                    x,
                    y,
                    $"{item.CustomerName}\n{item.AccountNumber}\n{item.BankName}\n{(item.Blance.Value).ToString("#,#")}"
                    , 187
                    , 111
                    ));
            }
        }
        private void LoadTablePanelCartBlance()
        {
            TableLayout.Controls.Clear();
            ButtonGenerator button = new ButtonGenerator();
            var data = _cartRepository.GetAllCartWithDetails();
            int x=3,y=3;//282, 189
            foreach (var item in data)
            {
                TableLayout.Controls.Add(button.CreateButton(
                    x,
                    y,
                    $"{item.CustomerName}\n{item.AccountNumber}\n{item.BankName}\n{(item.Blance.Value).ToString("#,#")}"
                    , 282
                    , 189
                    ));
            }

        }
        private void BlanceUC_Load(object sender, EventArgs e)
        {
            CustomerCombo = ComboBoxGenerator<long>.FillData(CustomerCombo, _customerRepository.CustomerTitleValue(), Convert.ToByte(CustomerCombo.Tag));

        }
    }
}
