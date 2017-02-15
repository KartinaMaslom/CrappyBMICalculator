using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            LabRat specimen = new LabRat();
            specimen.Birthdate = specimen.stringToDateConverter(this.birthDateTextBox.Text);
            specimen.Weight = specimen.stringToDoubleConverter(this.weightTextBox.Text);
            specimen.Height = specimen.stringToDoubleConverter(this.heightTextBox.Text);

            if ((specimen.Birthdate == DateTime.MinValue) ||
            (specimen.Weight == Double.MinValue) ||
            (specimen.Height == Double.MinValue))
            {
                MessageBox.Show("Something is wrong with data provided");
            }
            else 
            {
                double resultBMI = specimen.Weight / (specimen.Height * specimen.Height);
                if (resultBMI <= 15)
                    MessageBox.Show("Where did you find the Internet in Aushwitz????");
                else if (resultBMI > 15 && resultBMI <= 18.5)
                    MessageBox.Show("You are thin, lucky skinny bitch!");
                else if (resultBMI > 18.5 && resultBMI <= 25)
                    MessageBox.Show("Everything is ok! You are normal average shit!");
                else if (resultBMI > 25 && resultBMI <= 40)
                    MessageBox.Show("Hey, chubby donut!");
                else if (resultBMI > 40)
                    MessageBox.Show("OMG you are FAT, not NTFS!");
            }
            birthDateTextBox.Clear();
            weightTextBox.Clear();
            heightTextBox.Clear();
        }
    }
}
