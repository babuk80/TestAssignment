using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSound
{
    public class Dog:Animal
    {
        //Override was missing and parameter type should be s
        public override string speak(int x) { return "bow-wow"; }


        public  string speak(short x) { return "bow-wow-wow"; }

    }
}
