using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlarTangga
{
    public class UlarDanTangga
    {
        public void legend()
        {
            Console.WriteLine("POSISI TANGGA\t\t||\tPOSISI ULAR");
            Console.WriteLine("===================================================");
            Console.WriteLine("Dari 1 Naik Ke 7\t||\tDari 97 Turun Ke 75");
            Console.WriteLine("Dari 2 Naik Ke 8\t||\tDari 25 Turun Ke 17");
            Console.WriteLine("Dari 3 Naik Ke 9\t||\tDari 31 Turun Ke 4");
            Console.WriteLine("Dari 4 Naik Ke 10\t||\tDari 67 Turun Ke 52");
            Console.WriteLine("Dari 5 Naik Ke 11\t||\tDari 47 Turun Ke 24");
            Console.WriteLine("Dari 6 Naik Ke 12\t||\tDari 53 Turun Ke 34");

        }

        public int turunNaik1(int player1)
        {
            if (player1 == 1)
            {
                player1 = 7;
            }
            else if (player1 == 2)
            {
                player1 = 8;
            }
            else if (player1 == 3)
            {
                player1 = 9;
            }
            else if (player1 == 4)
            {
                player1 = 10;
            }
            else if (player1 == 5)
            {
                player1 = 11;
            }
            else if (player1 == 6)
            {
                player1 = 12;
            }
            else if (player1 == 97)
            {
                player1 = 75;
            }
            else if (player1 == 25)
            {
                player1 = 17;
            }
            else if (player1 == 31)
            {
                player1 = 4;
            }
            else if (player1 == 67)
            {
                player1 = 52;
            }
            else if (player1 == 47)
            {
                player1 = 24;
            }
            else if (player1 == 53)
            {
                player1 = 34;
            }
            return player1;
        }

        public int turunNaik2(int player2)
        {
            if (player2 == 1)
            {
                player2 = 7;
            }
            else if (player2 == 2)
            {
                player2 = 8;
            }
            else if (player2 == 3)
            {
                player2 = 9;
            }
            else if (player2 == 4)
            {
                player2 = 10;
            }
            else if (player2 == 5)
            {
                player2 = 11;
            }
            else if (player2 == 6)
            {
                player2 = 12;
            }
            else if (player2 == 97)
            {
                player2 = 75;
            }
            else if (player2 == 25)
            {
                player2 = 17;
            }
            else if (player2 == 31)
            {
                player2 = 4;
            }
            else if (player2 == 67)
            {
                player2 = 52;
            }
            else if (player2 == 47)
            {
                player2 = 24;
            }
            else if (player2 == 53)
            {
                player2 = 34;
            }
            return player2;
           
        }
        
    }
}
