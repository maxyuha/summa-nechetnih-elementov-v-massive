using System;

namespace ConsolleApp
{
     class Program
     {
        static void Main(string[] args)
        {
            void Zadacha36()
            {//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            int[] array=new int[8] ; 
             FillArray(array,0,10);
             PrintArray(array);

             int sum=0;
             for(int i=0;i<array.Length;i++)
             {
                if(i%2==0)sum+=array[i];
                     
             }
             Console.WriteLine("Сумма элементов на нечетных позициях равна "+sum);
                
            }
            void FillArray(int[] array,int StartNumber=0,int FinishNumber=1)
            {
                FinishNumber++;
                Random random=new Random();
                for (int i=0;i<array.Length;i++)
                {
                    array[i]=random.Next(StartNumber,FinishNumber);
                }
            }
            void PrintArray(int[] array)
            {
                Console.WriteLine("массив");
                for(int i=0;i<array.Length;i++)
                {
                    Console.WriteLine(array[i]+"\t");
                }
                Console.WriteLine();
            }
            Zadacha36();
        }
        
     }
    
}