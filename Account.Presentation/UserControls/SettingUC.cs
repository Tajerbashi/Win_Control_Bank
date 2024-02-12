using Account.Application.Library.Patterns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account.Presentation.UserControls
{
    public partial class SettingUC : UserControl
    {
        private IFacadPattern Pattern;
        public SettingUC()
        {
            InitializeComponent();
            //Pattern = new FacadPattern();
        }
    }
}
