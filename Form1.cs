using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicNumber
{
    public partial class MagicNumber : Form
    {
        int finalYear;
        int finalMonth;
        int finalDay;
        int magicNumber;
        Color finalColor;
        public MagicNumber()
        {
            InitializeComponent();   
           
        }        
        private void luckyButton_Click(object sender, EventArgs e)
        {
            if (birthYearCombo.SelectedIndex < 0 || birthMonthCombo.SelectedIndex < 0 || birthDayCombo.SelectedIndex < 0)
            {
                MessageBox.Show("You must fill out the form to get a lucky number!");
            }
            else
            {
                if(finalColor == default)
                {
                    MessageBox.Show("Select a favorite color");
                }
                else
                {
                    finalYear = int.Parse(birthYearCombo.SelectedItem.ToString());
                    finalMonth = int.Parse(birthMonthCombo.SelectedItem.ToString());
                    finalDay = int.Parse(birthDayCombo.SelectedItem.ToString());

                    magicNumber = (finalYear / finalDay) * ((finalMonth / finalYear) ^ 3);

                    result resultForm = new result();
                    resultForm.magicNumberResultLabel.Text = magicNumber.ToString();
                    resultForm.magicNumberResultLabel.ForeColor = finalColor;
                    resultForm.ShowDialog();
                }                
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //on load, we see birth year and birth month dropdowns populated 
            //populate years
            int birthYear = 1908;            
            for (int i = 1908; i <= 2021; i++)
            {                
                birthYearCombo.Items.Add(birthYear);
                birthYear += 1;                
            }

            //populate months
            int birthMonth = 1;
            for(int i = 1; i < 13; i++)
            {
                birthMonthCombo.Items.Add(birthMonth);
                birthMonth++;
            }            
        }

        private void birthMonthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDayCombo.Items.Clear();

            int[] monthDays = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int daysToPoulate = monthDays[birthMonthCombo.SelectedIndex];
            for (int i = 1; i < daysToPoulate +1; i++)
            {
                birthDayCombo.Items.Add(i);
            }
            
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                finalColor = colorDialog1.Color;
            }
            else
            {
                finalColor = default;
            }
                
        }
    }
}
