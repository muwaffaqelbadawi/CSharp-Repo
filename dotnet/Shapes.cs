

namespace dotnet // Note: actual namespace depends on the (project name).
{
    class Shapes // File name
    {
        public void Z_Shape(int row)
        {
            Console.WriteLine("this is a class funcion\n");

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (i == 1 || i == row || j == (row + 1) - i)
                    {
                        Console.Write("*");

                    } else {

                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void Square(int row)
        {
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (i == 1 || j == 1 || j == row || i == row)
                    {
                        Console.Write("*");
                    
                    } else {
                        
                        Console.Write(" ");
                         
                    }
                }
                Console.WriteLine();
            }
        }
    }
}