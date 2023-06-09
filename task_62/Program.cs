// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] myArr)
            
  {
               
    for (int i = 0; i < myArr.GetLength(0); i++)

      {

        for (int j = 0; j < myArr.GetLength(1); j++)

        {
                     
          System.Console.Write($"{myArr[i, j]} " + "\t");

        }
              
              System.Console.WriteLine();

              System.Console.WriteLine();

      }

  }
      
System.Console.WriteLine("Введите количество элементов ребра массива  ");

int str = Convert.ToInt32(Console.ReadLine());

int col = str;


    int[,] myArr = new int[str,col];
    
    int i = 0;

     int j = 0;

       int count = 1;

        int stepI = 0;

          int stopI = 0;

           int stepJ = 0;

             int stopJ = 0;
    

    while (count  <= str*col)
    {
        myArr[i,j] = count ;

        if (i == stepI && j < str - stopJ - 1) ++j;

        else if (j == str - stopJ - 1 && i < col - stopI - 1) ++i;
        
        else if (i == col - stopI - 1 && j > stepJ) --j;
        
        else
            --i;

        if ((i == stepI + 1) && (j == stepJ) && (stepJ != 4 - stopJ - 1))
        {
            ++stepI;

            ++stopI;

            ++stepJ;

            ++stopJ;
        }
        
        ++count;
    }
    
    PrintMatrix(myArr);
