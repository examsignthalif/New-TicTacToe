using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTicTacToe
{
    class Program
    {
        static public string[] PlayBoard = new string[9] { "_", "_", "_", "_", "_", "_", "_", "_", "_" };
        static public List<int> PlayerHit = new List<int>();
        static bool Player1 = true;
        static bool Player2 = false;
        static void Main(string[] args)
        {
            LoadBoard();
            GameStart();
        }

        static public void LoadBoard()
        {
            Console.Write("\n");
            for (int i = 0; i < PlayBoard.Length; i++)
            {
                Console.Write(PlayBoard[i] + "\t");
                if (i == 2 || i == 5 || i == 8)
                    Console.Write("\n\n");
            }
        }

        static public int Player1Input()
        {
            string a = Console.ReadLine();
            int input = int.Parse(a);

            if (!PlayerHit.Contains(input))
            {
                PlayerHit.Add(input);
                PlayBoard[input - 1] = "X";
                LoadBoard();
                Player1 = false;
                Player2 = true;
                return 0;
            }
            else
                return 1;
        }
        static public int Player2Input()
        {
            string a = Console.ReadLine();
            int input = int.Parse(a);

            if (!PlayerHit.Contains(input))
            {
                PlayerHit.Add(input);
                PlayBoard[input - 1] = "O";
                LoadBoard();
                Player1 = true;
                Player2 = false;
                return 0;
            }
            else
                return 1;
        }

        static public void GameStart()
        {
            for (int i = 0; i < 9; i++)
            {
                if (Player1)
                    i -= Player1Input();
                else if (Player2)
                    i -= Player2Input();
            }
        }

        static public void ValidationProcess()
        {

        }

        static public void LeftVerticalCheck(string[] arr) 
        {
            string v1 = arr[0];
            string v2 = arr[3];
            string v3 = arr[6];
            if(v1 == v2 && v2 == v3)
            {
                Console.WriteLine("LV Matched");
            }
        }

        static public void RightVerticalCheck(string[] arr)
        {
            string v1 = arr[2];
            string v2 = arr[5];
            string v3 = arr[8];
            if (v1 == v2 && v2 == v3)
            {
                Console.WriteLine("RV Matched");
            }
        }
        static public void MiddleVerticalCheck(string[] arr)
        {
            string v1 = arr[1];
            string v2 = arr[4];
            string v3 = arr[7];
            if (v1 == v2 && v2 == v3)
            {
                Console.WriteLine("MV Matched");
            }
        }

        static public void TopHorizontalCheck(string[] arr)
        {
            string v1 = arr[0];
            string v2 = arr[1];
            string v3 = arr[2];
            if (v1 == v2 && v2 == v3)
            {
                Console.WriteLine("TH Matched");
            }
        }
        static public void MiddleHorizontalCheck(string[] arr)
        {
            string v1 = arr[3];
            string v2 = arr[4];
            string v3 = arr[5];
            if (v1 == v2 && v2 == v3)
            {
                Console.WriteLine("MH Matched");
            }
        }
        static public void BottomHorizontalCheck(string[] arr)
        {
            string v1 = arr[6];
            string v2 = arr[7];
            string v3 = arr[8];
            if (v1 == v2 && v2 == v3)
            {
                Console.WriteLine("BH Matched");
            }
        }

        static public void LeftToRightDiagnol(string[] arr)
        {
            string v1 = arr[0];
            string v2 = arr[4];
            string v3 = arr[8];
            if (v1 == v2 && v2 == v3)
            {
                Console.WriteLine("LRD Matched");
            }
        }

        static public void RightToLeftDiagnol(string[] arr)
        {
            string v1 = arr[0];
            string v2 = arr[4];
            string v3 = arr[8];
            if (v1 == v2 && v2 == v3)
            {
                Console.WriteLine("RLD Matched");
            }
        }
    }
}
