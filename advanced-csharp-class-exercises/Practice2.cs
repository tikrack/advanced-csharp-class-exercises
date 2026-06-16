using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advanced_csharp_class_exercises
{
    public partial class Practice2 : Form
    {
        public Practice2()
        {
            InitializeComponent();
        }

        double CalculateBMI(double weight, double height, out string status)
        {
            double bmi = weight / (height * height);

            if (bmi < 18.5)
                status = "کمبود وزن";
            else if (bmi < 25)
                status = "نرمال";
            else if (bmi < 30)
                status = "اضافه وزن";
            else
                status = "چاقی";

            return bmi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string state;

            double r1 = CalculateBMI(
                weight: 83,
                height: 1.75,
                status: out state
            );

            MessageBox.Show($"BMI: {r1}");
            MessageBox.Show(state);
        }
    }
}
