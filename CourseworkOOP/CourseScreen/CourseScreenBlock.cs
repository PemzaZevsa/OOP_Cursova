using CourseScreen;
using CourseworkOOP.Entities;
using CourseworkOOP.Entities.Courses;
using CourseworkOOP.Entities.Users;
using CourseworkOOP.Iterfaces;
using System.Xml.Linq;

namespace CourseScreenSpace
{
    public partial class CourseScreenBlock : UserControl
    {
        public event Predicate<Course> buyCourse;
        public event Action returnToScreen;
        public Course MyCourse { get; set; }
        public User MyUser { get; set; }
        public CanBuy MyCanBuy { get; set; }
        public CantBuy MyCantBuy { get; set; }
        public CourseScreenBlock(Course course, User user)
        {
            InitializeComponent();
            MyCourse = course;
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

            SetPicture(MyCourse.PicturePath);
            SetCost(MyCourse.Cost);

            nameLabel.Text = MyCourse.Name;
            descriptionLabel.Text = MyCourse.Description;
            raitingLabel.Text += " " + string.Join(" ", $"{Math.Round(MyCourse.Rating, 2)}", $"({MyCourse.RatingsAmount} відгуків)");
            tegsLabel.Text += " " + string.Join(", ", MyCourse.Tegs);
            authorLabel.Text += " " + string.Join(" ", MyCourse.AuthorName, MyCourse.AuthorSurname);
            studentsLabel.Text += $"{MyCourse.BoughtCourseAmount}";
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
            }

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

        private void buyButton_Click(object sender, EventArgs e)
        {
            buyCourse?.Invoke(MyCourse);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            returnToScreen?.Invoke();
        }
    }
}
