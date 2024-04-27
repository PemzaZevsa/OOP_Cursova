using CourseScreen;
using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities.Users;
using CourseworkOOP.Iterfaces;

namespace CourseScreenSpace
{
    public partial class CourseScreenBlock : UserControl
    {
        public event Predicate<Course> buyCourse;
        public event Action returnToScreen;
        public Course Course { get; set; }
        public User MyUser { get; set; }
        public CanBuy MyCanBuy { get; set; }
        public CantBuy MyCantBuy { get; set; }
        public CourseScreenBlock(Course course, User user)
        {
            InitializeComponent();
            Course = course;
            MyUser = user;
            MyCantBuy = new CantBuy();
            MyCanBuy = new CanBuy();
            MyCanBuy.buyCourse += () =>
            {
                if (MessageBox.Show($"Купити курс?\nНазва : {course.Name}\nЦіна : {course.Cost}","Покупка курса",MessageBoxButtons.OKCancel) == DialogResult.Cancel) 
                {
                    return;
                }

                var buyer = (Student)user;
                var buyForm = new MoneyInputForm();
                decimal moneyPayed = 0;

                buyForm.payment += (gottedMoney) =>
                {
                    moneyPayed = gottedMoney;
                };

                buyForm.ShowDialog();

                if (buyer.BuyCourse(course, moneyPayed))
                {
                    MessageBox.Show("Курс придбано успішно");
                }
                else
                {
                    MessageBox.Show("Курс не було придбано : нестача грошей на рахунку");
                }
            };

            SetName(Course.Name);
            SetDescription(Course.Description);
            SetRaiting(Course.Rating, Course.RatingsAmount);
            SetTegs(Course.Tegs);
            SetPicture(Course.PicturePath);
            SetAuthor(Course.AuthorName, Course.AuthorSurname);
            SetCost(Course.Cost);
            SetStudents(Course.BoughtCourseAmount);
        }
        private void SetName(string name)
        {
            nameLabel.Text = name;
        }
        private void SetDescription(string description)
        {
            descriptionLabel.Text = description;
        }
        private void SetRaiting(double raiting, int raitingsAmount)
        {
            raitingLabel.Text += " " + string.Join(" ", $"{Math.Round(raiting, 2)}", $"({raitingsAmount} відгуків)");
        }
        private void SetTegs(List<Teg> Tegs)
        {
            tegsLabel.Text += " " + string.Join(", ", Tegs);
        }
        private void SetPicture(string path)
        {
            try
            {
                Image image = Image.FromFile(path);
                coursePictureBox.Image = image;
            }
            catch (Exception ex)
            {
                Image image2 = Image.FromFile(@"Data/Config/CoursePlaceholder.png");
                coursePictureBox.Image = image2;
                MessageBox.Show("Помилка завантаження зображения: " + ex.Message);
            }

        }
        private void SetAuthor(string authorName, string authorSurname)
        {
            authorLabel.Text += " " + string.Join(" ", authorName, authorSurname);
        }
        private void SetCost(decimal cost)
        {
            if (cost == 0)
                costLabel.Text += $" Безкоштовно";
            else
                costLabel.Text += $" {cost}";

            if (MyUser is IStudyable)
            {
                buyPanel.Controls.Add(MyCanBuy);
                MyCanBuy.Dock = DockStyle.Fill;                
            }
            if (MyUser is null)
            {
                Label label = new Label();
                label.Text = "Увійдіть в обліковий запис";
                buyPanel.Controls.Add(label);
                label.Dock = DockStyle.Fill;
            }
            else
            {
                Label label2 = new Label();
                label2.Text = "Ви не можете покупати курси";
                buyPanel.Controls.Add(label2);
                label2.Dock = DockStyle.Fill;
            }
            
        }
        private void SetStudents(uint studentsAmount)
        {
            studentsLabel.Text += $"{studentsAmount}";
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            buyCourse?.Invoke(Course);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            returnToScreen?.Invoke();
        }
    }
}
