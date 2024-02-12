using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.SEC;

namespace Account.Presentation.UserControls
{
    public partial class BlanceUC : UserControl
    {
        private IFacadPattern Pattern;
        private readonly IUserRepository _userRepository;
        public BlanceUC(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            //Pattern = new FacadPattern();
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var data = _userRepository.GetAll();
        }
    }
}
