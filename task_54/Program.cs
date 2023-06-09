// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


int[,] myArr = {
      {1,4,7,2},
      {5,9,2,3},
      {8,4,2,4},
};



void PrintMatrix(int[,] myArr)
            
  {
               
    for (int i = 0; i < myArr.GetLength(0); i++)

      {

        for (int j = 0; j < myArr.GetLength(1); j++)

        {
                     
          System.Console.Write($"{myArr[i, j]} " + "\t");

        }
              
              System.Console.WriteLine();

      }

  }

void SortPosition(int[,] myArr)

{

   for (int i = 0; i < myArr.GetLength(0); i++)

  {

    for (int j = 0; j < myArr.GetLength(1)-1; j++)

      {  
            
        int maxPosition = j;
                             
          for (int x = j + 1; x < myArr.GetLength(1); x++)
    
            {

              if (myArr[i,x] > myArr[i,maxPosition]) maxPosition = x;

            }
              
              int temporary = myArr[i,j];

              myArr[i,j] = myArr[i,maxPosition];

              myArr[i,maxPosition] = temporary;

      }

  }

}    

PrintMatrix(myArr); 

System.Console.WriteLine();
             
SortPosition(myArr);

PrintMatrix(myArr);
           