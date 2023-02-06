using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.calcule_las_áreas_de_las_figuras_geométricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una figura geométrica:"); //Aqui establecemos para que el usuario eliga, la figura que desea calcular.
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Pentágono");
            Console.WriteLine("5. Hexágono");
            int option = int.Parse(Console.ReadLine()); //Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente.

            switch (option)
            {
                case 1:
                    Console.WriteLine("Ingrese el lado del cuadrado:");
                    double side = double.Parse(Console.ReadLine()); ////Convierte la representación en forma de cadena de un número en el número de punto flotante de precisión doble equivalente.
                    Console.WriteLine("El área del cuadrado es: " + side * side);//aqui la formula para realizar el calculo.
                    Console.ReadLine();//para imprimir en pantalla el resultado de la operacio.
                    break;
                
                case 2:
                    Console.WriteLine("Ingrese el radio del círculo:");
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("El área del círculo es: " + Math.PI * radius * radius); //aqui la formula para realizar el calculo.
                    Console.ReadLine();//para imprimir en pantalla el resultado de la operacio.
                    break;
               
                case 3:
                    Console.WriteLine("Ingrese la base del triángulo:");
                    double baseTriangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triángulo:");
                    double heightTriangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("El área del triángulo es: " + (baseTriangle * heightTriangle) / 2); //aqui la formula para realizar el calculo.
                    Console.ReadLine();//para imprimir en pantalla el resultado de la operacio.
                    break;
               
                case 4:
                    Console.WriteLine("Ingrese la longitud de un lado del pentágono:");
                    double sidePentagon = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la apotema del pentágono:");
                    double apothemPentagon = double.Parse(Console.ReadLine());
                    Console.WriteLine("El área del pentágono es: " + (5 * sidePentagon * apothemPentagon) / 2); //aqui la formula para realizar el calculo.
                    Console.ReadLine();//para imprimir en pantalla el resultado de la operacio.
                    break;
               
                case 5:
                    Console.WriteLine("Ingrese la longitud de un lado del hexágono:");
                    double sideHexagon = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la apotema del hexágono:");
                    double apothemHexagon = double.Parse(Console.ReadLine()); //Convierte la representación en forma de cadena de un número en el número de punto flotante de precisión doble equivalente.
                    Console.WriteLine("El área del hexágono es: " + (6 * sideHexagon * apothemHexagon) / 2); //aqui la formula para realizar el calculo.
                    Console.ReadLine(); //para imprimir en pantalla el resultado de la operacio.
                    break;
               
                default:
                    Console.WriteLine("Opción inválida.");
                    Console.ReadLine();
                    break;
                                        
            }
        }
    }
}