using System;
namespace Class06._02._2023HM
{
    public class Magazine
    {
        private string Name_Magazine;
        private int Year_Foundation;
        private string Description_Magazine;
        private string Nomber_Contact;
        private string Email_Contact;

        Magazine()
        {

        }
        Magazine(string NM, int YF, string DM, string NC, string EC)
        {
            Name_Magazine = NM;
            Year_Foundation = YF;
            Description_Magazine = DM;
            Nomber_Contact = NC;
            Email_Contact = EC;
        }

        public string name_magazine
        {
            set
            {
                Name_Magazine = value;
            }
            get
            {
                return Name_Magazine;

            }

        }
        public int year_foundatoin
        {
            set
            {
                Year_Foundation = value;
            }
            get
            {
                return Year_Foundation;
            }
        }
        public string description_magazine
        {
            set
            {
                Description_Magazine = value;

            }
            get
            {
                return Description_Magazine;
            }
        }
        public string nomber_contact
        {
            set
            {
                Nomber_Contact = value;
            }
            get
            {
                return Nomber_Contact;
            }
        }
        public string email_contact
        {
            set
            {
                Email_Contact = value;
            }
            get
            {
                return Email_Contact;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Name Magazin:{Name_Magazine}\tYear_Foundation:{Year_Foundation}\tDescription_Magazine:{Description_Magazine}\tNomber_Contact:{Nomber_Contact}\tEmail_Contact:{Email_Contact}\t");

        }

        public override string ToString()
        {
           return $"Name Magazin:{Name_Magazine}\tYear_Foundation:{Year_Foundation}\tDescription_Magazine:{Description_Magazine}\tNomber_Contact:{Nomber_Contact}\tEmail_Contact:{Email_Contact}\t";
        }
    }
}
