using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioProyecto
{
    class Program
    {
        #region Menu
        static void Menu()
        {
            Console.WriteLine("opcion");
            Console.WriteLine("1-Agregar Valores");
            Console.WriteLine("2-Calcular Promedio");
            Console.WriteLine("0-Salir");
        }
        #endregion
        static void Main(string[] args)
        {
            double valor;

            Promedio p = new Promedio();

            int opcion;

            do
            {
                Menu();

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Agregue un Valor");
                        valor = Convert.ToDouble(Console.ReadLine());
                        p.AgregarValores(valor);
                        break;
                    case 2:
                        Console.WriteLine("Promedio: {0}", p.Prom());
                        break;
                    default:
                        break;
                }
            }
            while (opcion != 0);
            Console.ReadKey();
        }
    }
}
