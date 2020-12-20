using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form2 : Form
    {
        public int i=0,j=0;
        public static bool flag = false;
        public Form2()
        {
            InitializeComponent();
            maskedTextBox1.Mask = "00/00/0000";


        }
       
       

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            // prosthiki epafwn kai elegxos gia egkuri morfh email
            if ((textBox4.Text.Contains('@') && textBox4.Text.Contains('.')))
            {
                Contact c = new Contact(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString(), textBox5.Text.ToString(), maskedTextBox1.Text.ToString());

                mycontacts.Contactlist.Add(c);
                mycontacts.Contactlist[i].getName();
                mycontacts.Contactlist[i].getSurname();
                mycontacts.Contactlist[i].getPhone().ToString();
                mycontacts.Contactlist[i].getEmail();
                mycontacts.Contactlist[i].getAddress();
                mycontacts.Contactlist[i].getBirthday();

                ListViewItem lv1 = new ListViewItem(c.getName().ToString());

                lv1.SubItems.Add(c.getSurname());
                lv1.SubItems.Add(c.getPhone());
                lv1.SubItems.Add(c.getEmail());
                lv1.SubItems.Add(c.getAddress());
                lv1.SubItems.Add(c.getBirthday());
                listView1.Items.Add(lv1);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                maskedTextBox1.Clear();

                i++;
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Email");
            }

            
               
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // elegxos gia ton arithmo tilefwnou
            char ch = e.KeyChar;              
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
