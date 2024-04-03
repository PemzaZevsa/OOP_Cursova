namespace HeaderSpace
{
    public partial class Header : UserControl
    {
        public delegate void ButtonClick();

        public event ButtonClick toMainScreen;
        public event ButtonClick search;
        public event ButtonClick notifications;
        public event ButtonClick toUserProfile;
        public Header()
        {
            InitializeComponent();
        }

        private void ToMainScreen(object sender, EventArgs e)
        {
            toMainScreen?.Invoke();
        }

        private void ToSearch(object sender, EventArgs e)
        {
            search?.Invoke();
        }

        private void Notifications(object sender, EventArgs e)
        {
            notifications?.Invoke();
        }

        private void ToUserProfileScreen(object sender, EventArgs e)
        {
            toUserProfile?.Invoke();
        }
    }
}
