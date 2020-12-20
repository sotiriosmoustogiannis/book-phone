using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication17
{
    public partial class Form3 : Form
    {   public int i,k,j,m;
        public bool flag = false;
        
        public static ListViewItem lv1 = new ListViewItem();

        public Form3()
        {
            InitializeComponent();
           

        }
        public void Search(string txt,string ct)
        {
            //anazitisi epafwn
              if (ct.ToString().StartsWith(txt))
              {
                    richTextBox1.AppendText(mycontacts.Contactlist[k].getName().ToString() + " " + mycontacts.Contactlist[k].getSurname().ToString() + " " + mycontacts.Contactlist[k].getPhone().ToString() + " " + mycontacts.Contactlist[k].getEmail().ToString() + " " + mycontacts.Contactlist[k].getAddress().ToString() + " " + mycontacts.Contactlist[k].getBirthday().ToString() + Environment.NewLine);
              }
               
            
        }
      
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //eisodos twn epafwn poy exoun dimiourgithei sto listview tis formas      
            for (i = 0; i < mycontacts.Contactlist.Count; i++)
            {
                
                lv1 = new ListViewItem(mycontacts.Contactlist[i].getName().ToString());
                lv1.SubItems.Add(mycontacts.Contactlist[i].getSurname().ToString());
                lv1.SubItems.Add(mycontacts.Contactlist[i].getPhone().ToString());
                lv1.SubItems.Add(mycontacts.Contactlist[i].getEmail().ToString());
                lv1.SubItems.Add(mycontacts.Contactlist[i].getAddress().ToString());
                lv1.SubItems.Add(mycontacts.Contactlist[i].getBirthday().ToString());
                listView1.Items.Add(lv1);
            }
            //elegxos genethliwn kata to anoigma tis formas 
            string birthdays = "";
            string tmp = "";
            string date = "";
            int count = 0;
            for (k = 0; k < mycontacts.Contactlist.Count; k++)
            {
                date = "";
                tmp = mycontacts.Contactlist[k].getBirthday();

                foreach (char c1 in tmp)
                {
                    if (c1 == '/') count++;
                    if (count != 2) date += c1;
                    else { count = 0; break; }
                }

                if (date == Form1.mydate.ToString())
                    birthdays += mycontacts.Contactlist[k].getName() + Environment.NewLine;


            }
            if (Form2.flag == true)
                MessageBox.Show(birthdays.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //diagrafh epafhs
            if (listView1.SelectedItems.Count == 0) return;
            mycontacts.Contactlist.RemoveAt(listView1.SelectedItems[0].Index);
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //anoigma tou txt arxeiou
            StreamReader reader = new StreamReader("contacts.txt");
            string[] words = reader.ReadToEnd().Split('$');
         
            Contact c;
            i = 0;
            
            if (new FileInfo("contacts.txt").Length != 0)
            {
                for (j = 0; j < words.Length; j += 6)
                {

                    c = new Contact(words[j].ToString(), words[1 + j].ToString(), words[2 + j].ToString(), words[3 + j].ToString(), words[4 + j].ToString(), words[5 + j].ToString());
                    mycontacts.Contactlist.Add(c);
                    mycontacts.Contactlist[i].getName();
                    mycontacts.Contactlist[i].getSurname();
                    mycontacts.Contactlist[i].getPhone();
                    mycontacts.Contactlist[i].getEmail();
                    mycontacts.Contactlist[i].getAddress();
                    mycontacts.Contactlist[i].getBirthday();
                    i++;
                    ListViewItem lv1 = new ListViewItem(c.getName().ToString());

                    lv1.SubItems.Add(c.getSurname());
                    lv1.SubItems.Add(c.getPhone());
                    lv1.SubItems.Add(c.getEmail());
                    lv1.SubItems.Add(c.getAddress());
                    lv1.SubItems.Add(c.getBirthday());
                    listView1.Items.Add(lv1);

                }
                reader.Close();
            }else
            {
                flag = true;
                MessageBox.Show("Your agenda is empty");
                reader.Close();
            }
            //elegxos gia genethlia
            string birthdays = "";
            string tmp = "";
            string date = "";
            int count = 0;
            for (k = 0; k < mycontacts.Contactlist.Count; k++)
            {
                date = "";
                tmp = mycontacts.Contactlist[k].getBirthday();

                foreach (char c1 in tmp)
                {
                    if (c1 == '/') count++;
                    if (count != 2) date += c1;
                    else { count = 0; break; }
                }

                if (date == Form1.mydate.ToString())
                    birthdays += mycontacts.Contactlist[k].getName() + Environment.NewLine;


            }
            if (flag == false)
            {
                MessageBox.Show(birthdays.ToString()+"has birthday today");
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
     
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //anazitisi epafwn me bash to onoma , epwnimo kai thlefwno
            for (k = 0; k < mycontacts.Contactlist.Count; k++)
            {
                if (textBox1.Text != "")
                    Search(textBox1.Text, mycontacts.Contactlist[k].getName());
                 if (textBox2.Text != "")
                    Search(textBox2.Text, mycontacts.Contactlist[k].getSurname());
                 if (textBox3.Text != "")
                    Search(textBox3.Text, mycontacts.Contactlist[k].getPhone());
               
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
