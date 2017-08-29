using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlarTangga
{
    public class acakDadu
    {
        public int GenerateDice()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int number = 0;
            for (int i = 0; i < 5000; i++)
            {
                //Thread.Sleep(1);
                Console.SetCursorPosition(5, 14);
                number = random.Next(1, 6);
                Console.WriteLine(number);

            }

            return number;

        }
    }
}
