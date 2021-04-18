using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyPersonaPeso
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Introduzca el nombre de la persona");
            string nombre = Convert.ToString(Console.ReadLine());
            System.Console.WriteLine("Introduzca la edad de la persona");
            int edad = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Introduzca la altura de la persona");
            double altura = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Introduzca el sexo de la persona F o M");
            char sexo = Convert.ToChar(Console.ReadLine());
            System.Console.WriteLine("Introduzca el peso de la persona");
            double peso = Convert.ToDouble(Console.ReadLine());

            Persona p1 = new Persona(nombre, edad, altura, sexo, peso);

            int imc = p1.calcularIMC();

            if (imc == -1)
            {
                System.Console.WriteLine("Bajo peso");
            }
            else if (imc == 0)
            {
                System.Console.WriteLine("Peso ideal");
            }
            else {
                System.Console.WriteLine("Sobrepeso");
            }

            if (p1.pEdad >= 21) {
                System.Console.WriteLine(p1.pNombre + " es mayor de edad");
            }  else {
                System.Console.WriteLine(p1.pNombre+" es menor de edad");
            }
            Console.ReadKey();
        }
    }
}
