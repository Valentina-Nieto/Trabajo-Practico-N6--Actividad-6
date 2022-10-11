using System;

namespace actividad6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un menú de usuario con las opciones necesarias para solicitar que se ingresen 2
            números y que tipo de operación matemática se desea realizar: multiplicación, suma, resta,
            división. Paran finalizar mostrar resultado de la operación por pantalla.*/
            
            float a = 0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            string valor = "";
            int opcion = 0;

            Console.WriteLine("Si desea realizar una Suma, presione '1'");

            Console.WriteLine("Si desea realizar una Resta, presione '2'");

            Console.WriteLine("Si desea realizar una División, presione '3'");

            Console.WriteLine("Si desea realizar una Multiplicación, presione '4'");

            Console.Write("Que operación deseas hacer: ");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            Console.Write("Dame el primer numero: ");
            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);

            Console.Write("Dame el segundo numero: ");
            valor = Console.ReadLine();
            b = Convert.ToSingle(valor);

            switch (opcion)
            {
                case 1:
                    resultado = a + b;
                    break;

                case 2:
                    resultado = a - b;
                    break;

                case 3:
                    if (b != 0)
                        resultado = a / b;

                    else
                        Console.WriteLine("Divisor no valido");
                    break;

                case 4:
                    resultado = a * b;
                    break;

                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }

            Console.WriteLine("El resultado es: {0}", resultado);

        }
    }
}