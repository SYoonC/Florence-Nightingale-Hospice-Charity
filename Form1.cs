using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            
        }



        

        

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to exit this program ? \n\nClick 'Yes' to EXIT \nClick 'No' NOT to exit", "EXIT", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Manage managefrm = new Manage();
            managefrm.ShowDialog();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Roles rolefrm = new Roles();
            rolefrm.ShowDialog();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Assign assignfrm = new Assign();
            assignfrm.ShowDialog();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colour colour = new Colour();
            colour.ShowDialog();
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

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            manage.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            roles.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Assign assign = new Assign();
            assign.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
