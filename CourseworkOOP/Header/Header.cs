namespace HeaderSpace
{
    public partial class Header : UserControl
    {
        public delegate void ButtonClick();

        public event ButtonClick toMainScreen;
        public event ButtonClick search;
        public event ButtonClick toUserProfile;
        public event Action<string,string> changeCurrentUserLabel;
        public Header()
        {
            InitializeComponent();
            changeCurrentUserLabel += ChangeCurrentUserLabel;
        }

        private void ToMainScreen(object sender, EventArgs e)
        {
            toMainScreen?.Invoke();
        }

        private void ToSearch(object sender, EventArgs e)
        {
            search?.Invoke();
        }

        private void ToUserProfileScreen(object sender, EventArgs e)
        {
            toUserProfile?.Invoke();
        }

        public void ActivateChangeCurrentUserLabel(string name,string surname)
        {
            changeCurrentUserLabel?.Invoke(name, surname);
        }
        public void ChangeCurrentUserLabel(string name, string surname)
        {
            nameLabel.Text = $"{name} {surname}";
        }
    }
}
