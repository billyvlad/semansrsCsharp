// двумерные массивы 
//string[,] table = new string[2,3]
//int[,] matrix = new int[5,8]

//String.Empty

//string[,] table = new string[2, 5];
//table[1, 2] = "word";

//for (int rows = 0; rows < 2; rows++)
//{
//    for (int columns = 0; columns < 5; columns++)
//    {
//        Console.WriteLine($"-{table[rows, columns]}-");
//    }
//}


int[,] matrix = new int[3, 4];
void PrintArray(int[,] matr)
{
for (int rows = 0; rows < 3; rows++)    // or rows < matrix.GetLength(0) - что бы передать 3 из условия
    {
    for (int i = 0; i < 4; i++)         // or i < matrix.GetLength(1) - что бы передать 4 из условия
        {   
            Console.Write($"-{matrix[rows, i]}-");
        }
        Console.WriteLine();
    }
}

PrintArray(matrix);
