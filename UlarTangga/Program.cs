using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace UlarTangga
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stat = true;
            while (true)
            {

                Console.Write("Mulai? (y/n) : ");
                string mulai = Console.ReadLine();
                if (mulai.ToLower() == "n")
                {
                    break;
                }
                int player = 0;
                acakPlayer acakp = new acakPlayer();
                player = acakp.GeneratePlayer();

                Console.WriteLine();
                Console.WriteLine("Pemain Yang Dapat Giliran Pertama Adalah Player : " + player);
                Console.WriteLine();

                UlarDanTangga l = new UlarDanTangga();
                l.legend();

                int player1 = 0;
                int player2 = 0;
                Console.WriteLine("Tekan Enter untuk lempar dadu");
                ;
                while (player1 < 100 || player2 < 100)
                {

                    if (player == 1)
                    {

                        Console.ReadKey();
                        int tempNumber = 0;

                        acakDadu acak = new acakDadu();
                        tempNumber = acak.GenerateDice();

                        player1 = player1 + tempNumber;
                        UlarDanTangga ulartangga = new UlarDanTangga();
                        player1 = ulartangga.turunNaik1(player1);

                        if (player1 > 100)
                        {
                            player1 = player1 - 100;
                            player1 = 100 - player1;
                        }

                        if (player2 > 100)
                        {
                            player2 = player2 - 100;
                            player2 = 100 - player2;
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Posisi Player 1 : " + player1);
                        Console.WriteLine("Posisi Player 2 : " + player2);

                        if (player1 == 100)
                        {
                            Console.WriteLine("Player 1 Won");
                            return;
                            stat = false;
                        }

                        player = 2;
                    }
                    else if (player == 2)
                    {

                        Console.ReadKey();
                        int tempNumber = 0;

                        acakDadu acak = new acakDadu();
                        tempNumber = acak.GenerateDice();

                        player2 = player2 + tempNumber;
                        UlarDanTangga ulartangga = new UlarDanTangga();
                        player2 = ulartangga.turunNaik2(player2);

                        if (player1 > 100)
                        {
                            player1 = player1 - 100;
                            player1 = 100 - player1;
                        }

                        if (player2 > 100)
                        {
                            player2 = player2 - 100;
                            player2 = 100 - player2;
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Posisi Player 1 : " + player1);
                        Console.WriteLine("Posisi Player 2 : " + player2);

                        if (player2 == 100)
                        {
                            Console.WriteLine("Player 2 Won");
                            return;
                            stat = false;
                            
                        }
                        player = 1;
                    }

                }
            }
        }



    }
}