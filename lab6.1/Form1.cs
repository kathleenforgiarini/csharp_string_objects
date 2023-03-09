using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Kathleen Forgiarini da Silva \n2023-03-09 \nLab6.1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = textBox1.Text.Trim();
            string[] names = fullName.Split(' ');

            if (names.Length == 1)
            {
                string firstLetterN1 = names[0].Trim().Substring(0, 1).ToUpper();
                string otherLettersN1 = names[0].Trim().Substring(1).ToLower();

                MessageBox.Show("First Name: \t" + firstLetterN1 + otherLettersN1);
            }
            else if (names.Length == 2)
            {
                string firstLetterN1 = names[0].Trim().Substring(0, 1).ToUpper();
                string otherLettersN1 = names[0].Trim().Substring(1).ToLower();
                string firstLetterN2 = names[1].Trim().Substring(0, 1).ToUpper();
                string otherLettersN2 = names[1].Trim().Substring(1).ToLower();

                MessageBox.Show("First Name: \t" + firstLetterN1 + otherLettersN1 + "\nLast Name: \t" + firstLetterN2 + otherLettersN2);
            }
            else if (names.Length == 3)
            {
                string firstLetterN1 = names[0].Trim().Substring(0, 1).ToUpper();
                string otherLettersN1 = names[0].Trim().Substring(1).ToLower();
                string firstLetterN2 = names[1].Trim().Substring(0, 1).ToUpper();
                string otherLettersN2 = names[1].Trim().Substring(1).ToLower();
                string firstLetterN3 = names[2].Trim().Substring(0, 1).ToUpper();
                string otherLettersN3 = names[2].Trim().Substring(1).ToLower();

                MessageBox.Show("First Name: \t" + firstLetterN1 + otherLettersN1 + "\nMiddle Name: \t" + firstLetterN2 + otherLettersN2 +
                                "\nLast Name: \t" + firstLetterN3 + otherLettersN3);

            }
            else
            {
                MessageBox.Show("Error. Try again");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye bye!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string phone = textBox2.Text.Trim();
            string digitsOnly = phone.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "");
            string standard = digitsOnly.Insert(3, "-").Insert(7, "-");
            MessageBox.Show("Entered:\t" + phone +
                            "\nDigits only:\t" + digitsOnly +
                            "\nStandard format:\t" + standard);
        }
    }
}
