using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSound
{
    public class Animal
    {
        //This method can be using the Animal instance and override in the inheriting class
        //the behavour/implementation of the method would change based on object instance created
        public virtual string speak(int x) { return "silence"; }

    }
}
