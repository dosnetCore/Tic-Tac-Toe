using System;

namespace XO_Telos
{
    class Program
    {
        static void Main(string[] args)
        {
            while ( XOBoard.numOfTurns <= 9)
            {
                XOBoard.Display();
                string sts = XOBoard.Status(XOBoard.numOfTurns);
                if(sts == XOBoard.flag)
                {
                    Console.WriteLine($"\n            {XOBoard.flag} WON !!!\n");
                    break;
                }
                else if(sts == "None")
                {
                    Console.WriteLine($"\n     State of board: {sts}\n");
                }
                else if(sts == "Draw")
                {
                    Console.WriteLine($"\n     State of board: {sts}\n");
                    break;
                }
                XOBoard.Put();
                XOBoard.numOfTurns++;
            }

        }
    }
}
