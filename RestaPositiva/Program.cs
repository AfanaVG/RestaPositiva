using System;
using System.Security.Permissions;

namespace RestaPositiva
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int menu;
            do
            {

            
                Console.WriteLine("Elija su opción");
                Console.WriteLine("");
                Console.WriteLine("1- Resta positiva");
                Console.WriteLine("2- Numero de cinco cifras");
                Console.WriteLine("3- Suma intervalo");
                Console.WriteLine("4- Fibonacci");
                Console.WriteLine("9- Salir");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        resta();
                        break;
                    case 2:
                        cincoCifras();
                        break;
                    case 3:
                        sumaIntervalo();
                        break;
                    case 4:
                        fibonacci();
                        break;
                }
                if (menu<1 || menu>4 && menu!=9)
                {
                    Console.WriteLine("Opcion no contemplada en el menu");
                }
            } while (menu != 9);
        }

        public static void fibonacci()
        {
            int limite;
            String secuencia="";
            int n1=0;
            int n2=1;
            int n3;
            Console.WriteLine("Introduzca hasta que numero desea realizar la ecuacion");
            limite = SolicitarEntero();

            for (int i = 2; i < limite; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                secuencia = secuencia + n3 + " ";
            }

            Console.WriteLine(secuencia);


        }

        public static void sumaIntervalo()
        {
            int x;
            int y;
            int [] intervalo;
            int sumaTotal = 0;

            Console.WriteLine("Introduzca numero X");
            x = SolicitarEntero();

            do
            {
                Console.WriteLine("Introduzca numero Y");
                y = SolicitarEntero();
                if (y<x)
                {
                    Console.WriteLine("Y no puede ser menor que X");
                }
            } while (y<x);
            
            

            intervalo = new int[y - x];

            for (int i = 0; i < intervalo.Length; i++)
            {
                intervalo[i] = x + i;
                //if (intervalo[i] != x && intervalo[i] != y)
                //{
                    sumaTotal = sumaTotal + intervalo[i];
                //}
                
            }
            Console.WriteLine("La suma del intervalo es " + sumaTotal);

        }

        public static void resta()
        {
            int resultado;
            int num1;
            int num2;
            Console.WriteLine("Introduzca numero 1");
            
            num1 = SolicitarEntero();
            Console.WriteLine("Introduzca numero 2");
            num2 = SolicitarEntero();
            resultado = num1 - num2;
            if (resultado < 0)
            {
                 resultado = resultado * (-1);
            }
            Console.WriteLine("El resultado es " + resultado);
        }

        public static void cincoCifras()
        {

            int num;
            bool valido = false;

            do
            {

                Console.WriteLine("Introduzca numero");
                num = SolicitarEntero();
            
            if (num.ToString().Length > 5)
            {
                Console.WriteLine("El numero de cifras no es valido, ha de ser menor de cinco");
                    valido = false;
            }
            else
            {
                Console.WriteLine("Numero de cifras adecuado");
                    Console.WriteLine("El numero tiene " + num.ToString().Length + " cifras");
                    valido = true;
            }
            } while (!valido);

        }

        static int SolicitarEntero() {

            bool valido;
            int num;
            do
            {
                
                valido = int.TryParse(Console.ReadLine(), out num);
                if (!valido)
                {
                    Console.WriteLine("Numero no es entero");
                }
                else
                {
                    Console.WriteLine("Numero es entero");
                }
            } while (!valido);
            return num;
        }
    }
}
