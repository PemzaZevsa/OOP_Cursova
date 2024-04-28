using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserProfileScreen
{
    public partial class Statistics : UserControl
    {
        public Statistics(uint courses,uint modules, uint lessons, uint users)
        {
            InitializeComponent();
            SetLabels(courses, modules, lessons, users);
        }

        public void SetLabels(uint courses, uint modules, uint lessons, uint users)
        {
            userCreatedLabel.Text += users;
            coursesCreatedLabel.Text += courses;
            moduleCreatedLabel.Text += modules;
            lessonsCreatedLabel.Text += lessons;
        }
    }
}
