using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartkowka.Xiega
{
    internal class Worker
    {
        public string imie;
        private string nazwisko;
        private float waga;
        enum wzrost { 
            niski, 
            sredni, 
            wysoki
        };
        public Worker() { }
        public Worker(string imie, string nazwisko, float waga) { 
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.waga = waga;
        }
    }
}
