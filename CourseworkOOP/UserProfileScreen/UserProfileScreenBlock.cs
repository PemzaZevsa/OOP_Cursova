using CourseworkOOP.Entities.Users;

namespace UserProfileScreen
{
    public partial class UserProfileScreenBlock : UserControl
    {
        public event Action logOut;
        public User User { get; set; }
        public UserProfileScreenBlock(User user)
        {
            InitializeComponent();
            SetPicture(user.ProfilePicturePath);
            this.User = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void SetPicture(string path)
        {
            try
            {
                Image image = Image.FromFile(path);
                userProfilePictureBox.Image = image;
            }
            catch (Exception ex)
            {
                Image image2 = Image.FromFile(@"Data/Config/UserProfilePicturePlaceholder.png");
                userProfilePictureBox.Image = image2;
                MessageBox.Show("Помилка завантаження зображения: " + ex.Message);
            }

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            logOut?.Invoke();
        }
    }
}
