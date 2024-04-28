using System;
using System.Data;
using System.Drawing;

namespace RegistrationScreen
{
    public partial class Registration : UserControl
    {
        public event Action<string,string,string,string,int> regestrationButtonClick;
        public event Action alreadyHaveAccountLabelClick;
        public event Action errorRegistrstion;
        public Registration()
        {
            InitializeComponent();
            errorRegistrstion += ErorRegistranion;
        }

        private void RegestrationButton_Click(object sender, EventArgs e)
        {
            int userType = -1;
            switch (userTypeBox.Text)
            {
                case "Студент" : userType = 2; break;
                case "Вчитель" : userType = 1; break;
                default:
                    break;
            }
            if (userType == -1)
            {
                ActivateError();
            }
            else
            {
                if (!string.IsNullOrEmpty(loginBox.Text) && loginBox.Text.Length>=5 && !string.IsNullOrEmpty(passwordBox.Text) && passwordBox.Text.Length>=5 && !string.IsNullOrEmpty(nameBox.Text) && !string.IsNullOrEmpty(surnameBox.Text))
                {
                    regestrationButtonClick?.Invoke(loginBox.Text,passwordBox.Text,nameBox.Text,surnameBox.Text, userType);
                }
                else
                {
                    ActivateError();
                }
            }
        }

        private void AlreadyHaveAccountLabel_Click(object sender, EventArgs e)
        {
            alreadyHaveAccountLabelClick?.Invoke();
        }
        public void ActivateError()
        {
            errorRegistrstion?.Invoke();
        }
        private void ErorRegistranion()
        {
            errorLabel.Text = $"Не вдалося створити акаунт";
        }
    }
}
