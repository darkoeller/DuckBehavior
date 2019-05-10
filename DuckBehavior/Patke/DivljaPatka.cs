using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckBehavior
{
    class DivljaPatka : Patka
    {
        public DivljaPatka()
        {
            _letenje = new LetimKoLud();
            _kvakanje = new Kvakanje.Laprdanje();
        }
    }
}
