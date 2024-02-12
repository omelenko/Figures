using Microsoft.VisualBasic;
namespace Figures
{
    public partial class Form1 : Form
    {
        public List<Circle> Circles;
        public List<Triangle> Triangles;
        public List<Square> Squares;
        public Form1()
        {
            Circles = new List<Circle>();
            Triangles = new List<Triangle>();
            Squares = new List<Square>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Введіть радіус кола", "Ввід", "1");
            Circle a = new Circle(double.Parse(input));
            Circles.Add(a);
            listBox1.Items.Add("Коло(" + input + ")");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Введіть три стороні через кому", "Ввід", "1,2,3");
            var input1 = input.Split(',');
            Triangle a = new Triangle(double.Parse(input1[0]), double.Parse(input1[1]), double.Parse(input1[2]));
            Triangles.Add(a);
            listBox2.Items.Add("Трикутник(" + input + ")");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Введіть сторону квадрата", "Ввід", "1");
            Square a = new Square(double.Parse(input));
            Squares.Add(a);
            listBox3.Items.Add("Квадрат(" + input + ")");
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show($"{Squares[listBox3.SelectedIndex].ShowArea()}", "Площа Квадрата");
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show($"{Triangles[listBox2.SelectedIndex].ShowArea()}", "Площа Трикутника");
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show($"{Circles[listBox1.SelectedIndex].ShowArea()}", "Площа Кола");
        }
    }
}
