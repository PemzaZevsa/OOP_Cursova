using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserProfileScreen
{
    public partial class SetRaiting : Form
    {
        public event Action<double> raiting;
        public SetRaiting()
        {
            InitializeComponent();
        }

        private void raiteButton_Click(object sender, EventArgs e)
        {
            try
            {
                raiting?.Invoke((double)raitingTrackBar.Value);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка : {ex.Message}");
            }

        }

        private void raitingTrackBar_Scroll(object sender, EventArgs e)
        {
            raitingChangeLabel.Text = $"{raitingTrackBar.Value}";
        }
    }
}
