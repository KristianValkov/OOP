using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAnimal
{
    public class Dog
    {
		private string name;
		private bool dobro;

		public Dog(string name,bool dobro)
		{
			this.name = name;
			this.dobro = dobro;
		}
		public bool Dobro
		{
			get { return dobro; }
			set { dobro = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public void GetSnack(int snackCount)
		{
			Console.WriteLine($"Dog {name} said {snackCount}!");
		}
	}
}
