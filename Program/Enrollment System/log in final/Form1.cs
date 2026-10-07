using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace log_in_final
{
    public partial class LOGINFORM : Form
    {
        public LOGINFORM()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LOGINPANEL.BackColor = Color.FromArgb(100, 0, 0, 0);
            checkbox.Checked = false;
            password.UseSystemPasswordChar = true;
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = username.Text;
            pass = password.Text;
            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("Login Successful!");
                mainform cagadas = new mainform();
                cagadas.ShowDialog();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Your Password is incorrect");
                username.Clear();
                password.Clear();
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                password.UseSystemPasswordChar = false; //show password
            }
            else
            {
                password.UseSystemPasswordChar = true; //hide password

            }


        }

       
    }

}
 