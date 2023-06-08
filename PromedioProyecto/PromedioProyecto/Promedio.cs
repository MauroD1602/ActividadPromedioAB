using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioProyecto
{
    internal class Promedio
    {
        private int n;
        private double acum;

        public Promedio()
        {
            n = 0;
            acum = 0;
        }

        public void AgregarValores(double valor)
        {
            acum += valor;
            n++;
        }

        public double Prom()
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return acum / n;
            }
        }
    }
}
