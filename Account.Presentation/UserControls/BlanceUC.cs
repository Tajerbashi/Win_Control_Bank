using Account.Application.Library.Repositories.BUS;
using Account.Application.Library.Repositories.SEC;
using Account.Infrastructure.Library.Repositories.BUS;
using Account.Presentation.Generator;

namespace Account.Presentation.UserControls
{
    public partial class BlanceUC : UserControl
    {
        private readonly IUserRepository _userRepository;
        private readonly ICartRepository _cartRepository;
        public BlanceUC(
            IUserRepository userRepository,
            ICartRepository cartRepository
            )
        {
            _userRepository = userRepository;
            _cartRepository = cartRepository;
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //var data = _userRepository.GetAll();
            LoadPanelCartBlance();

        }

        private void LoadPanelCartBlance()
        {
            PanelCartBlance.Controls.Clear();
            ButtonGenerator button = new ButtonGenerator();
            var data = _cartRepository.GetAllCartWithDetails();
            int x = 20,y= 18;
            foreach (var item in data)
            {
                PanelCartBlance.Controls.Add(button.CreateButton(x, y, $"{item.CustomerName}\n{item.AccountNumber}\n{item.BankName}\n{(item.Blance.Value).ToString("#,#")}"));
                y = y + 128;
            }
        }

        
    }
}
