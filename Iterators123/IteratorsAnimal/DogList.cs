using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAnimal
{
    public class DogList:IEnumerable<Dog>
    {
        public List<Dog> dog;
        public DogList()
        {
            dog = new List<Dog>()
            {
                new Dog("Gogo",true),
                new Dog("Pepo",true),
                new Dog("Nono",false)
            };
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            return dog.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
