using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseScreen
{
    public partial class CanBuy : UserControl
    {
        public event Action buyCourse;
        public CanBuy()
        {
            InitializeComponent();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            buyCourse?.Invoke();
        }
    }
}
