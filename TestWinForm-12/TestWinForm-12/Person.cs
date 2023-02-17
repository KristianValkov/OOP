using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinForm_12
{
    public class Person
    {
        private string name;
        private string lastName;
        private string middleName;
        private int eGN;
        private string gander;
        private string fieldОfШork;

        public Person(string name, string lastName, string middleName, string fieldОfШork, string gander)
        {
            this.name = name;
            this.lastName = lastName;
            this.middleName = middleName;
            this.fieldОfШork = fieldОfШork;
            this.gander = gander;
        }

        public Person(string name,string lastName, int eGN, string gander, string fieldОfШork, string middleName)
        {
            this.name = name;
            this.lastName = lastName;
            this.eGN = eGN;
            this.gander = gander;
            this.fieldОfШork = fieldОfШork;
            this.middleName = middleName;
        }

        public string Name
        {
            get { return this.name; } 
            set { this.name = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int EGN
        {
            get { return this.eGN; }
            set { this.eGN = value; }
        }
        public string Gander
        {
            get { return this.gander; }
            set { this.gander = value; }
        }
        public string FieldОfШork
        {
            get { return this.fieldОfШork; }
            set { this.fieldОfШork = value; }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }
        public override string ToString()
        {
            return $"{this.name} {lastName} {middleName} {eGN} {gander} {fieldОfШork}";
        }
    }
}
