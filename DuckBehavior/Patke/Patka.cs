using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckBehavior
{
    public abstract class Patka
    {
       public ILetim _letenje;
       public IKvacem _kvakanje;

        public Patka()
        { }

        public void Kvakni()
        {
            _kvakanje.Kvacem();
        }

        public void Poleti()
        {
            _letenje.Letim();
        }
        public void setLetenje(ILetim let)
        {
            _letenje = let;
        }
        public void setKvakanje(IKvacem kvak)
        {
            _kvakanje = kvak;
        }
        public void Plivaj()
        {
            Console.WriteLine("Sve patke plivaju");
        }
    }
}
