using HeaderSpace;

namespace CourseworkOOP
{
    public partial class Form1 : Form
    {
        public enum splitContainerState
        {
            MainState = 0,
            SideBarExtendState = 1
        }
        public splitContainerState splitState;
        public Form1()
        {
            InitializeComponent();
            header1.toMainScreen += ToMainScreen;
            header1.toUserProfile += ToUserProfileScreen;
            splitState =  splitContainerState.MainState;
        }

        public void ToMainScreen()
        {
            mainPanel.Controls.Clear();
            MainScreen.MainScreen screen = new MainScreen.MainScreen();
            mainPanel.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
        }

        public void ToUserProfileScreen()
        {
            mainPanel.Controls.Clear();
            UserProfileScreen.UserProfileScreen screen = new UserProfileScreen.UserProfileScreen();
            mainPanel.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
        }

        //public void Test2()
        //{
        //    panel1.Controls.Clear();
        //    Button button = new Button();
        //    panel1.Controls.Add(button);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
