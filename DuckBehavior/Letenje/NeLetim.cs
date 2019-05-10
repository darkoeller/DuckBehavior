using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckBehavior.Letenje
{
    class NeLetim : ILetim
    {
        public void Letim()
        {
            Console.WriteLine("Ja uopće ne letim!");
        }
    }
}
