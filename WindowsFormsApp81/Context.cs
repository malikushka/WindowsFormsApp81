using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp81
{
   public class Context
   {
        public IStrategy ContextStrategy;
        public static int[] array;
        private Methods methods;

        public Context(IStrategy Strategy)
        {
           this.ContextStrategy = Strategy;
        }
        public Context() { }

        public Context(Methods methods)
        {
            this.methods = methods;
        }

        public void ExecuteAlgorithm(bool flag = true)
          {
                ContextStrategy.Algorithm(array, flag);
          }
    }
}


