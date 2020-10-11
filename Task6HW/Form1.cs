using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string f = textBox1.Text;
                string n = textBox2.Text;
                string d = textBox3.Text;
                double a = double.Parse(f);
                double b = double.Parse(n);
                double c = double.Parse(d);
                if (c > 180 || c < 0)
                {
                    MessageBox.Show("Something is incorrect");
                }
                else
                {
                    Triangle triangle = new Triangle(a, b, c);
                    if (triangle.IsEquality())
                    {
                        EqulibriumTriangle Etriangle = new EqulibriumTriangle();
                        double per = triangle.Perimeter();
                        double area = triangle.Area();
                        MessageBox.Show("Is equality  triangle" + "\n" + "Perimeter - " + per + "\n" + "Area - " + area);
                    }
                    else if (triangle.IsIsosceles())
                    {
                        IsoscelesTriangle Itriangle = new IsoscelesTriangle();
                        double per = triangle.Perimeter();
                        double area = triangle.Area();
                        MessageBox.Show("Is isosceles triangle" + "\n" + "Perimeter - " + per + "\n" + "Area - " + area);
                    }
                    else
                    {
                        double per = triangle.Perimeter();
                        double area = triangle.Area();
                        MessageBox.Show("Perimeter - " + per + "\n" + "Area - " + area);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
