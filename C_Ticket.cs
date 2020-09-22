using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class C_Ticket
    {
        public bool happy(string ticket)
        {
            int num1 = 0, num2 = 0;

            char[] arr = new char[7];
            arr[6] = '\0';

            arr = ticket.ToCharArray();

            for (int i = 0; i < ticket.Length/2; i++)
            {
                num1 += Convert.ToInt32(arr[i]);
                num2 += Convert.ToInt32(arr[i+3]);
            }

            if (num1==num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
