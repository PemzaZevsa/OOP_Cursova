using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegistrationScreen
{
    public partial class Registration : UserControl
    {
        public event Action<string,string,string,string,byte,int> regestrationButtonClick;
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
                    regestrationButtonClick?.Invoke(loginBox.Text,passwordBox.Text,nameBox.Text,surnameBox.Text,(byte)ageTrackBar.Value, userType);
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

        private void onScroll(object sender, EventArgs e)
        {
            ageValueLabel.Text = $"{ageTrackBar.Value}";
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
