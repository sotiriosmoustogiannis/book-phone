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
    public partial class Form4 : Form
    {
         
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //eisagwgh twn onomatwn kathe epafis sto listview tis formas
              for(int i = 0; i < mycontacts.Contactlist.Count; i++)
            {
                listView1.Items.Add(mycontacts.Contactlist[i].getName().ToString());

            } 
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ananewsh twn stoixeiwn kathe epafhs kai elegxos gia egkurh morfh email
            if ((textBox4.Text.Contains('@') && textBox4.Text.Contains('.')))
            {
                mycontacts.Contactlist[listView1.SelectedItems[0].Index].setName(textBox1.Text.ToString());
                mycontacts.Contactlist[listView1.SelectedItems[0].Index].setSurname(textBox2.Text.ToString());
                mycontacts.Contactlist[listView1.SelectedItems[0].Index].setPhone(textBox3.Text.ToString());
                mycontacts.Contactlist[listView1.SelectedItems[0].Index].setEmail(textBox4.Text.ToString());
                mycontacts.Contactlist[listView1.SelectedItems[0].Index].setAddress(textBox5.Text.ToString());
                mycontacts.Contactlist[listView1.SelectedItems[0].Index].setBirthday(textBox6.Text.ToString());
                listView1.SelectedItems[0].Text = textBox1.Text;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Email");
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //emfanisi twn stoixwn kathe epafhs sta textbox
            textBox1.Text = mycontacts.Contactlist[listView1.SelectedItems[0].Index].getName().ToString();
            textBox2.Text = mycontacts.Contactlist[listView1.SelectedItems[0].Index].getSurname().ToString();
            textBox3.Text = mycontacts.Contactlist[listView1.SelectedItems[0].Index].getPhone().ToString();
            textBox4.Text = mycontacts.Contactlist[listView1.SelectedItems[0].Index].getEmail().ToString();
            textBox5.Text = mycontacts.Contactlist[listView1.SelectedItems[0].Index].getAddress().ToString();
            textBox6.Text = mycontacts.Contactlist[listView1.SelectedItems[0].Index].getBirthday().ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;                       //elegxos gia ton arithmo thlefwnou wste na dexetai mono arithmous
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
