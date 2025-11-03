using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentral
{
    internal class User
    {
        string firstname;
        string lastname;
        string email;
        Card card;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Card Card
        {
            get { return card; }
            set { card = value; }
        }

        public User(string firstname,string lastname, string email,Card card)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.card = card;
        }

        public void Info()
        {
            DrawBar();
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
            Console.WriteLine(email);
            Console.WriteLine(card.Info());
            DrawBar();
        }
        private static void DrawBar()
        {
            Console.WriteLine(new String('=',40));
        }
    }
}
