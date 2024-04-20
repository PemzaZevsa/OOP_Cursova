using System.Net;

namespace RegistrationScreen
{
    public partial class RegistrationScreen : UserControl
    {
        public event Action switchToRegistration;
        public event Action switchToAuthorisation;
        public Registration registration;
        public Authorisation authorisation;

        public RegistrationScreen()
        {
            InitializeComponent();

            switchToRegistration += () =>
            {
                middlePanel.Controls.Clear();
                middlePanel.Controls.Add(registration);
                registration.Dock = DockStyle.Fill;
            };

            switchToAuthorisation += () =>
            {
                middlePanel.Controls.Clear();
                middlePanel.Controls.Add(authorisation);
                authorisation.Dock = DockStyle.Fill;
            };

            registration = new Registration();
            registration.alreadyHaveAccountLabelClick += switchToAuthorisation;

            authorisation = authorisation1;
            authorisation.dontHaveAccountLabelClick += switchToRegistration;
        }
    }
}
