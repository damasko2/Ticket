using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket;
            int num;
            C_Ticket tick = new C_Ticket();
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Введите номер билета:");
                        ticket = Console.ReadLine();

                        if (ticket.Length<6||ticket.Length>6)
                        {
                            throw FormatDim();
                        }

                        num = Convert.ToInt32(ticket);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nНеверный формат ввода. Введите число действительного типа");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    catch(NotImplementedException)
                    {
                        Console.WriteLine("Должно быть введенно 6 цифр!!!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                if (tick.happy(ticket))
                {
                    Console.WriteLine("Ваш билет счастливый");
                }
                else
                {
                    Console.WriteLine("Ваш билет не счастливый");
                }

                Console.WriteLine("Хотите повторить?");
                Console.WriteLine("Нажмите 1");
                num = Convert.ToInt32(Console.ReadLine());

                if (num!=1)
                {
                    break;
                }
                Console.Clear();
            }
        }

        private static Exception FormatDim()
        {
            throw new NotImplementedException();
        }
    }
}
