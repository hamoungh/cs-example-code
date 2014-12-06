using System;


class Program
{
    static int EMPTY = 0;
    static int X = 1;
    static int O = 2;
    static int NO_WINNER=0;
    static int PLAYER_WINNER = 1;
    static int COMPUTER_WINNER = 2;
    static int DRAW = 3;

    char[] shapes={' ','X','O'};
    int[,] matrix = new int[3, 3];

    void initialize_game()
    {
        for (int i = 0; i < matrix.GetLength(0); i++ )
            for (int j = 0; j < matrix.GetLength(1); j++  )
                matrix[i, j] = EMPTY;
    }
    void draw()
    {
        for (int i = 0; i < 3;i++ )
        {
            Console.WriteLine("{0}|{1}|{2}",
                shapes[matrix[i,0]], 
                shapes[matrix[i,1]], 
                shapes[matrix[i,2]]);
            if (i!=2) Console.WriteLine("-|-|-");
        }
    }
    void get_computer_move()
    {
        // search for the first empty cell and put an O there\
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (matrix[i, j] == EMPTY)
                {
                    matrix[i, j] = O;
                    return; 
                }
    }
    void get_player_move()
    {
        Console.WriteLine("Enter X,Y coordinates for your move: ");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        x--; y--;
        if (x>=0 && x<=2 && y>=0 && y<=2 &&
            matrix[x, y] == EMPTY)
            matrix[x, y] = X;
        else
        {
            Console.Write("Invalid Move!");
            get_player_move();
        }
    }

    int isThereAWinner(){
      //  NO_WINNER,  PLAYER_WINNER 
    // COMPUTER_WINNER, DRAW 
        for (int i = 0; i < 3; i++)
            if (matrix[i, 0] == X && matrix[i, 1] == X &&
                matrix[i, 2] == X)
                return PLAYER_WINNER;

        for (int i = 0; i < 3; i++)
            if (matrix[0, i] == X && matrix[1, i] == X &&
                matrix[2, i] == X)
                return PLAYER_WINNER;

        if (matrix[0, 0] == X && matrix[1, 1] == X &&
                matrix[2, 2] == X) return PLAYER_WINNER;

        if (matrix[0, 2] == X && matrix[1, 1] == X &&
                matrix[2, 0] == X) return PLAYER_WINNER;

        return NO_WINNER; 
    }
    static void Main(string[] args)
    {
        Program p = new Program();
        p.initialize_game();
        int status=0;
        do{
            p.draw();
            p.get_player_move();
            status = p.isThereAWinner();
            if (status != NO_WINNER) break;
            p.get_computer_move();
            status = p.isThereAWinner();
            if (status != NO_WINNER) break;
        }while(true);
        p.draw(); // display final position 
        if (status == PLAYER_WINNER) 
            Console.WriteLine("congrats");
        else if (status ==COMPUTER_WINNER)
            Console.WriteLine("looser");
    }
}

