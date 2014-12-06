using System;

namespace tic_tac_toe
{
    class Program
    {
        public static int EMPTY = 0;
        public static int Xchar=1;
        public static int Ochar = 2;

        int[,] matrix = new int[3, 3];
        char[] sym = {' ','X','O' };
        void initialize_game()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = EMPTY;
        }
        void draw()
        {
            for (int i = 0; i < matrix.GetLength(0); i++){
                Console.WriteLine("{0}|{1}|{2}",
                    sym[matrix[i, 0]], 
                    sym[matrix[i, 1]], 
                    sym[matrix[i, 2]]);
                if (i!=2) Console.WriteLine("-|-|-");
            }
        }
        public void get_player_move()
        {
            Console.WriteLine("Enter X,Y coordinates for your move: ");
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            i--; j--;
            if (matrix[i, j] != EMPTY)
            {
                Console.WriteLine("invalid move");
                get_player_move();
            }
            else
                matrix[i, j] = Xchar;
        }
        public void get_computer_move()
        {
            Random r = new Random();
            int i, j;
            do
            {
                i = r.Next(0, 3);
                j = r.Next(0, 3);
            } while (matrix[i, j] != EMPTY);
            matrix[i, j] = Ochar;
        }

        public bool isThereAWinner(int p)
        {
            // all the rows 
            for (int i = 0; i < 3; i++ )
                if (matrix[i, 0] == p && matrix[i, 1] == p
                    && matrix[i, 2] == p)
                    return true;

            // all the cols
            for (int i = 0; i < 3; i++)
                if (matrix[0,i] == p && matrix[1,i] == p
                    && matrix[2,i] == p)
                    return true;

            if (matrix[0, 0] == p && matrix[1, 1] == p
                    && matrix[2, 2] == p)
                return true;

            if (matrix[0,2] == p && matrix[1, 1] == p
                    && matrix[2, 0] == p)
                return true;

            return false; 
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.initialize_game();
            p.draw();
            int winner = 0;
            do{
                p.get_player_move();
                if (p.isThereAWinner(Xchar))
                {
                    winner = Xchar; break; 
                }
                p.get_computer_move();
                if (p.isThereAWinner(Ochar))
                {
                    winner = Ochar; break;
                } 
                p.draw();
            }while(true);
            p.draw(); // final position 
            if (winner == Xchar)
                Console.WriteLine("congrats");
            else
                Console.WriteLine("sorry, but u lost");

            
        }
    }
}
