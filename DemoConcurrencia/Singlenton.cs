using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcurrencia
{
    public sealed class Singlenton
    {
        private static Singlenton instance = null;
        private static readonly object bloqueo = new object();
        public Singlenton() 
        {
            
        }
        public static Singlenton Instance
        {
            get
            {
                lock (bloqueo)
                {
                    if (instance == null)
                    {
                        instance = new Singlenton();
                    }
                    return instance;
                }
            } 
        }
    }
}
