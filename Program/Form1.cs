using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            double a = float.Parse(TBa.Text);
            double b = float.Parse(TBb.Text);
            double c = float.Parse(TBc.Text);
            double d = float.Parse(TBd.Text);
            double x1 = 0;
            double x2 = 0;
            double D = 0;
            double x = 0;

            if (a == 0) //Решение при а равным нулю
            {
                if (c > 0)
                {
                    c = -c;
                }
                if (c < 0)
                {
                    c = c * (-1);
                }
                {
                    x = (d + c) / b;
                    labelD.Text = Convert.ToString("Коефициент 'а' равен нулю. Уравнение решено относительно формы kX+b=c");
                    labelX.Text = Convert.ToString("X = " + x);
                    goto M1;
                }
            }

            { // Решение при а не равным нулю
                if (d > 0)
                {
                    d = -d;
                }
                if (d < 0)
                {
                    d = d * (-1);
                }
                D = Math.Pow(b, 2) - 4 * a * c;
                if (D > 0)
                {
                    c = c + d;
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    AnswerX1.Text = Convert.ToString(x1);
                    AnswerX2.Text = Convert.ToString(x2);
                    LX1.Text = Convert.ToString("X1 = ");
                    LX2.Text = Convert.ToString("X2 = ");
                    labelD.Text = Convert.ToString("Дискриминант больше нуля");
                    labelX.Text = Convert.ToString("Дискриминант = " + D);
                    goto M2;
                }
                if (D == 0)
                {
                    c = c + d;
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = x1;
                    AnswerX1.Text = Convert.ToString(x1);
                    AnswerX2.Text = Convert.ToString(x2);
                    LX1.Text = Convert.ToString("X1 = ");
                    LX2.Text = Convert.ToString("X2 = ");
                    labelD.Text = Convert.ToString("Дискриминант равен нулю");
                    labelX.Text = Convert.ToString("Дискриминант = " + D);
                    goto M2;
                }
                if (D < 0)
                {
                    MessageBox.Show("Дискриминант данного уравнения отрицательный, D < 0, данное уравнение корней не имеет" + "\n" +"Дискриминант = " + D);
                    LX1.Text = Convert.ToString(" ");
                    LX2.Text = Convert.ToString(" ");
                    AnswerX1.Text = Convert.ToString(" ");
                    AnswerX2.Text = Convert.ToString(" ");
                    labelD.Text = Convert.ToString(" ");
                    labelX.Text = Convert.ToString(" ");
                }
            }
            M1:
            {
                LX1.Text = Convert.ToString(" ");
                LX2.Text = Convert.ToString(" ");
                AnswerX1.Text = Convert.ToString(" ");
                AnswerX2.Text = Convert.ToString(" ");
            }
            M2:
            {
                Lend.Text = Convert.ToString("Расчет окончен");
            }
        }
    }
}
