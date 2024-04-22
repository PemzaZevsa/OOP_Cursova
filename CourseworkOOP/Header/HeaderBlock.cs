﻿using Header;

namespace HeaderSpace
{
    public partial class HeaderBlock : UserControl
    {
        public delegate void ButtonClick();

        public event Action toMainScreen;
        public event Action toSearchScreen;
        public event Action toUserProfileScreen;
        public event Action toRegistrationScreen;
        public event Action changeToAuthorised;
        public event Action changeToUnAuthorised;

        //
        public event Action<string,string> changeCurrentUserLabel;
        //

        public Authorised authorised;
        public HeaderBlock()
        {
            InitializeComponent();
            changeCurrentUserLabel += ChangeCurrentUserLabel;
            authorised = new Authorised();

            authorised.toUserScreen += ToUserProfileScreen;
            unAuthorised.toRegistationScreen += ToRegistrationScreen;
        }

        private void ToMainScreen(object sender, EventArgs e)
        {
            toMainScreen?.Invoke();
        }

        private void ToSearch(object sender, EventArgs e)
        {
            toSearchScreen?.Invoke();
        }

        private void ToUserProfileScreen()
        {
            toUserProfileScreen?.Invoke();
        }
        private void ToRegistrationScreen()
        {
            toRegistrationScreen?.Invoke();
        }

        public void ActivateChangeCurrentUserLabel(string name,string surname)
        {
            changeCurrentUserLabel?.Invoke(name, surname);
        }

        public void ChangeCurrentUserLabel(string name, string surname)
        {
            authorised.ChangeCurrentUserLabel(name, surname);
        }

        public void ChangeToAuthorised()
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(authorised);
            authorised.Dock = DockStyle.Fill;
        }
        public void ChangeToUnAuthorised()
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(unAuthorised);
            unAuthorised.Dock = DockStyle.Fill;
        }
    }
}
