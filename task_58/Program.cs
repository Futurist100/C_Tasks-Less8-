// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] myArrOne = {
      {2,4},
      {3,2},
};

int[,] myArrTwo = {
      {3,4},
      {3,3},
};

int[,] mult = new int [myArrOne.GetLength(0),myArrTwo.GetLength(1)];

for (int i = 0; i < myArrOne.GetLength(0); i++)

  {
                
      for (int j = 0; j < myArrOne.GetLength(1); j++)

         {
                    
            for (int k = 0; k < myArrTwo.GetLength(0); k++)

                {

                  mult[i,j] += myArrOne[i,k] * myArrTwo[k,j];

                }

                  Console.Write($"{mult[i,j]}  ");   
                             
         }
            
             Console.WriteLine();
  }



