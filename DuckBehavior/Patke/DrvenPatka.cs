using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckBehavior
{
    class DrvenPatka : Patka
    {
        public DrvenPatka()
        {
            _letenje = new Letenje.NeLetim();
            _kvakanje = new Kvakanje.Sutljiva();
        }
    }
}
