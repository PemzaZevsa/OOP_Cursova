using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseScreen
{
    public partial class MoneyInputForm : Form
    {
        public event Action<decimal> payment;
        public MoneyInputForm()
        {
            InitializeComponent();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            try
            {
                payment?.Invoke(decimal.Parse(moneyTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            Close();
        }
    }
}
