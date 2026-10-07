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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void BSTM_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BACK_Click(object sender, EventArgs e)
        {
            ADMINPAN.Show();
            FACULTY.Show();
            STUDENT.Show();
            COURSEPAN.Hide();
            BSITPAN.Hide();
            BEEDPAN.Hide();
            BSEDPAN.Hide();
            BSHMPAN.Hide();
            BSTMPAN.Hide();
            BSCPAN.Hide();
            BSNPAN.Hide();
            BSBAPAN.Hide();
            BPEPAN.Hide();
            BSNEDPAN.Hide();
            BSGEPAN.Hide();

        }

        private void ADMIN_Click(object sender, EventArgs e)
        {
            COURSEPAN.Show();
            FACULTY.Visible = false;
            STUDENT.Visible = false;
        }

        private void BSIT_Click(object sender, EventArgs e)
        {
            BSITPAN.Show();
            BEEDPAN.Hide();
            BSEDPAN.Hide();
            BSHMPAN.Hide();
            BSTMPAN.Hide();
            BSCPAN.Hide();
            BSNPAN.Hide();
            BSBAPAN.Hide();
            BPEPAN.Hide();
            BSGEPAN.Hide();
            BSNEDPAN.Hide();
        }

        private void BSITNEW_Click(object sender, EventArgs e)
        {
            BSITADD.Visible = true;
            BSITNEW.Enabled = false;

            BSITFN.Enabled = true;
            BSITLN.Enabled = true;
            BSITMN.Enabled = true;
            BSITBD.Enabled = true;
            BSITAGE.Enabled = true;
            BSITGENDER.Enabled = true;
            BSITADDRESS.Enabled = true;
            BSITEMAIL.Enabled = true;
            BSITCN.Enabled = true;

            BSITFN.Visible = true;
            BSITLN.Visible = true;
            BSITMN.Visible = true;
            BSITBD.Visible = true;
            BSITAGE.Visible = true;
            BSITGENDER.Visible = true;
            BSITADDRESS.Visible = true;
            BSITEMAIL.Visible = true;
            BSITCN.Visible = true;

        }

        private void BSITADD_Click(object sender, EventArgs e)
        {
            BSITNEW.Enabled = false;

            ListViewItem AC = new ListViewItem(BSITFN.Text);

            AC.SubItems.Add(BSITLN.Text);
            AC.SubItems.Add(BSITMN.Text);
            AC.SubItems.Add(BSITBD.Text);
            AC.SubItems.Add(BSITAGE.Text);
            AC.SubItems.Add(BSITGENDER.Text);
            AC.SubItems.Add(BSITADDRESS.Text);
            AC.SubItems.Add(BSITEMAIL.Text);
            AC.SubItems.Add(BSITCN.Text);

            BSITLIST.Items.Add(AC);

            BSITFN.Text = "";
            BSITLN.Text = "";
            BSITMN.Text = "";
            BSITBD.Text = "";
            BSITAGE.Text = "";
            BSITGENDER.Text = "";
            BSITADDRESS.Text = "";
            BSITEMAIL.Text = "";
            BSITCN.Text = "";

            BSITFN.Enabled = true;
            BSITLN.Enabled = true;
            BSITMN.Enabled = true;
            BSITBD.Enabled = true;
            BSITAGE.Enabled = true;
            BSITGENDER.Enabled = true;
            BSITADDRESS.Enabled = true;
            BSITEMAIL.Enabled = true;
            BSITCN.Enabled = true;

            BSITUPDATE.Visible = true;
            BSITUPDATE.Enabled = true;
            BSITDELETE.Visible = true;
            BSITDELETE.Enabled = true;

        }

        private void BSITUPDATE_Click(object sender, EventArgs e)
        {
            if (BSITLIST.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = BSITLIST.SelectedItems[0];

                selectedItem.SubItems[0].Text = BSITFN.Text;
                selectedItem.SubItems[1].Text = BSITLN.Text;
                selectedItem.SubItems[2].Text = BSITMN.Text;
                selectedItem.SubItems[3].Text = BSITBD.Text;
                selectedItem.SubItems[4].Text = BSITAGE.Text;
                selectedItem.SubItems[5].Text = BSITGENDER.Text;
                selectedItem.SubItems[6].Text = BSITADDRESS.Text;
                selectedItem.SubItems[7].Text = BSITEMAIL.Text;
                selectedItem.SubItems[8].Text = BSITCN.Text;

                MessageBox.Show(
                    "Student record updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }   
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void BSITDELETE_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                "Are you sure you want to delete this student record?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Student record deleted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            } if (BSITLIST.SelectedItems.Count > 0)
            {
                DialogResult AC = MessageBox.Show(
                    "Are you sure you want to delete this student record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (AC == DialogResult.Yes)
                {
                    BSITLIST.Items.Remove(BSITLIST.SelectedItems[0]);

                    MessageBox.Show(
                        "Student record deleted successfully!",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void mainform_Load(object sender, EventArgs e)
        {
            //BSIT//
            BSITLIST.View = View.Details;
            BSITLIST.FullRowSelect = true;
            BSITLIST.GridLines = true;

            BSITLIST.Columns.Add("FirstName", 75);
            BSITLIST.Columns.Add("Last Name", 75);
            BSITLIST.Columns.Add("Middle Name", 75);
            BSITLIST.Columns.Add("Birth Date", 75);
            BSITLIST.Columns.Add("Age", 50);
            BSITLIST.Columns.Add("GENDER", 75);
            BSITLIST.Columns.Add("ADDRESS", 75);
            BSITLIST.Columns.Add("EMAIL ADD", 75);
            BSITLIST.Columns.Add("CONTACT #", 75);


            //BEED//
            BEEDLIST.View = View.Details;
            BEEDLIST.FullRowSelect = true;
            BEEDLIST.GridLines = true;

            BEEDLIST.Columns.Add("FirstName", 75);
            BEEDLIST.Columns.Add("Last Name", 75);
            BEEDLIST.Columns.Add("Middle Name", 75);
            BEEDLIST.Columns.Add("Birth Date", 75);
            BEEDLIST.Columns.Add("Age", 50);
            BEEDLIST.Columns.Add("GENDER", 75);
            BEEDLIST.Columns.Add("ADDRESS", 75);
            BEEDLIST.Columns.Add("EMAIL ADD", 75);
            BEEDLIST.Columns.Add("CONTACT #", 75);


            //BSED//
            BSEDLIST.View = View.Details;
            BSEDLIST.FullRowSelect = true;
            BSEDLIST.GridLines = true;

            BSEDLIST.Columns.Add("FirstName", 75);
            BSEDLIST.Columns.Add("Last Name", 75);
            BSEDLIST.Columns.Add("Middle Name", 75);
            BSEDLIST.Columns.Add("Birth Date", 75);
            BSEDLIST.Columns.Add("Age", 50);
            BSEDLIST.Columns.Add("GENDER", 75);
            BSEDLIST.Columns.Add("ADDRESS", 75);
            BSEDLIST.Columns.Add("EMAIL ADD", 75);
            BSEDLIST.Columns.Add("CONTACT #", 75);

            
            //BSHM//
            BSHMLIST.View = View.Details;
            BSHMLIST.FullRowSelect = true;
            BSHMLIST.GridLines = true;

            BSHMLIST.Columns.Add("FirstName", 75);
            BSHMLIST.Columns.Add("Last Name", 75);
            BSHMLIST.Columns.Add("Middle Name", 75);
            BSHMLIST.Columns.Add("Birth Date", 75);
            BSHMLIST.Columns.Add("Age", 50);
            BSHMLIST.Columns.Add("GENDER", 75);
            BSHMLIST.Columns.Add("ADDRESS", 75);
            BSHMLIST.Columns.Add("EMAIL ADD", 75);
            BSHMLIST.Columns.Add("CONTACT #", 75);


            //BSTM//
            BSTMLIST.View = View.Details;
            BSTMLIST.FullRowSelect = true;
            BSTMLIST.GridLines = true;

            BSTMLIST.Columns.Add("FirstName", 75);
            BSTMLIST.Columns.Add("Last Name", 75);
            BSTMLIST.Columns.Add("Middle Name", 75);
            BSTMLIST.Columns.Add("Birth Date", 75);
            BSTMLIST.Columns.Add("Age", 50);
            BSTMLIST.Columns.Add("GENDER", 75);
            BSTMLIST.Columns.Add("ADDRESS", 75);
            BSTMLIST.Columns.Add("EMAIL ADD", 75);
            BSTMLIST.Columns.Add("CONTACT #", 75);

            //BSC//
            BSCLIST.View = View.Details;
            BSCLIST.FullRowSelect = true;
            BSCLIST.GridLines = true;

            BSCLIST.Columns.Add("FirstName", 75);
            BSCLIST.Columns.Add("Last Name", 75);
            BSCLIST.Columns.Add("Middle Name", 75);
            BSCLIST.Columns.Add("Birth Date", 75);
            BSCLIST.Columns.Add("Age", 50);
            BSCLIST.Columns.Add("GENDER", 75);
            BSCLIST.Columns.Add("ADDRESS", 75);
            BSCLIST.Columns.Add("EMAIL ADD", 75);
            BSCLIST.Columns.Add("CONTACT #", 75);

            //BSN//
            BSNLIST.View = View.Details;
            BSNLIST.FullRowSelect = true;
            BSCLIST.GridLines = true;

            BSNLIST.Columns.Add("FirstName", 75);
            BSNLIST.Columns.Add("Last Name", 75);
            BSNLIST.Columns.Add("Middle Name", 75);
            BSNLIST.Columns.Add("Birth Date", 75);
            BSNLIST.Columns.Add("Age", 50);
            BSNLIST.Columns.Add("GENDER", 75);
            BSNLIST.Columns.Add("ADDRESS", 75);
            BSNLIST.Columns.Add("EMAIL ADD", 75);
            BSNLIST.Columns.Add("CONTACT #", 75);

            //BSBA//
            BSBALIST.View = View.Details;
            BSBALIST.FullRowSelect = true;
            BSBALIST.GridLines = true;

            BSBALIST.Columns.Add("FirstName", 75);
            BSBALIST.Columns.Add("Last Name", 75);
            BSBALIST.Columns.Add("Middle Name", 75);
            BSBALIST.Columns.Add("Birth Date", 75);
            BSBALIST.Columns.Add("Age", 50);
            BSBALIST.Columns.Add("GENDER", 75);
            BSBALIST.Columns.Add("ADDRESS", 75);
            BSBALIST.Columns.Add("EMAIL ADD", 75);
            BSBALIST.Columns.Add("CONTACT #", 75);

            //BPE//
            BPELIST.View = View.Details;
            BPELIST.FullRowSelect = true;
            BPELIST.GridLines = true;

            BPELIST.Columns.Add("FirstName", 75);
            BPELIST.Columns.Add("Last Name", 75);
            BPELIST.Columns.Add("Middle Name", 75);
            BPELIST.Columns.Add("Birth Date", 75);
            BPELIST.Columns.Add("Age", 50);
            BPELIST.Columns.Add("GENDER", 75);
            BPELIST.Columns.Add("ADDRESS", 75);
            BPELIST.Columns.Add("EMAIL ADD", 75);
            BPELIST.Columns.Add("CONTACT #", 75);


            //BSNED//
            BSNEDLIST.View = View.Details;
            BSNEDLIST.FullRowSelect = true;
            BSNEDLIST.GridLines = true;

            BSNEDLIST.Columns.Add("FirstName", 75);
            BSNEDLIST.Columns.Add("Last Name", 75);
            BSNEDLIST.Columns.Add("Middle Name", 75);
            BSNEDLIST.Columns.Add("Birth Date", 75);
            BSNEDLIST.Columns.Add("Age", 50);
            BSNEDLIST.Columns.Add("GENDER", 75);
            BSNEDLIST.Columns.Add("ADDRESS", 75);
            BSNEDLIST.Columns.Add("EMAIL ADD", 75);
            BSNEDLIST.Columns.Add("CONTACT #", 75);


            //BSGE//
            BSGELIST.View = View.Details;
            BSGELIST.FullRowSelect = true;
            BSGELIST.GridLines = true;

            BSGELIST.Columns.Add("FirstName", 75);
            BSGELIST.Columns.Add("Last Name", 75);
            BSGELIST.Columns.Add("Middle Name", 75);
            BSGELIST.Columns.Add("Birth Date", 75);
            BSGELIST.Columns.Add("Age", 50);
            BSGELIST.Columns.Add("GENDER", 75);
            BSGELIST.Columns.Add("ADDRESS", 75);
            BSGELIST.Columns.Add("EMAIL ADD", 75);
            BSGELIST.Columns.Add("CONTACT #", 75);

        }

        private void BSITLIST_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (BSITLIST.SelectedItems.Count > 0)
            {
                ListViewItem item = BSITLIST.SelectedItems[0];

                BSITFN.Text = item.SubItems[0].Text;
                BSITLN.Text = item.SubItems[1].Text;
                BSITMN.Text = item.SubItems[2].Text;
                BSITBD.Text = item.SubItems[3].Text;
                BSITAGE.Text = item.SubItems[4].Text;
                BSITGENDER.Text = item.SubItems[5].Text;
                BSITADDRESS.Text = item.SubItems[6].Text;
                BSITEMAIL.Text = item.SubItems[7].Text;
                BSITCN.Text = item.SubItems[8].Text;
            }

        }



        private void BEED_Click(object sender, EventArgs e)
        {
            BEEDPAN.Show();
            BSITPAN.Hide();
            BSEDPAN.Hide();
            BSHMPAN.Hide();
            BSTMPAN.Hide();
            BSCPAN.Hide();
            BSNPAN.Hide();
            BSBAPAN.Hide();
            BPEPAN.Hide();
            BSGEPAN.Hide();
            BSNEDPAN.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                BEEDPICTURE.Image = Image.FromFile(opf.FileName);
            };
        }

        private void BSITPICTURE_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                BSITPICTURE.Image = Image.FromFile(opf.FileName);
            };
        }

        private void BEEDNEW_Click(object sender, EventArgs e)
        {
            BEEDADD.Visible = true;
            BEEDNEW.Enabled = false;

            BEEDFN.Enabled = true;
            BEEDLN.Enabled = true;
            BEEDMN.Enabled = true;
            BEEDBD.Enabled = true;
            BEEDAGE.Enabled = true;
            BEEDGENDER.Enabled = true;
            BEEDADDRESS.Enabled = true;
            BEEDEMAIL.Enabled = true;
            BEEDCN.Enabled = true;

            BEEDFN.Visible = true;
            BEEDLN.Visible = true;
            BEEDMN.Visible = true;
            BEEDBD.Visible = true;
            BEEDAGE.Visible = true;
            BEEDGENDER.Visible = true;
            BEEDADDRESS.Visible = true;
            BEEDEMAIL.Visible = true;
            BEEDCN.Visible = true;

        }

        private void BEEDADD_Click(object sender, EventArgs e)
        {
            BEEDNEW.Enabled = false;

            ListViewItem AC = new ListViewItem(BEEDFN.Text);

            AC.SubItems.Add(BEEDLN.Text);
            AC.SubItems.Add(BEEDMN.Text);
            AC.SubItems.Add(BEEDBD.Text);
            AC.SubItems.Add(BEEDAGE.Text);
            AC.SubItems.Add(BEEDGENDER.Text);
            AC.SubItems.Add(BEEDADDRESS.Text);
            AC.SubItems.Add(BEEDEMAIL.Text);
            AC.SubItems.Add(BEEDCN.Text);

            BEEDLIST.Items.Add(AC);

            BEEDFN.Text = "";
            BEEDLN.Text = "";
            BEEDMN.Text = "";
            BEEDBD.Text = "";
            BEEDAGE.Text = "";
            BEEDGENDER.Text = "";
            BEEDADDRESS.Text = "";
            BEEDEMAIL.Text = "";
            BEEDCN.Text = "";

            BEEDFN.Enabled = true;
            BEEDLN.Enabled = true;
            BEEDMN.Enabled = true;
            BEEDBD.Enabled = true;
            BEEDAGE.Enabled = true;
            BEEDGENDER.Enabled = true;
            BEEDADDRESS.Enabled = true;
            BEEDEMAIL.Enabled = true;
            BEEDCN.Enabled = true;

            BEEDUPDATE.Visible = true;
            BEEDUPDATE.Enabled = true;
            BEEDDELETE.Visible = true;
            BEEDDELETE.Enabled = true;

        }

        private void BEEDUPDATE_Click(object sender, EventArgs e)
        {
            if (BEEDLIST.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = BEEDLIST.SelectedItems[0];

                selectedItem.SubItems[0].Text = BEEDFN.Text;
                selectedItem.SubItems[1].Text = BEEDLN.Text;
                selectedItem.SubItems[2].Text = BEEDMN.Text;
                selectedItem.SubItems[3].Text = BEEDBD.Text;
                selectedItem.SubItems[4].Text = BEEDAGE.Text;
                selectedItem.SubItems[5].Text = BEEDGENDER.Text;
                selectedItem.SubItems[6].Text = BEEDADDRESS.Text;
                selectedItem.SubItems[7].Text = BEEDEMAIL.Text;
                selectedItem.SubItems[8].Text = BEEDCN.Text;

                MessageBox.Show(
                    "Student record updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void BEEDDELETE_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                "Are you sure you want to delete this student record?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Student record deleted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            } if (BSITLIST.SelectedItems.Count > 0)
            {
                DialogResult AC = MessageBox.Show(
                    "Are you sure you want to delete this student record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (AC == DialogResult.Yes)
                {
                    BEEDLIST.Items.Remove(BEEDLIST.SelectedItems[0]);

                    MessageBox.Show(
                        "Student record deleted successfully!",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }

        }

        private void BEEDLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BEEDLIST.SelectedItems.Count > 0)
            {
                ListViewItem item = BEEDLIST.SelectedItems[0];

                BEEDFN.Text = item.SubItems[0].Text;
                BEEDLN.Text = item.SubItems[1].Text;
                BEEDMN.Text = item.SubItems[2].Text;
                BEEDBD.Text = item.SubItems[3].Text;
                BEEDAGE.Text = item.SubItems[4].Text;
                BEEDGENDER.Text = item.SubItems[5].Text;
                BEEDADDRESS.Text = item.SubItems[6].Text;
                BEEDEMAIL.Text = item.SubItems[7].Text;
                BEEDCN.Text = item.SubItems[8].Text;
            }
        }

        private void BSED_Click(object sender, EventArgs e)
        {
            BSEDPAN.Show();
            BSITPAN.Hide();
            BEEDPAN.Hide();
            BSHMPAN.Hide();
            BSTMPAN.Hide();
            BSCPAN.Hide();
            BSNPAN.Hide();
            BSBAPAN.Hide();
            BPEPAN.Hide();
            BSGEPAN.Hide();
            BSNEDPAN.Hide();
            
        }

        private void BSEDNEW_Click(object sender, EventArgs e)
        {
            BSEDADD.Visible = true;
            BSEDNEW.Enabled = false;

            BSEDFN.Enabled = true;
            BSEDLN.Enabled = true;
            BSEDMN.Enabled = true;
            BSEDBD.Enabled = true;
            BSEDAGE.Enabled = true;
            BSEDGENDER.Enabled = true;
            BSEDADDRESS.Enabled = true;
            BSEDEMAIL.Enabled = true;
            BSEDCN.Enabled = true;

            BSEDFN.Visible = true;
            BSEDLN.Visible = true;
            BSEDMN.Visible = true;
            BSEDBD.Visible = true;
            BSEDAGE.Visible = true;
            BSEDGENDER.Visible = true;
            BSEDADDRESS.Visible = true;
            BSEDEMAIL.Visible = true;
            BSEDCN.Visible = true;
        }

        private void BSEDLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BSEDLIST.SelectedItems.Count > 0)
            {
                ListViewItem item = BSEDLIST.SelectedItems[0];

                BSEDFN.Text = item.SubItems[0].Text;
                BSEDLN.Text = item.SubItems[1].Text;
                BSEDMN.Text = item.SubItems[2].Text;
                BSEDBD.Text = item.SubItems[3].Text;
                BSEDAGE.Text = item.SubItems[4].Text;
                BSEDGENDER.Text = item.SubItems[5].Text;
                BSEDADDRESS.Text = item.SubItems[6].Text;
                BSEDEMAIL.Text = item.SubItems[7].Text;
                BSEDCN.Text = item.SubItems[8].Text;
            }
        }

        private void BSEDADD_Click(object sender, EventArgs e)
        {
            BSEDNEW.Enabled = false;

            ListViewItem AC = new ListViewItem(BSEDFN.Text);

            AC.SubItems.Add(BSEDLN.Text);
            AC.SubItems.Add(BSEDMN.Text);
            AC.SubItems.Add(BSEDBD.Text);
            AC.SubItems.Add(BSEDAGE.Text);
            AC.SubItems.Add(BSEDGENDER.Text);
            AC.SubItems.Add(BSEDADDRESS.Text);
            AC.SubItems.Add(BSEDEMAIL.Text);
            AC.SubItems.Add(BSEDCN.Text);

            BSEDLIST.Items.Add(AC);

            BSEDFN.Text = "";
            BSEDLN.Text = "";
            BSEDMN.Text = "";
            BSEDBD.Text = "";
            BSEDAGE.Text = "";
            BSEDGENDER.Text = "";
            BSEDADDRESS.Text = "";
            BSEDEMAIL.Text = "";
            BSEDCN.Text = "";

            BSEDFN.Enabled = true;
            BSEDLN.Enabled = true;
            BSEDMN.Enabled = true;
            BSEDBD.Enabled = true;
            BSEDAGE.Enabled = true;
            BSEDGENDER.Enabled = true;
            BSEDADDRESS.Enabled = true;
            BSEDEMAIL.Enabled = true;
            BSEDCN.Enabled = true;

            BSEDUPDATE.Visible = true;
            BSEDUPDATE.Enabled = true;
            BSEDDELETE.Visible = true;
            BSEDDELETE.Enabled = true;
        }

        private void BSEDUPDATE_Click(object sender, EventArgs e)
        {
            if (BSEDLIST.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = BSEDLIST.SelectedItems[0];

                selectedItem.SubItems[0].Text = BSEDFN.Text;
                selectedItem.SubItems[1].Text = BSEDLN.Text;
                selectedItem.SubItems[2].Text = BSEDMN.Text;
                selectedItem.SubItems[3].Text = BSEDBD.Text;
                selectedItem.SubItems[4].Text = BSEDAGE.Text;
                selectedItem.SubItems[5].Text = BSEDGENDER.Text;
                selectedItem.SubItems[6].Text = BSEDADDRESS.Text;
                selectedItem.SubItems[7].Text = BSEDEMAIL.Text;
                selectedItem.SubItems[8].Text = BSEDCN.Text;

                MessageBox.Show(
                    "Student record updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void BSEDDELETE_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                "Are you sure you want to delete this student record?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Student record deleted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            } if (BSITLIST.SelectedItems.Count > 0)
            {
                DialogResult AC = MessageBox.Show(
                    "Are you sure you want to delete this student record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (AC == DialogResult.Yes)
                {
                    BSEDLIST.Items.Remove(BSEDLIST.SelectedItems[0]);

                    MessageBox.Show(
                        "Student record deleted successfully!",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

        }

        private void BSEDPICTURE_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                BSEDPICTURE.Image = Image.FromFile(opf.FileName);
            }
        }

        private void BSHM_Click(object sender, EventArgs e)
        {
            BSHMPAN.Show();
            BSITPAN.Hide();
            BEEDPAN.Hide();
            BSEDPAN.Hide();
            BSTMPAN.Hide();
            BSCPAN.Hide();
            BSNPAN.Hide();
            BSBAPAN.Hide();
            BPEPAN.Hide();
            BSGEPAN.Hide();
            BSNEDPAN.Hide();
            
        }

        private void BSHMNEW_Click(object sender, EventArgs e)
        {
            BSHMADD.Visible = true;
            BSHMNEW.Enabled = false;

            BSHMFN.Enabled = true;
            BSHMLN.Enabled = true;
            BSHMMN.Enabled = true;
            BSHMBD.Enabled = true;
            BSHMAGE.Enabled = true;
            BSHMGENDER.Enabled = true;
            BSHMADDRESS.Enabled = true;
            BSHMEMAIL.Enabled = true;
            BSHMCN.Enabled = true;

            BSHMFN.Visible = true;
            BSHMLN.Visible = true;
            BSHMMN.Visible = true;
            BSHMBD.Visible = true;
            BSHMAGE.Visible = true;
            BSHMGENDER.Visible = true;
            BSHMADDRESS.Visible = true;
            BSHMEMAIL.Visible = true;
            BSHMCN.Visible = true;
        }

        private void BSHMADD_Click(object sender, EventArgs e)
        {
            BSHMNEW.Enabled = false;

            ListViewItem AC = new ListViewItem(BSHMFN.Text);

            AC.SubItems.Add(BSHMLN.Text);
            AC.SubItems.Add(BSHMMN.Text);
            AC.SubItems.Add(BSHMBD.Text);
            AC.SubItems.Add(BSHMAGE.Text);
            AC.SubItems.Add(BSHMGENDER.Text);
            AC.SubItems.Add(BSHMADDRESS.Text);
            AC.SubItems.Add(BSHMEMAIL.Text);
            AC.SubItems.Add(BSHMCN.Text);

            BSHMLIST.Items.Add(AC);

            BSHMFN.Text = "";
            BSHMLN.Text = "";
            BSHMMN.Text = "";
            BSHMBD.Text = "";
            BSHMAGE.Text = "";
            BSHMGENDER.Text = "";
            BSHMADDRESS.Text = "";
            BSHMEMAIL.Text = "";
            BSHMCN.Text = "";

            BSHMFN.Enabled = true;
            BSHMLN.Enabled = true;
            BSHMMN.Enabled = true;
            BSHMBD.Enabled = true;
            BSHMAGE.Enabled = true;
            BSHMGENDER.Enabled = true;
            BSHMADDRESS.Enabled = true;
            BSHMEMAIL.Enabled = true;
            BSHMCN.Enabled = true;

            BSHMUPDATE.Visible = true;
            BSHMUPDATE.Enabled = true;
            BSHMDELETE.Visible = true;
            BSHMDELETE.Enabled = true;

            
        }

        private void BSHMUPDATE_Click(object sender, EventArgs e)
        {
            if (BSHMLIST.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = BSHMLIST.SelectedItems[0];

                selectedItem.SubItems[0].Text = BSHMFN.Text;
                selectedItem.SubItems[1].Text = BSHMLN.Text;
                selectedItem.SubItems[2].Text = BSHMMN.Text;
                selectedItem.SubItems[3].Text = BSHMBD.Text;
                selectedItem.SubItems[4].Text = BSHMAGE.Text;
                selectedItem.SubItems[5].Text = BSHMGENDER.Text;
                selectedItem.SubItems[6].Text = BSHMADDRESS.Text;
                selectedItem.SubItems[7].Text = BSHMEMAIL.Text;
                selectedItem.SubItems[8].Text = BSHMCN.Text;

                MessageBox.Show(
                    "Student record updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BSHMDELETE_Click(object sender, EventArgs e)
        {
            if (BSHMLIST.SelectedItems.Count > 0)
            {
                DialogResult AC = MessageBox.Show(
                    "Are you sure you want to delete this student record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (AC == DialogResult.Yes)
                {
                    BSHMLIST.Items.Remove(BSHMLIST.SelectedItems[0]);

                    MessageBox.Show(
                        "Student record deleted successfully!",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BSHMPICTURE_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                BSHMPICTURE.Image = Image.FromFile(opf.FileName);
            }
        }

        private void BSHMLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BSHMLIST.SelectedItems.Count > 0)
            {
                ListViewItem item = BSHMLIST.SelectedItems[0];

                BSHMFN.Text = item.SubItems[0].Text;
                BSHMLN.Text = item.SubItems[1].Text;
                BSHMMN.Text = item.SubItems[2].Text;
                BSHMBD.Text = item.SubItems[3].Text;
                BSHMAGE.Text = item.SubItems[4].Text;
                BSHMGENDER.Text = item.SubItems[5].Text;
                BSHMADDRESS.Text = item.SubItems[6].Text;
                BSHMEMAIL.Text = item.SubItems[7].Text;
                BSHMCN.Text = item.SubItems[8].Text;
            }
           
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            LOGINFORM loginForm = new LOGINFORM();
            loginForm.Show();
            this.Hide();
        }

        private void BSTMNEW_Click(object sender, EventArgs e)
        {
            BSTMADD.Visible = true;
            BSTMNEW.Enabled = false;

            BSTMFN.Enabled = true;
            BSTMLN.Enabled = true;
            BSTMMN.Enabled = true;
            BSTMBD.Enabled = true;
            BSTMAGE.Enabled = true;
            BSTMGENDER.Enabled = true;
            BSTMADDRESS.Enabled = true;
            BSTMEMAIL.Enabled = true;
            BSTMCN.Enabled = true;

            BSTMFN.Visible = true;
            BSTMLN.Visible = true;
            BSTMMN.Visible = true;
            BSTMBD.Visible = true;
            BSTMAGE.Visible = true;
            BSTMGENDER.Visible = true;
            BSTMADDRESS.Visible = true;
            BSTMEMAIL.Visible = true;
            BSTMCN.Visible = true;
        }

        private void BSTMADD_Click(object sender, EventArgs e)
        {
            BSTMNEW.Enabled = false;

            ListViewItem AC = new ListViewItem(BSTMFN.Text);

            AC.SubItems.Add(BSTMFN.Text);
            AC.SubItems.Add(BSTMMN.Text);
            AC.SubItems.Add(BSTMBD.Text);
            AC.SubItems.Add(BSTMAGE.Text);
            AC.SubItems.Add(BSTMGENDER.Text);
            AC.SubItems.Add(BSTMADDRESS.Text);
            AC.SubItems.Add(BSTMEMAIL.Text);
            AC.SubItems.Add(BSTMCN.Text);

            BSTMLIST.Items.Add(AC);

            BSTMFN.Text = "";
            BSTMLN.Text = "";
            BSTMMN.Text = "";
            BSTMBD.Text = "";
            BSTMAGE.Text = "";
            BSTMGENDER.Text = "";
            BSTMADDRESS.Text = "";
            BSTMEMAIL.Text = "";
            BSTMCN.Text = "";

            BSTMFN.Enabled = true;
            BSTMLN.Enabled = true;
            BSTMMN.Enabled = true;
            BSTMBD.Enabled = true;
            BSTMAGE.Enabled = true;
            BSTMGENDER.Enabled = true;
            BSTMADDRESS.Enabled = true;
            BSTMEMAIL.Enabled = true;
            BSTMCN.Enabled = true;

            BSTMUPDATE.Visible = true;
            BSTMUPDATE.Enabled = true;
            BSTMDELETE.Visible = true;
            BSTMDELETE.Enabled = true;
        }

        private void BSTMUPDATE_Click(object sender, EventArgs e)
        {
            if (BSTMLIST.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = BSTMLIST.SelectedItems[0];

                selectedItem.SubItems[0].Text = BSTMFN.Text;
                selectedItem.SubItems[1].Text = BSTMLN.Text;
                selectedItem.SubItems[2].Text = BSTMMN.Text;
                selectedItem.SubItems[3].Text = BSTMBD.Text;
                selectedItem.SubItems[4].Text = BSTMAGE.Text;
                selectedItem.SubItems[5].Text = BSTMGENDER.Text;
                selectedItem.SubItems[6].Text = BSTMADDRESS.Text;
                selectedItem.SubItems[7].Text = BSTMEMAIL.Text;
                selectedItem.SubItems[8].Text = BSTMCN.Text;

                MessageBox.Show(
                    "Student record updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BSTMDELETE_Click(object sender, EventArgs e)
        {
            if (BSTMLIST.SelectedItems.Count > 0)
            {
                DialogResult AC = MessageBox.Show(
                    "Are you sure you want to delete this student record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (AC == DialogResult.Yes)
                {
                    BSTMLIST.Items.Remove(BSTMLIST.SelectedItems[0]);

                    MessageBox.Show(
                        "Student record deleted successfully!",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BSTMPICTURE_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                BSTMPICTURE.Image = Image.FromFile(opf.FileName);
            }
        }

        private void BSTM_Click_1(object sender, EventArgs e)
        {
            BSTMPAN.Show();
            BSITPAN.Hide();
            BEEDPAN.Hide();
            BSEDPAN.Hide();
            BSHMPAN.Hide();
            BSCPAN.Hide();
            BSNPAN.Hide();
            BSBAPAN.Hide();
            BPEPAN.Hide();
            BSGEPAN.Hide();
            BSNEDPAN.Hide();
        }

        private void BSC_Click(object sender, EventArgs e)
        {
            BSCPAN.Show();
            BSITPAN.Hide();
            BEEDPAN.Hide();
            BSEDPAN.Hide();
            BSHMPAN.Hide();
            BSTMPAN.Hide();
            BSNPAN.Hide();
            BSBAPAN.Hide();
            BPEPAN.Hide();
            BSGEPAN.Hide();
            BSNEDPAN.Hide();
        }

        private void BSCNEW_Click(object sender, EventArgs e)
        {
            BSCADD.Visible = true;
            BSCNEW.Enabled = false;

            BSCFN.Enabled = true;
            BSCLN.Enabled = true;
            BSCMN.Enabled = true;
            BSCBD.Enabled = true;
            BSCAGE.Enabled = true;
            BSCGENDER.Enabled = true;
            BSCADDRESS.Enabled = true;
            BSCEMAIL.Enabled = true;
            BSCCN.Enabled = true;

            BSCFN.Visible = true;
            BSCLN.Visible = true;
            BSCMN.Visible = true;
            BSCBD.Visible = true;
            BSCAGE.Visible = true;
            BSCGENDER.Visible = true;
            BSCADDRESS.Visible = true;
            BSCEMAIL.Visible = true;
            BSCCN.Visible = true;
        }

        private void BSCADD_Click(object sender, EventArgs e)
        {
            BSCNEW.Enabled = false;

            ListViewItem AC = new ListViewItem(BSCFN.Text);

            AC.SubItems.Add(BSCFN.Text);
            AC.SubItems.Add(BSCMN.Text);
            AC.SubItems.Add(BSCBD.Text);
            AC.SubItems.Add(BSCAGE.Text);
            AC.SubItems.Add(BSCGENDER.Text);
            AC.SubItems.Add(BSCADDRESS.Text);
            AC.SubItems.Add(BSCEMAIL.Text);
            AC.SubItems.Add(BSCCN.Text);

            BSCLIST.Items.Add(AC);

            BSCFN.Text = "";
            BSCLN.Text = "";
            BSCMN.Text = "";
            BSCBD.Text = "";
            BSCAGE.Text = "";
            BSCGENDER.Text = "";
            BSCADDRESS.Text = "";
            BSCEMAIL.Text = "";
            BSCCN.Text = "";

            BSCFN.Enabled = true;
            BSCLN.Enabled = true;
            BSCMN.Enabled = true;
            BSCBD.Enabled = true;
            BSCAGE.Enabled = true;
            BSCGENDER.Enabled = true;
            BSCADDRESS.Enabled = true;
            BSCEMAIL.Enabled = true;
            BSCCN.Enabled = true;

            BSCUPDATE.Visible = true;
            BSCUPDATE.Enabled = true;
            BSCDELETE.Visible = true;
            BSCDELETE.Enabled = true;
        }

        private void BSCUPDATE_Click(object sender, EventArgs e)
        {
            if (BSCLIST.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = BSCLIST.SelectedItems[0];

                selectedItem.SubItems[0].Text = BSCFN.Text;
                selectedItem.SubItems[1].Text = BSCLN.Text;
                selectedItem.SubItems[2].Text = BSCMN.Text;
                selectedItem.SubItems[3].Text = BSCBD.Text;
                selectedItem.SubItems[4].Text = BSCAGE.Text;
                selectedItem.SubItems[5].Text = BSCGENDER.Text;
                selectedItem.SubItems[6].Text = BSCADDRESS.Text;
                selectedItem.SubItems[7].Text = BSCEMAIL.Text;
                selectedItem.SubItems[8].Text = BSCCN.Text;

                MessageBox.Show(
                    "Student record updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BSCDELETE_Click(object sender, EventArgs e)
        {
            if (BSCLIST.SelectedItems.Count > 0)
            {
                DialogResult AC = MessageBox.Show(
                    "Are you sure you want to delete this student record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (AC == DialogResult.Yes)
                {
                    BSCLIST.Items.Remove(BSCLIST.SelectedItems[0]);

                    MessageBox.Show(
                        "Student record deleted successfully!",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BSCPICTURE_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                BSCPICTURE.Image = Image.FromFile(opf.FileName);
            }
        }

        private void BSTMLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BSTMLIST.SelectedItems.Count > 0)
            {
                ListViewItem item = BSTMLIST.SelectedItems[0];

                BSTMFN.Text = item.SubItems[0].Text;
                BSTMLN.Text = item.SubItems[1].Text;
                BSTMMN.Text = item.SubItems[2].Text;
                BSTMBD.Text = item.SubItems[3].Text;
                BSTMAGE.Text = item.SubItems[4].Text;
                BSTMGENDER.Text = item.SubItems[5].Text;
                BSTMADDRESS.Text = item.SubItems[6].Text;
                BSTMEMAIL.Text = item.SubItems[7].Text;
                BSTMCN.Text = item.SubItems[8].Text;
            }
        }

        private void BSN_Click(object sender, EventArgs e)
        {
            BSNPAN.Show();
            BSITPAN.Hide();
            BEEDPAN.Hide();
            BSEDPAN.Hide();
            BSHMPAN.Hide();
            BSTMPAN.Hide();
            BSCPAN.Hide();
            BSBAPAN.Hide();
            BPEPAN.Hide();
            BSGEPAN.Hide();
            BSNEDPAN.Hide();
        }

        private void BSNPICTURE_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                BSNPICTURE.Image = Image.FromFile(opf.FileName);
            }
        }

        private void BSNLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BSNLIST.SelectedItems.Count > 0)
            {
                ListViewItem item = BSNLIST.SelectedItems[0];

                BSNFN.Text = item.SubItems[0].Text;
                BSNLN.Text = item.SubItems[1].Text;
                BSNMN.Text = item.SubItems[2].Text;
                BSNBD.Text = item.SubItems[3].Text;
                BSNAGE.Text = item.SubItems[4].Text;
                BSNGENDER.Text = item.SubItems[5].Text;
                BSNADDRESS.Text = item.SubItems[6].Text;
                BSNEMAIL.Text = item.SubItems[7].Text;
                BSNCN.Text = item.SubItems[8].Text;
            }
        }

        private void BSCLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BSCLIST.SelectedItems.Count > 0)
            {
                ListViewItem item = BSCLIST.SelectedItems[0];

                BSCFN.Text = item.SubItems[0].Text;
                BSCLN.Text = item.SubItems[1].Text;
                BSCMN.Text = item.SubItems[2].Text;
                BSCBD.Text = item.SubItems[3].Text;
                BSCAGE.Text = item.SubItems[4].Text;
                BSCGENDER.Text = item.SubItems[5].Text;
                BSCADDRESS.Text = item.SubItems[6].Text;
                BSCEMAIL.Text = item.SubItems[7].Text;
                BSCCN.Text = item.SubItems[8].Text;
            }
        }

        private void BSNNEW_Click(object sender, EventArgs e)
        {
            BSNADD.Visible = true;
            BSNNEW.Enabled = false;

            BSNFN.Enabled = true;
            BSNLN.Enabled = true;
            BSNMN.Enabled = true;
            BSNBD.Enabled = true;
            BSNAGE.Enabled = true;
            BSNGENDER.Enabled = true;
            BSNADDRESS.Enabled = true;
            BSNEMAIL.Enabled = true;
            BSNCN.Enabled = true;

            BSNFN.Visible = true;
            BSNLN.Visible = true;
            BSNMN.Visible = true;
            BSNBD.Visible = true;
            BSNAGE.Visible = true;
            BSNGENDER.Visible = true;
            BSNADDRESS.Visible = true;
            BSNEMAIL.Visible = true;
            BSNCN.Visible = true;
        }

        private void BSNADD_Click(object sender, EventArgs e)
        {
            BSNNEW.Enabled = false;

            ListViewItem AC = new ListViewItem(BSNFN.Text);

            AC.SubItems.Add(BSNFN.Text);
            AC.SubItems.Add(BSNMN.Text);
            AC.SubItems.Add(BSNBD.Text);
            AC.SubItems.Add(BSNAGE.Text);
            AC.SubItems.Add(BSNGENDER.Text);
            AC.SubItems.Add(BSNADDRESS.Text);
            AC.SubItems.Add(BSNEMAIL.Text);
            AC.SubItems.Add(BSNCN.Text);

            BSNLIST.Items.Add(AC);

            BSNFN.Text = "";
            BSNLN.Text = "";
            BSNMN.Text = "";
            BSNBD.Text = "";
            BSNAGE.Text = "";
            BSNGENDER.Text = "";
            BSNADDRESS.Text = "";
            BSNEMAIL.Text = "";
            BSNCN.Text = "";

            BSNFN.Enabled = true;
            BSNLN.Enabled = true;
            BSNMN.Enabled = true;
            BSNBD.Enabled = true;
            BSNAGE.Enabled = true;
            BSNGENDER.Enabled = true;
            BSNADDRESS.Enabled = true;
            BSNEMAIL.Enabled = true;
            BSNCN.Enabled = true;

            BSNUPDATE.Visible = true;
            BSNUPDATE.Enabled = true;
            BSNDELETE.Visible = true;
            BSNDELETE.Enabled = true;
        }

        private void BSNUPDATE_Click(object sender, EventArgs e)
        {
            if (BSNLIST.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = BSNLIST.SelectedItems[0];

                selectedItem.SubItems[0].Text = BSNFN.Text;
                selectedItem.SubItems[1].Text = BSNLN.Text;
                selectedItem.SubItems[2].Text = BSNMN.Text;
                selectedItem.SubItems[3].Text = BSNBD.Text;
                selectedItem.SubItems[4].Text = BSNAGE.Text;
                selectedItem.SubItems[5].Text = BSNGENDER.Text;
                selectedItem.SubItems[6].Text = BSNADDRESS.Text;
                selectedItem.SubItems[7].Text = BSNEMAIL.Text;
                selectedItem.SubItems[8].Text = BSNCN.Text;

                MessageBox.Show(
                    "Student record updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BSNDELETE_Click(object sender, EventArgs e)
        {
            if (BSNLIST.SelectedItems.Count > 0)
            {
                DialogResult AC = MessageBox.Show(
                    "Are you sure you want to delete this student record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (AC == DialogResult.Yes)
                {
                    BSNLIST.Items.Remove(BSNLIST.SelectedItems[0]);

                    MessageBox.Show(
                        "Student record deleted successfully!",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BSBA_Click(object sender, EventArgs e)
        {
            BSBAPAN.Show();
            BSITPAN.Hide();
            BEEDPAN.Hide();
            BSEDPAN.Hide();
            BSHMPAN.Hide();
            BSTMPAN.Hide();
            BSCPAN.Hide();
            BSNPAN.Hide();
            BPEPAN.Hide();
            BSGEPAN.Hide();
            BSNEDPAN.Hide();
        }

        private void BSBALIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BSBALIST.SelectedItems.Count > 0)
            {
                ListViewItem item = BSBALIST.SelectedItems[0];

                BSBAFN.Text = item.SubItems[0].Text;
                BSBALN.Text = item.SubItems[1].Text;
                BSBAMN.Text = item.SubItems[2].Text;
                BSBABD.Text = item.SubItems[3].Text;
                BSBAAGE.Text = item.SubItems[4].Text;
                BSBAGENDER.Text = item.SubItems[5].Text;
                BSBAADDRESS.Text = item.SubItems[6].Text;
                BSBAEMAIL.Text = item.SubItems[7].Text;
                BSBACN.Text = item.SubItems[8].Text;
            }
        }

        private void BSBAPICTURE_Click(object sender, EventArgs e)
        {
                OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                BSNPICTURE.Image = Image.FromFile(opf.FileName);
            }
        }

        private void BSBANEW_Click(object sender, EventArgs e)
        {
            BSBAADD.Visible = true;
            BSBANEW.Enabled = false;

            BSBAFN.Enabled = true;
            BSBALN.Enabled = true;
            BSBAMN.Enabled = true;
            BSBABD.Enabled = true;
            BSBAAGE.Enabled = true;
            BSBAGENDER.Enabled = true;
            BSBAADDRESS.Enabled = true;
            BSBAEMAIL.Enabled = true;
            BSBACN.Enabled = true;

            BSBAFN.Visible = true;
            BSBALN.Visible = true;
            BSBAMN.Visible = true;
            BSBABD.Visible = true;
            BSBAAGE.Visible = true;
            BSBAGENDER.Visible = true;
            BSBAADDRESS.Visible = true;
            BSBAEMAIL.Visible = true;
            BSBACN.Visible = true;
        }

        private void BSBAADD_Click(object sender, EventArgs e)
        {
            BSBANEW.Enabled = false;

            ListViewItem AC = new ListViewItem(BSBAFN.Text);

            AC.SubItems.Add(BSBAFN.Text);
            AC.SubItems.Add(BSBAMN.Text);
            AC.SubItems.Add(BSBABD.Text);
            AC.SubItems.Add(BSBAAGE.Text);
            AC.SubItems.Add(BSBAGENDER.Text);
            AC.SubItems.Add(BSBAADDRESS.Text);
            AC.SubItems.Add(BSBAEMAIL.Text);
            AC.SubItems.Add(BSBACN.Text);

            BSBALIST.Items.Add(AC);

            BSBAFN.Text = "";
            BSBALN.Text = "";
            BSBAMN.Text = "";
            BSBABD.Text = "";
            BSBAAGE.Text = "";
            BSBAGENDER.Text = "";
            BSBAADDRESS.Text = "";
            BSBAEMAIL.Text = "";
            BSBACN.Text = "";

            BSBAFN.Enabled = true;
            BSBALN.Enabled = true;
            BSBAMN.Enabled = true;
            BSBABD.Enabled = true;
            BSBAAGE.Enabled = true;
            BSBAGENDER.Enabled = true;
            BSBAADDRESS.Enabled = true;
            BSBAEMAIL.Enabled = true;
            BSBACN.Enabled = true;

            BSBAUPDATE.Visible = true;
            BSBAUPDATE.Enabled = true;
            BSBADELETE.Visible = true;
            BSBADELETE.Enabled = true;
        }

        private void BSBAUPDATE_Click(object sender, EventArgs e)
        {
            if (BSBALIST.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = BSBALIST.SelectedItems[0];

                selectedItem.SubItems[0].Text = BSBAFN.Text;
                selectedItem.SubItems[1].Text = BSBALN.Text;
                selectedItem.SubItems[2].Text = BSBAMN.Text;
                selectedItem.SubItems[3].Text = BSBABD.Text;
                selectedItem.SubItems[4].Text = BSBAAGE.Text;
                selectedItem.SubItems[5].Text = BSBAGENDER.Text;
                selectedItem.SubItems[6].Text = BSBAADDRESS.Text;
                selectedItem.SubItems[7].Text = BSBAEMAIL.Text;
                selectedItem.SubItems[8].Text = BSBACN.Text;

                MessageBox.Show(
                    "Student record updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BSBADELETE_Click(object sender, EventArgs e)
        {
            if (BSBALIST.SelectedItems.Count > 0)
            {
                DialogResult AC = MessageBox.Show(
                    "Are you sure you want to delete this student record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (AC == DialogResult.Yes)
                {
                    BSBALIST.Items.Remove(BSBALIST.SelectedItems[0]);

                    MessageBox.Show(
                        "Student record deleted successfully!",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BPE_Click(object sender, EventArgs e)
        {
            BPEPAN.Show();
            BSITPAN.Hide();
            BEEDPAN.Hide();
            BSEDPAN.Hide();
            BSHMPAN.Hide();
            BSTMPAN.Hide();
            BSCPAN.Hide();
            BSNPAN.Hide();
            BSBAPAN.Hide();
            BSGEPAN.Hide();
            BSNEDPAN.Hide();
        }

        private void BPEPICTURE_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                BSNPICTURE.Image = Image.FromFile(opf.FileName);
            }
        }

        private void BPENEW_Click(object sender, EventArgs e)
        {
            BPEADD.Visible = true;
            BPENEW.Enabled = false;

            BPEFN.Enabled = true;
            BPELN.Enabled = true;
            BPEMN.Enabled = true;
            BPEBD.Enabled = true;
            BPEAGE.Enabled = true;
            BPEGENDER.Enabled = true;
            BPEADDRESS.Enabled = true;
            BPEEMAIL.Enabled = true;
            BPECN.Enabled = true;

            BPEFN.Visible = true;
            BPELN.Visible = true;
            BPEMN.Visible = true;
            BPEBD.Visible = true;
            BPEAGE.Visible = true;
            BPEGENDER.Visible = true;
            BPEADDRESS.Visible = true;
            BPEEMAIL.Visible = true;
            BPECN.Visible = true;
        }

        private void BPEADD_Click(object sender, EventArgs e)
        {
            BPENEW.Enabled = false;

            ListViewItem AC = new ListViewItem(BPEFN.Text);

            AC.SubItems.Add(BPEFN.Text);
            AC.SubItems.Add(BPEMN.Text);
            AC.SubItems.Add(BPEBD.Text);
            AC.SubItems.Add(BPEAGE.Text);
            AC.SubItems.Add(BPEGENDER.Text);
            AC.SubItems.Add(BPEADDRESS.Text);
            AC.SubItems.Add(BPEEMAIL.Text);
            AC.SubItems.Add(BPECN.Text);

            BPELIST.Items.Add(AC);

            BPEFN.Text = "";
            BPELN.Text = "";
            BPEMN.Text = "";
            BPEBD.Text = "";
            BPEAGE.Text = "";
            BPEGENDER.Text = "";
            BPEADDRESS.Text = "";
            BPEEMAIL.Text = "";
            BPECN.Text = "";

            BPEFN.Enabled = true;
            BPELN.Enabled = true;
            BPEMN.Enabled = true;
            BPEBD.Enabled = true;
            BPEAGE.Enabled = true;
            BPEGENDER.Enabled = true;
            BPEADDRESS.Enabled = true;
            BPEEMAIL.Enabled = true;
            BPECN.Enabled = true;

            BPEUPDATE.Visible = true;
            BPEUPDATE.Enabled = true;
            BPEDELETE.Visible = true;
            BPEDELETE.Enabled = true;
        }

        private void BPEUPDATE_Click(object sender, EventArgs e)
        {
            if (BPELIST.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = BPELIST.SelectedItems[0];

                selectedItem.SubItems[0].Text = BPEFN.Text;
                selectedItem.SubItems[1].Text = BPELN.Text;
                selectedItem.SubItems[2].Text = BPEMN.Text;
                selectedItem.SubItems[3].Text = BPEBD.Text;
                selectedItem.SubItems[4].Text = BPEAGE.Text;
                selectedItem.SubItems[5].Text = BPEGENDER.Text;
                selectedItem.SubItems[6].Text = BPEADDRESS.Text;
                selectedItem.SubItems[7].Text = BPEEMAIL.Text;
                selectedItem.SubItems[8].Text = BPECN.Text;

                MessageBox.Show(
                    "Student record updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BPEDELETE_Click(object sender, EventArgs e)
        {
            if (BPELIST.SelectedItems.Count > 0)
            {
                DialogResult AC = MessageBox.Show(
                    "Are you sure you want to delete this student record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (AC == DialogResult.Yes)
                {
                    BPELIST.Items.Remove(BPELIST.SelectedItems[0]);

                    MessageBox.Show(
                        "Student record deleted successfully!",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BPELIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BPELIST.SelectedItems.Count > 0)
            {
                ListViewItem item = BPELIST.SelectedItems[0];

                BPEFN.Text = item.SubItems[0].Text;
                BPELN.Text = item.SubItems[1].Text;
                BPEMN.Text = item.SubItems[2].Text;
                BPEBD.Text = item.SubItems[3].Text;
                BPEAGE.Text = item.SubItems[4].Text;
                BPEGENDER.Text = item.SubItems[5].Text;
                BPEADDRESS.Text = item.SubItems[6].Text;
                BPEEMAIL.Text = item.SubItems[7].Text;
                BPECN.Text = item.SubItems[8].Text;
            }
        }

        private void BSNED_Click(object sender, EventArgs e)
        {
            BSNEDPAN.Show();
            BSITPAN.Hide();
            BEEDPAN.Hide();
            BSEDPAN.Hide();
            BSHMPAN.Hide();
            BSTMPAN.Hide();
            BSCPAN.Hide();
            BSNPAN.Hide();
            BSBAPAN.Hide();
            BPEPAN.Hide();
            BSGEPAN.Hide();
        }

        private void BSNEDPICTURE_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                BSNEDPICTURE.Image = Image.FromFile(opf.FileName);
            }
        }

        private void BSNEDLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BSNEDLIST.SelectedItems.Count > 0)
            {
                ListViewItem item = BSNEDLIST.SelectedItems[0];

                BSNEDFN.Text = item.SubItems[0].Text;
                BSNEDLN.Text = item.SubItems[1].Text;
                BSNEDMN.Text = item.SubItems[2].Text;
                BSNEDBD.Text = item.SubItems[3].Text;
                BSNEDAGE.Text = item.SubItems[4].Text;
                BSNEDGENDER.Text = item.SubItems[5].Text;
                BSNEDADDRESS.Text = item.SubItems[6].Text;
                BSNEDEMAIL.Text = item.SubItems[7].Text;
                BSNEDCN.Text = item.SubItems[8].Text;
            }
        }

        private void BSNEDNEW_Click(object sender, EventArgs e)
        {
            BSNEDADD.Visible = true;
            BSNEDNEW.Enabled = false;

            BSNEDFN.Enabled = true;
            BSNEDLN.Enabled = true;
            BSNEDMN.Enabled = true;
            BSNEDBD.Enabled = true;
            BSNEDAGE.Enabled = true;
            BSNEDGENDER.Enabled = true;
            BSNEDADDRESS.Enabled = true;
            BSNEDEMAIL.Enabled = true;
            BSNEDCN.Enabled = true;

            BSNEDFN.Visible = true;
            BSNEDLN.Visible = true;
            BSNEDMN.Visible = true;
            BSNEDBD.Visible = true;
            BSNEDAGE.Visible = true;
            BSNEDGENDER.Visible = true;
            BSNEDADDRESS.Visible = true;
            BSNEDEMAIL.Visible = true;
            BSNEDCN.Visible = true;
        }

        private void BSNEDADD_Click(object sender, EventArgs e)
        {
            BSNEDNEW.Enabled = false;

            ListViewItem AC = new ListViewItem(BSNEDFN.Text);

            AC.SubItems.Add(BSNEDFN.Text);
            AC.SubItems.Add(BSNEDMN.Text);
            AC.SubItems.Add(BSNEDBD.Text);
            AC.SubItems.Add(BSNEDAGE.Text);
            AC.SubItems.Add(BSNEDGENDER.Text);
            AC.SubItems.Add(BSNEDADDRESS.Text);
            AC.SubItems.Add(BSNEDEMAIL.Text);
            AC.SubItems.Add(BSNEDCN.Text);

            BSNEDLIST.Items.Add(AC);

            BSNEDFN.Text = "";
            BSNEDLN.Text = "";
            BSNEDMN.Text = "";
            BSNEDBD.Text = "";
            BSNEDAGE.Text = "";
            BSNEDGENDER.Text = "";
            BSNEDADDRESS.Text = "";
            BSNEDEMAIL.Text = "";
            BSNEDCN.Text = "";

            BSNEDFN.Enabled = true;
            BSNEDLN.Enabled = true;
            BSNEDMN.Enabled = true;
            BSNEDBD.Enabled = true;
            BSNEDAGE.Enabled = true;
            BSNEDGENDER.Enabled = true;
            BSNEDADDRESS.Enabled = true;
            BSNEDEMAIL.Enabled = true;
            BSNEDCN.Enabled = true;

            BSNEDUPDATE.Visible = true;
            BSNEDUPDATE.Enabled = true;
            BSNEDDELETE.Visible = true;
            BSNEDDELETE.Enabled = true;
        }

        private void BSNEDUPDATE_Click(object sender, EventArgs e)
        {
            if (BSNEDLIST.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = BSNEDLIST.SelectedItems[0];

                selectedItem.SubItems[0].Text = BSNEDFN.Text;
                selectedItem.SubItems[1].Text = BSNEDLN.Text;
                selectedItem.SubItems[2].Text = BSNEDMN.Text;
                selectedItem.SubItems[3].Text = BSNEDBD.Text;
                selectedItem.SubItems[4].Text = BSNEDAGE.Text;
                selectedItem.SubItems[5].Text = BSNEDGENDER.Text;
                selectedItem.SubItems[6].Text = BSNEDADDRESS.Text;
                selectedItem.SubItems[7].Text = BSNEDEMAIL.Text;
                selectedItem.SubItems[8].Text = BSNEDCN.Text;

                MessageBox.Show(
                    "Student record updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BSNEDDELETE_Click(object sender, EventArgs e)
        {
            if (BSNEDLIST.SelectedItems.Count > 0)
            {
                DialogResult AC = MessageBox.Show(
                    "Are you sure you want to delete this student record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (AC == DialogResult.Yes)
                {
                    BSNEDLIST.Items.Remove(BSNEDLIST.SelectedItems[0]);

                    MessageBox.Show(
                        "Student record deleted successfully!",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BSGE_Click(object sender, EventArgs e)
        {
            BSGEPAN.Show();
            BSITPAN.Hide();
            BEEDPAN.Hide();
            BSEDPAN.Hide();
            BSHMPAN.Hide();
            BSTMPAN.Hide();
            BSCPAN.Hide();
            BSNPAN.Hide();
            BSBAPAN.Hide();
            BPEPAN.Hide();
            BSNEDPAN.Hide();
        }

        private void BSGEPICTURE_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                BSNEDPICTURE.Image = Image.FromFile(opf.FileName);
            }
        }

        private void BSGELIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BSGELIST.SelectedItems.Count > 0)
            {
                ListViewItem item = BSGELIST.SelectedItems[0];

                BSGEFN.Text = item.SubItems[0].Text;
                BSGELN.Text = item.SubItems[1].Text;
                BSGEMN.Text = item.SubItems[2].Text;
                BSGEBD.Text = item.SubItems[3].Text;
                BSGEAGE.Text = item.SubItems[4].Text;
                BSGEGENDER.Text = item.SubItems[5].Text;
                BSGEADDRESS.Text = item.SubItems[6].Text;
                BSGEEMAIL.Text = item.SubItems[7].Text;
                BSGECN.Text = item.SubItems[8].Text;
            }
        }

        private void BSGENEW_Click(object sender, EventArgs e)
        {
            BSGEADD.Visible = true;
            BSGENEW.Enabled = false;

            BSGEFN.Enabled = true;
            BSGELN.Enabled = true;
            BSGEMN.Enabled = true;
            BSGEBD.Enabled = true;
            BSGEAGE.Enabled = true;
            BSGEGENDER.Enabled = true;
            BSGEADDRESS.Enabled = true;
            BSGEEMAIL.Enabled = true;
            BSGECN.Enabled = true;

            BSGEFN.Visible = true;
            BSGELN.Visible = true;
            BSGEMN.Visible = true;
            BSGEBD.Visible = true;
            BSGEAGE.Visible = true;
            BSGEGENDER.Visible = true;
            BSGEADDRESS.Visible = true;
            BSGEEMAIL.Visible = true;
            BSGECN.Visible = true;
        }

        private void BSGEADD_Click(object sender, EventArgs e)
        {
            BSGENEW.Enabled = false;

            ListViewItem AC = new ListViewItem(BSGEFN.Text);

            AC.SubItems.Add(BSGEFN.Text);
            AC.SubItems.Add(BSGEMN.Text);
            AC.SubItems.Add(BSGEBD.Text);
            AC.SubItems.Add(BSGEAGE.Text);
            AC.SubItems.Add(BSGEGENDER.Text);
            AC.SubItems.Add(BSGEADDRESS.Text);
            AC.SubItems.Add(BSGEEMAIL.Text);
            AC.SubItems.Add(BSGECN.Text);

            BSGELIST.Items.Add(AC);

            BSGEFN.Text = "";
            BSGELN.Text = "";
            BSGEMN.Text = "";
            BSGEBD.Text = "";
            BSGEAGE.Text = "";
            BSGEGENDER.Text = "";
            BSGEADDRESS.Text = "";
            BSGEEMAIL.Text = "";
            BSGECN.Text = "";

            BSGEFN.Enabled = true;
            BSGELN.Enabled = true;
            BSGEMN.Enabled = true;
            BSGEBD.Enabled = true;
            BSGEAGE.Enabled = true;
            BSGEGENDER.Enabled = true;
            BSGEADDRESS.Enabled = true;
            BSGEEMAIL.Enabled = true;
            BSGECN.Enabled = true;

            BSGEUPDATE.Visible = true;
            BSGEUPDATE.Enabled = true;
            BSGEDELETE.Visible = true;
            BSGEDELETE.Enabled = true;
        }

        private void BSGEUPDATE_Click(object sender, EventArgs e)
        {
            if (BSGELIST.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = BSGELIST.SelectedItems[0];

                selectedItem.SubItems[0].Text = BSGEFN.Text;
                selectedItem.SubItems[1].Text = BSGELN.Text;
                selectedItem.SubItems[2].Text = BSGEMN.Text;
                selectedItem.SubItems[3].Text = BSGEBD.Text;
                selectedItem.SubItems[4].Text = BSGEAGE.Text;
                selectedItem.SubItems[5].Text = BSGEGENDER.Text;
                selectedItem.SubItems[6].Text = BSGEADDRESS.Text;
                selectedItem.SubItems[7].Text = BSGEEMAIL.Text;
                selectedItem.SubItems[8].Text = BSGECN.Text;

                MessageBox.Show(
                    "Student record updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BSGEDELETE_Click(object sender, EventArgs e)
        {
            if (BSGELIST.SelectedItems.Count > 0)
            {
                DialogResult AC = MessageBox.Show(
                    "Are you sure you want to delete this student record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (AC == DialogResult.Yes)
                {
                    BSGELIST.Items.Remove(BSGELIST.SelectedItems[0]);

                    MessageBox.Show(
                        "Student record deleted successfully!",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a student record first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    
    }
}