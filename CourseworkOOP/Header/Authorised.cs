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
    public partial class Authorised : UserControl
    {
        public event Action toUserScreen;
        //public event Action<string, string> changeCurrentUserLabel;
        //public event Action<string> changePicToUserPic;
        public Authorised()
        {
            InitializeComponent();
            //changeCurrentUserLabel += ChangeCurrentUserLabel;
            //changePicToUserPic += ChangePicToUserPic;
        }

        private void userProfileButton_Click(object sender, EventArgs e)
        {
            toUserScreen?.Invoke();
        }

        public void ChangeCurrentUserLabel(string name, string surname)
        {
            nameLabel.Text = $"{name} {surname}";
        }

        //public void ChangePicToUserPic(string path)
        //{
        //    try
        //    {
        //        Image image = Image.FromFile(path);
        //        userProfileButton.BackgroundImage = image;
        //    }
        //    catch (Exception ex)
        //    {
        //        Image image2 = Image.FromFile(@"Data/Config/UserProfilePicturePlaceholder.png");
        //        userProfileButton.BackgroundImage = image2;
        //    }
        //}
    }
}
