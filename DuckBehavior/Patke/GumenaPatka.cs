using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckBehavior
{
    class GumenaPatka : Patka
    {
        public GumenaPatka()
        {
            _letenje = new Letenje.NeLetim();
            _kvakanje = new Kvakanje.Laprdanje();
        }
    }
}
