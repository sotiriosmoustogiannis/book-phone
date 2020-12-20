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
using System.Xml;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public static string mydate;
        public int i = 0;
        public Form1()
        {
            InitializeComponent();        
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //apothikseysh twn epafwn se txt arxeio 
            TextWriter tw = new StreamWriter("contacts.txt");
            for (i = 0; i < mycontacts.Contactlist.Count; i++)
            {
                if (i == 0)
                {
                    tw.Write(mycontacts.Contactlist[i].getName().ToString() + "$" + mycontacts.Contactlist[i].getSurname().ToString()
                    + "$" + mycontacts.Contactlist[i].getPhone().ToString() + "$" + mycontacts.Contactlist[i].getEmail().ToString()
                    + "$" + mycontacts.Contactlist[i].getAddress().ToString() + "$" + mycontacts.Contactlist[i].getBirthday().ToString());
                }
                else
                {
                    tw.Write("$" + mycontacts.Contactlist[i].getName().ToString() + "$" + mycontacts.Contactlist[i].getSurname().ToString()
                    + "$" + mycontacts.Contactlist[i].getPhone().ToString() + "$" + mycontacts.Contactlist[i].getEmail().ToString()
                    + "$" + mycontacts.Contactlist[i].getAddress().ToString() + "$" + mycontacts.Contactlist[i].getBirthday().ToString());
                }
            }

            tw.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
          }

        private void Form1_Load(object sender, EventArgs e)
        {
            mydate = DateTime.Now.ToString("dd/MM");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 fmr3 = new Form4();
            fmr3.Show();
        }
    }
    }

