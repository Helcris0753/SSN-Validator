using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSN_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int conteo = 0;
            string answer = "";
            string n = "";

            do
            {
                do
                {
                    conteo = 0;
                    Console.Write("\nBIenvenido al SSN Validator.\nPor favor, introduzca su SSN: ");
                    n = Console.ReadLine();

                    if (n.Length != 9)
                    {
                        Console.WriteLine("Codigo invalidado!\nVerifique que el numero introducido posee exactamente 9 digitos.");
                        conteo++;
                    }
                    else
                    {
                        if (!(int.TryParse(n, out int num)))
                        {
                            Console.WriteLine("Codigo invalidado!\nVerifique que el numero introducido no posee letras.");
                            conteo++;
                        }
                        if (n.Substring(0, 3) == "000" || n.Substring(0, 3) == "666" || n.Substring(0, 1) == "9")
                        {
                            Console.WriteLine("Codigo invalidado!\nLos tres primeros numeros no pueden ser ni '000', ni '666' o estar entre '900' y '999'.");
                            conteo++;
                        }
                        if (n.Substring(3, 2) == "00")
                        {
                            Console.WriteLine("Coigo invalido!\nLos numeros en la posicion 4 y 5 no pueden ser a la vez '0', formando asi el codigo: '00'.");
                            conteo++;
                        }
                    }
                } while (conteo != 0);
                Console.WriteLine($"Codigo validado!\nEl SSN {string.Format("{0: ###-##-####}", int.Parse(n))} es valido!");

                do
                {
                    Console.Write("Desea salir? Y/N:");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "y")
                    {
                        Console.WriteLine("FIn del programa.\nAdios!");
                        break;
                    }
                    else if (answer.ToLower() == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida.\nIntente de nuevo");
                    }
                } while (true);
            } while (answer != "y");
        }
    }
}
