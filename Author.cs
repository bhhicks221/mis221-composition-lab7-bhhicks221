using System;
using System.IO;
namespace mis221_composition_lab7_bhhicks221
{
    public class Author
    {
        private string name;
        private char gender;
        private string email;
        public Author(string name, char gender, string email)
        {
            this.name = name;
            this.gender = gender;
            this.email = email;
        }
         public void SetName(string name)
        {
            this.name = name;
        }
        public void SetGender(char gender)
        {
            this.gender = gender;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetName()
        {
            return name;
        }
        public char GetGender()
        {
            return gender;
        }
        public string GetEmail()
        {
            return email;
        }
        public override string ToString()
        {
            return "name = " + name + " email = " + email + " gender = " + gender;
        }
    }
}