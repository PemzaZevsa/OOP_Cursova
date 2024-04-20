using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationScreen
{
    public partial class Authorisation : UserControl
    {
        public event Action<string,string> authorisationButtonClick;
        public event Action dontHaveAccountLabelClick;
        public event Action errorAuthorisation;
        public Authorisation()
        {
            InitializeComponent();
            errorAuthorisation += ErorAuthorisation;
        }

        private void AuthorisationButton_Click(object sender, EventArgs e)
        {
            authorisationButtonClick?.Invoke(loginBox.Text,passwordBox.Text);
        }

        private void DontHaveAccountLabel_Click(object sender, EventArgs e)
        {
            dontHaveAccountLabelClick?.Invoke();
        }
        public void ActivateError()
        {
            errorAuthorisation?.Invoke();
        }
        private void ErorAuthorisation()
        {
            errorLabel.Text = $"Не вірний логін або пароль";
        }
    }
}
