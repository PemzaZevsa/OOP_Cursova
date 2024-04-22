using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Header
{
    public partial class UnAuthorised : UserControl
    {
        public event Action toRegistationScreen;
        public UnAuthorised()
        {
            InitializeComponent();
        }

        private void registationButton_Click(object sender, EventArgs e)
        {
            toRegistationScreen?.Invoke();
        }
    }
}
