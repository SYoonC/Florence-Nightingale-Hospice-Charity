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
    public partial class Manage : Form
    {
        private string imagelocation = "";
        public Manage()
        {
            InitializeComponent();
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            image.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void upload_Click(object sender, EventArgs e)
        {
            image.BackgroundImageLayout = ImageLayout.Stretch;

            try
            {
                // code 
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    image.ImageLocation = imagelocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            image.BackgroundImageLayout = ImageLayout.Stretch;

            if (listView.SelectedItems.Count == 0)
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("Do you want to delete this volunteer ? \n\nClick 'Yes' to DELETE \nClick 'No' NOT to delete", "Close", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                listView.SelectedItems[0].Remove();
            }
            id.Text = string.Empty;
            name.Text = string.Empty;
            postcode.Text = string.Empty;
            note.Text = string.Empty;

            male.Checked = false;
            female.Checked = false;
            yes.Checked = false;
            no.Checked = false;

            age.Value = 0;


            image.Image = default;

            imagelocation = "";
            imagelocation = "";

            checkBoxEmail.Checked = false;
            checkBoxMobile.Checked = false;
            checkBoxPost.Checked = false;



        }

        private void add_Click(object sender, EventArgs e)
        {
            image.BackgroundImageLayout = ImageLayout.Stretch;

            ListViewItem item = new ListViewItem();
            //ID NAME AGE TRAINING POSTCODE
            item.Text = id.Text;
            item.SubItems.Add(name.Text);
            item.SubItems.Add(age.Value.ToString());
            item.SubItems.Add(yes.Checked.ToString());
            item.SubItems.Add(postcode.Text);

            //rest to be stored for future reference
            //GENDER DATE CONTACT NOTE IMAGE
            item.SubItems.Add(female.Checked.ToString());
            item.SubItems.Add(joindate.Value.ToString());
            item.SubItems.Add(note.Text);
            item.SubItems.Add(imagelocation);
            if (checkBoxMobile.Checked)
            {
                item.SubItems.Add("Mobile");
            }
            else
            {
                item.SubItems.Add("");
            }
            if (checkBoxEmail.Checked)
            {
                item.SubItems.Add("Email");
            }
            else
            {
                item.SubItems.Add("");
            }
            if (checkBoxPost.Checked)
            {
                item.SubItems.Add("Post");
            }
            else
            {
                item.SubItems.Add("");
            }






            listView.Items.Add(item);

            string message = name.Text + " is now a volunteer. Welcome our newby ! ";

            if (age.Value < 19)
            {
                message = name.Text + " is under 18. The information will have a restricted permission.\n" + message;
            }

            MessageBox.Show(message);

            id.Text = string.Empty;
            name.Text = string.Empty;
            postcode.Text = string.Empty;
            note.Text = string.Empty;

            male.Checked = false;
            female.Checked = false;
            yes.Checked = false;
            no.Checked = false;

            age.Value = 0;


            image.Image = default;
            imagelocation = "";

            checkBoxEmail.Checked = false;
            checkBoxMobile.Checked = false;
            checkBoxPost.Checked = false;


        }

        private void update_Click(object sender, EventArgs e)
        {
            image.BackgroundImageLayout = ImageLayout.Stretch;

            if (listView.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView.SelectedItems[0];
            //ID NAME AGE TRAINING POSTCODE
            id.Text = item.SubItems[0].Text;
            name.Text = item.SubItems[1].Text;
            age.Text = item.SubItems[2].Text;
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
            postcode.Text = item.SubItems[4].Text;

            //rest to be stored for future reference
            //GENDER DATE CONTACT NOTE IMAGE
            if (item.SubItems[5].Text == "True")
            {
                female.Checked = true;
                male.Checked = false;
            }
            else
            {
                male.Checked = true;
                female.Checked = false;
            }
            joindate.Text = item.SubItems[6].Text;
            note.Text = item.SubItems[7].Text;
            //***How to contact? Add here
            if (item.SubItems[9].Text == "Mobile")
            {
                checkBoxMobile.Checked = true;
            }
            else
            {
                checkBoxMobile.Checked = false;
            }
            if (item.SubItems[10].Text == "Email")
            {
                checkBoxEmail.Checked = true;
            }
            else
            {
                checkBoxEmail.Checked = false;
            }
            if (item.SubItems[11].Text == "Post")
            {
                checkBoxPost.Checked = true;
            }
            else
            {
                checkBoxPost.Checked = false;
            }
            //***How to image? Add here
            imagelocation = item.SubItems[8].Text;
            if (imagelocation.Length != 0)
            {
                image.Image = new Bitmap(imagelocation);
            }



            string message = name.Text + " is now a volunteer. Welcome our newby ! ";

            if (age.Value < 19)
            {
                message = name.Text + " is under 18. The information will have a restricted permission.\n" + message;
            }

            MessageBox.Show(message);

            id.Text = string.Empty;
            name.Text = string.Empty;
            postcode.Text = string.Empty;
            note.Text = string.Empty;

            male.Checked = false;
            female.Checked = false;
            yes.Checked = false;
            no.Checked = false;

            age.Value = 0;


            image.Image = default;
            imagelocation = "";

            checkBoxEmail.Checked = false;
            checkBoxMobile.Checked = false;
            checkBoxPost.Checked = false;


        }

        private void clear_Click(object sender, EventArgs e)
        {
            image.BackgroundImageLayout = ImageLayout.Stretch;

            DialogResult dialog = MessageBox.Show("Do you want to clear all the fields ? \n\nClick 'Yes' to CLEAR \nClick 'No' NOT to clear", "Close", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                id.Text = string.Empty;
                name.Text = string.Empty;
                postcode.Text = string.Empty;
                note.Text = string.Empty;

                male.Checked = false;
                female.Checked = false;
                yes.Checked = false;
                no.Checked = false;

                age.Value = 0;

                image.Image = default;

                imagelocation = "";

                checkBoxEmail.Checked = false;
                checkBoxMobile.Checked = false;
                checkBoxPost.Checked = false;
            }

        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private void contact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void postcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void note_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void yes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void age_ValueChanged(object sender, EventArgs e)
        {

        }

        private void no_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void joindate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView.SelectedItems[0];
            //ID NAME AGE TRAINING POSTCODE
            id.Text = item.SubItems[0].Text;
            name.Text = item.SubItems[1].Text;
            age.Text = item.SubItems[2].Text;
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
            
            postcode.Text = item.SubItems[4].Text;

            //rest to be stored for future reference
            //GENDER DATE CONTACT NOTE IMAGE
            if (item.SubItems[5].Text == "True")
            {
                female.Checked = true;
                male.Checked = false;
            }
            else
            {
                male.Checked = true;
                female.Checked = false;
            }
            joindate.Text = item.SubItems[6].Text;
            note.Text = item.SubItems[7].Text;
            //***How to image? Add here
            imagelocation = item.SubItems[8].Text;
            if (imagelocation.Length != 0)
            {
                image.Image = new Bitmap(imagelocation);
            }
            //***How to contact? Add here
            if (item.SubItems[9].Text == "Mobile")
            {
                checkBoxMobile.Checked = true;
            }
            else
            {
                checkBoxMobile.Checked = false;
            }
            if (item.SubItems[10].Text == "Email")
            {
                checkBoxEmail.Checked = true;
            }
            else
            {
                checkBoxEmail.Checked = false;
            }
            if (item.SubItems[11].Text == "Post")
            {
                checkBoxPost.Checked = true;
            }
            else
            {
                checkBoxPost.Checked = false;
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close this ? \n\nClick 'Yes' to CLOSE \nClick 'No' NOT to close", "Close", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Roles rolefrm = new Roles();
            rolefrm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Assign assign = new Assign();
            ListViewItem AssignID = listView.SelectedItems[0];
            assign.VolID = AssignID.SubItems[0].Text;
            assign.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
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

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colour colour = new Colour();
            colour.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage frm = new Manage();
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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
