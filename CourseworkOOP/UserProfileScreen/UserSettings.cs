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
    public partial class UserSettings : UserControl
    {
        public event Action<string, string, string> profileUpdate;
        public UserSettings()
        {
            InitializeComponent();
        }

        //private void pictureButton_Click(object sender, EventArgs e)
        //{
        //    if (pictureFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        try
        //        {
        //            Image newProfilePic = Image.FromFile(pictureFileDialog.FileName);
        //            previevPictureBox.Image = newProfilePic;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Помилка при завантаженні зображення: " + ex.Message);
        //        }
        //    }
        //}

        private void saveUserButton_Click(object sender, EventArgs e)
        {
            string newPasword = passwordTextBox.Text;

            string newName = nameTextBox.Text;

            string newSurname = surnameTextBox.Text;

            //Image newProfilePic = previevPictureBox.Image;

            profileUpdate?.Invoke(newPasword, newName, newSurname);
        }
    }
}
