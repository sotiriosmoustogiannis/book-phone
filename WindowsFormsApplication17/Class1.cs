using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    class Contact
    {
        private string Name, Surname, Phone, Email, Address, Birthday;
        public Contact(string Name, string Surname, string Phone, string Email, string Address, string Birthday)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.Birthday = Birthday;

        }
        public string getName()
        {
            return this.Name;
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public string getSurname()
        {
            return this.Surname;
        }
        public void setSurname(string surname)
        {
            this.Surname = surname;
        }
        public string getPhone()
        {
            return this.Phone;
        }
        public void setPhone(string phone)
        {
            this.Phone = phone;
        }
        public string getEmail()
        {
            return this.Email;
        }
        public void setEmail(string email)
        {
            this.Email = email;
        }
        public string getAddress()
        {
            return this.Address;
        }
        public void setAddress(string address)
        {
            this.Address = address;
        }
        public string getBirthday()
        {
            return this.Birthday;
        }
        public void setBirthday(string birthday)
        {
            this.Birthday = birthday;
        }

     
    }
}
