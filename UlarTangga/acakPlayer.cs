using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlarTangga
{
    public class acakPlayer
    {
        public int GeneratePlayer()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int number = 0;
            number = random.Next(1, 2);
            int pilihPlayer = number;

            return pilihPlayer;

        }
    }
}
