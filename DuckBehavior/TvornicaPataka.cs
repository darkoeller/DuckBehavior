using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckBehavior
{
    public static class TvornicaPataka
    {
        public static Patka VratiDivlju()
        {
            return new DivljaPatka();
        }
        public static Patka VratiDrvenu()
        {
            return new GumenaPatka();
        }
        public static Patka VratiGumenu()
        {
            return new GumenaPatka();
        }
    }
}
