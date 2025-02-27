using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessConstClass
{
   public class B
    {
        // On below code Reference type cannot assigned as constant.
        // We cannot compile ,because we are cannot assigned. 
        // So, we are changing readonly to make sure value are assigned during the construtor
        //public const A a;

        public static readonly A InstanceOfA = new A();
        public B()
        {
            InstanceOfA.a = 10;
            InstanceOfA.b = 20;
        }


    }
}
