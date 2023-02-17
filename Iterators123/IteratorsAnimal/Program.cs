using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogList list = new DogList();
            foreach (Dog dog in list)
            {
                if (!dog.Dobro)
                {
                    dog.GetSnack(2);
                }
                else
                {
                    dog.GetSnack(1);
                }
            }
        }
    }
}
