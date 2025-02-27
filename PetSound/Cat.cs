using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSound
{
    public class Cat: Animal
    {
        //Since we are not override from the parent class, this method consider new method of this class.
        public string speak(int x) { return "meow"; }
    }
}
