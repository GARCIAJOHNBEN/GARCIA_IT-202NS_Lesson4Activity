using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GARCIA_IT202NS_Lesson4Activity
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                double rate;

                rate = Convert.ToDouble(txtBasicPerHour.Text); 
                rate = Convert.ToDouble(txtHonoPerHour.Text);

                MessageBox.Show("Valid Number Input.");

            }
            catch 
            {
                MessageBox.Show("Please enter a valid number only in Rate Per Hour.");
                txtBasicPerHour.Focus();
                txtBasicPerHour.Clear();
            }
            if (string.IsNullOrEmpty(txtEmployeeNo.Text) || 
                string.IsNullOrEmpty(txtFN.Text) ||
                string.IsNullOrEmpty(txtMN.Text) ||
                string.IsNullOrEmpty(txtSN.Text) ||
                string.IsNullOrEmpty(txtCivilSta.Text) ||
                string.IsNullOrEmpty(txtDesig.Text) ||
                string.IsNullOrEmpty(txtDep.Text) ||
                string.IsNullOrEmpty(txtEmployeeStat.Text) ||
                string.IsNullOrEmpty(txtDepartment.Text) ||

                string.IsNullOrEmpty(txtBasicPerHour.Text) ||
                string.IsNullOrEmpty(basic_numhrs.Text) ||
                string.IsNullOrEmpty(basic_rate.Text) ||
                string.IsNullOrEmpty(txtHonoPerHour.Text) ||
                string.IsNullOrEmpty(hono_numhrs.Text) ||
                string.IsNullOrEmpty(hono_rate.Text) ||
                string.IsNullOrEmpty(other_netincome.Text) ||
                string.IsNullOrEmpty(other_numhrs.Text) ||
                string.IsNullOrEmpty(other_rate.Text) ||
                string.IsNullOrEmpty(grossincome.Text) ||
                string.IsNullOrEmpty(netincome.Text) ||
                string.IsNullOrEmpty(basic_rate.Text) ||

                string.IsNullOrEmpty(txtSSS.Text) ||
                string.IsNullOrEmpty(txtPhi.Text) ||
                string.IsNullOrEmpty(txtPagibig.Text) ||
                string.IsNullOrEmpty(txtTax.Text) ||
                string.IsNullOrEmpty(sss_loanTxtbox.Text) ||
                string.IsNullOrEmpty(pagibig_loan.Text) ||
                string.IsNullOrEmpty(txtFSD.Text) ||
                string.IsNullOrEmpty(faculty_sav_loan.Text) ||
                string.IsNullOrEmpty(salaryloan.Text) ||
                string.IsNullOrEmpty(other_deduction.Text) ||
                string.IsNullOrEmpty(total_deduction.Text))

            {
                MessageBox.Show("Please fill in all the fields.");
                txtBasicPerHour.Focus();
            }   














        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRatePerHour_TextChanged(object sender, EventArgs e)
        {

        }

        private void hono_netincome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
