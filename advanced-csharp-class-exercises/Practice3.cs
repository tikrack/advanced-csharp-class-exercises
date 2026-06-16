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
    public partial class Practice3 : Form
    {
        public Practice3()
        {
            InitializeComponent();
        }

        bool PatientNameValidation(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Error: Patient name cannot be empty!");
                return false;
            }

            return true;
        } 

        decimal CalculationTotalCost(decimal[] costs) {
            decimal total = 0;
            foreach (var cost in costs)
            {
                total += cost;
            }

            return total;
        }

        void PrintInvoice(string name, decimal total)
        {
            Console.WriteLine($"Invoice for: {name}");
            Console.WriteLine($"Total Amount to Pay: {total}$");
            Console.WriteLine("Thank you for choosing our clinic.");
        }

        public void ProcessAndPrintInvoice(string patientName, params decimal[] costs)
        {
            if (!PatientNameValidation(patientName)) return;

            decimal total = CalculationTotalCost(costs);

            PrintInvoice(patientName, total);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessAndPrintInvoice("Hossein Alizade", 10, 30, 50 , 40);
        }
    }
}
