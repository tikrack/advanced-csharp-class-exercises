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
    public partial class Practice1 : Form
    {
        public Practice1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculates the final visit fee after applying supplementary insurance
        /// and an optional discount percentage.
        /// </summary>
        /// <param name="basicVisitFee">The original visit fee before any deductions.</param>
        /// <param name="hasSupplementaryInsurance">
        /// Indicates whether supplementary insurance is available.
        /// If true, 30% of the fee will be deducted.
        /// </param>
        /// <param name="discountPercentage">
        /// The additional discount percentage to apply after insurance deduction.
        /// Default value is 0.
        /// </param>
        /// <returns>
        /// The final visit fee after all applicable deductions.
        /// </returns>

        double CalculateVisitFee(
            int basicVisitFee,
            bool hasSupplementaryInsurance = false,
            int discountPercentage = 0
        ){
            double fee = basicVisitFee;

            if (hasSupplementaryInsurance)
                fee = fee - (30 * fee / 100);

            fee = fee - (discountPercentage * fee / 100);

            return fee;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r1 = CalculateVisitFee(
                basicVisitFee: 50000,
                hasSupplementaryInsurance: false,
                discountPercentage: 10
            );

            double r2 = CalculateVisitFee(
                basicVisitFee: 15000,
                hasSupplementaryInsurance: true,
                discountPercentage: 0
            );

            double r3 = CalculateVisitFee(
                basicVisitFee: 35000,
                hasSupplementaryInsurance: true,
                discountPercentage: 30
            );

            MessageBox.Show(r1.ToString());
            MessageBox.Show(r2.ToString());
            MessageBox.Show(r3.ToString());
        }
    }
}
