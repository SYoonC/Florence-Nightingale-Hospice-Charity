using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace WindowsFormsApp7
{
    public partial class Assign : Form
    {
        public string VolID, RoleID;
        public Assign()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            //ID ROLEID
            item.Text = id.Text;
            item.Text = roleid.Text;
           
            listView2.Items.Add(item);

            string message = " Thank you ! ";
            MessageBox.Show(message);
            id.Text = string.Empty;
            roleid.Text = string.Empty;

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView2.SelectedItems[0];
            //ID ROLEID
            id.Text = item.SubItems[0].Text;
            roleid.Text = item.SubItems[1].Text;
            
            string message = " Assign Updated ";
            MessageBox.Show(message);
            id.Text = string.Empty;
            roleid.Text = string.Empty;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to clear all the fields ? \n\nClick 'Yes' to CLEAR \nClick 'No' NOT to clear", "Close", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                id.Text = string.Empty;
                roleid.Text = string.Empty;
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("Do you want to delete this assign ? \n\nClick 'Yes' to DELETE \nClick 'No' NOT to delete", "Close", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                listView2.SelectedItems[0].Remove();
            }

            id.Text = string.Empty;
            roleid.Text = string.Empty;

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView2.SelectedItems[0];
            //ID ROLEID
            id.Text = item.SubItems[0].Text;
            roleid.Text = item.SubItems[1].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close this ? \n\nClick 'Yes' to CLOSE \nClick 'No' NOT to close","Close",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Roles rolefrm = new Roles();
            rolefrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage manfrm = new Manage();
            manfrm.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assign form1 = new Assign();
            form1.ShowDialog();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            bitmap.Save("ScreenShot.jpeg", ImageFormat.Jpeg);
            MessageBox.Show(" The screenshot is saved in Debug folder. ");
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colour colour = new Colour();
            colour.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assign form1 = new Assign();
            form1.ShowDialog();
            this.Close();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage : Here you can manage volunteers e.g. View, Add, Edit, Delete" +
    "\n\nRoles : Here you can manage jobs e.g. View, Add, Edit, Delete" +
    "\n\nAssign : Here you can assign a volunteer with a job and track the records." +
    "\nEach field value will be automatically filled from the last Roles and Assign page.");

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All rights reserved." +
    "\n\nNo part of this program may be reproduced or used in any manner without written permission of" +
    "the copyright owner, Yoon Cho and the lecturer, Tuan Nguyen." +
    "\n\nAdditional material aid will enhance a chance of getting a permission.");

        }

        private void Assign_Load(object sender, EventArgs e)
        {
            id.Text = this.VolID;
            roleid.Text = this.RoleID;

        }
    }
}
