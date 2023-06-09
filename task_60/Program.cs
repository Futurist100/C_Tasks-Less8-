// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)



int[] main = new int[100];

for ( int i = 0; i < 100; i++)

    main[i] = i;


System.Console.WriteLine("Введите количество строк  ");
int str = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов  ");
int col = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество станиц ");
int page = Convert.ToInt32(Console.ReadLine());

int[,,] arr = new int[str,col,page];

Random rnd = new Random();

int temp = 0; 

for (int x = 0; x < str; x++)
   {


        for (int y = 0; y < col; y++)

            {
             
                for (int z = 0; z < page; z++)

                    {
                     temp = main[rnd.Next(0, 100)];
                    if (temp !=-1)
                    {

                    arr[x, y, z] = temp; main[rnd.Next(0, 100)]= -1;
                    
                    }

                }

            }

    }                    

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            Console.Write($"{arr[i, j, k]} ({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
   
}

                     