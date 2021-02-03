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
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void roleid_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeadd_Click(object sender, EventArgs e)
        {
            string newPlace = place.Text;
            placecombo.Items.Add(newPlace);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("Do you want to delete this role ? \n\nClick 'Yes' to DELETE \nClick 'No' NOT to delete", "Close", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                listView2.SelectedItems[0].Remove();
            }
            roleid.Text = string.Empty;
            date.Text = string.Empty;
            postcode.Text = string.Empty;
            title.Text = string.Empty;
            note.Text = string.Empty;

            date.Value = DateTime.Now;
            time.Value = DateTime.Now;

            yes.Checked = false;
            no.Checked = false;
            backno.Checked = false;
            required.Checked = false;


        }

        private void add_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            //ID DATE POSTCODE TRAINING
            item.Text = roleid.Text;
            item.SubItems.Add(date.Text);
            item.SubItems.Add(postcode.Text);
            item.SubItems.Add(yes.Checked.ToString());

            //rest to be stored for future reference
            //TITLE BACKGROUND TIME PLACE NOTE
            item.SubItems.Add(title.Text);
            item.SubItems.Add(backno.Text);
            item.SubItems.Add(time.Value.ToString());
            item.SubItems.Add(placecombo.SelectedItem.ToString());
            item.SubItems.Add(note.Text);


            listView2.Items.Add(item);


            string message = title.Text + " is now added. New volunteer work ! ";
            MessageBox.Show(message);

            roleid.Text = string.Empty;
            date.Text = string.Empty;
            postcode.Text = string.Empty;
            title.Text = string.Empty;
            note.Text = string.Empty;

            date.Value = DateTime.Now;
            time.Value = DateTime.Now;

            yes.Checked = false;
            no.Checked = false;
            backno.Checked = false;
            required.Checked = false;

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView2.SelectedItems[0];
            //ID DATE POSTCODE TRAINING
            roleid.Text = item.SubItems[0].Text;
            date.Text = item.SubItems[1].Text;
            postcode.Text = item.SubItems[2].Text;
            if (item.SubItems[3].Text == "True")
            {
                yes.Checked = true;
                no.Checked = false;
            }
            else
            {
                no.Checked = true;
                yes.Checked = false;
            }

            //rest to be stored for future reference
            //TITLE BACKGROUND TIME PLACE NOTE
            title.Text = item.SubItems[4].Text;
            if (item.SubItems[5].Text == "True")
            {
                required.Checked = true;
                backno.Checked = false;
            }
            else
            {
                backno.Checked = true;
                required.Checked = false;
            }
            time.Text = item.SubItems[6].Text;
            placecombo.SelectedItem = item.SubItems[7].Text;
            note.Text = item.SubItems[8].Text;

            string message = title.Text + " is now updated. New work information ! ";
            MessageBox.Show(message);

            roleid.Text = string.Empty;
            date.Text = string.Empty;
            postcode.Text = string.Empty;
            title.Text = string.Empty;
            note.Text = string.Empty;

            date.Value = DateTime.Now;
            time.Value = DateTime.Now;

            yes.Checked = false;
            no.Checked = false;
            backno.Checked = false;
            required.Checked = false;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to clear all the fields ? \n\nClick 'Yes' to CLEAR \nClick 'No' NOT to clear", "Close", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                roleid.Text = string.Empty;
                date.Text = string.Empty;
                postcode.Text = string.Empty;
                title.Text = string.Empty;
                note.Text = string.Empty;

                date.Value = DateTime.Now;
                time.Value = DateTime.Now;

                yes.Checked = false;
                no.Checked = false;
                backno.Checked = false;
                required.Checked = false;
            }


        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView2.SelectedItems[0];
            //ID DATE POSTCODE TRAINING
            roleid.Text = item.SubItems[0].Text;
            date.Text = item.SubItems[1].Text;
            postcode.Text = item.SubItems[2].Text;
            if (item.SubItems[3].Text == "True")
            {
                yes.Checked = true;
                no.Checked = false;
            }
            else
            {
                no.Checked = true;
                yes.Checked = false;
            }

            //rest to be stored for future reference
            //TITLE BACKGROUND TIME PLACE NOTE
            title.Text = item.SubItems[4].Text;
            if (item.SubItems[5].Text == "True")
            {
                required.Checked = true;
                backno.Checked = false;
            }
            else
            {
                backno.Checked = true;
                required.Checked = false;
            }
            time.Text = item.SubItems[6].Text;
            placecombo.SelectedItem = item.SubItems[7].Text;
            note.Text = item.SubItems[8].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage manfrm = new Manage();
            manfrm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Assign assign = new Assign();
            ListViewItem AssignID = listView2.SelectedItems[0];
            assign.RoleID = AssignID.SubItems[0].Text;
            assign.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close this ? \n\nClick 'Yes' to CLOSE \nClick 'No' NOT to close", "Close", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }


        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
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
            Roles frm= new Roles();
            frm.ShowDialog();
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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void no_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void placecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Roles_Load(object sender, EventArgs e)
        {

        }
    }
}
