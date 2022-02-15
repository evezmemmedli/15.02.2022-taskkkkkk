using System;

namespace _15._02._2022_taskkkkkk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 96, 85, 83, 96, 58, 79 };
            int telebelerinSayi = 0;
            int ballarinCemi = 0;
            int edediOrta = 0;

            ballarinCemi = SumOfTotalPoints(arr, ref telebelerinSayi);
            Console.WriteLine(telebelerinSayi);
            Console.WriteLine(ballarinCemi);
            edediOrta = AvarageOfTotalPoints(ballarinCemi, telebelerinSayi);
            Console.WriteLine(edediOrta);

        }
        public static int SumOfTotalPoints(int[] array, ref int studentsCount)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                studentsCount++;
            }
            return sum;

        }
        public static int AvarageOfTotalPoints(int ballarinCemi, int telebelerinSayi)
        {
            int edediOrta = 0;
            edediOrta = ballarinCemi / telebelerinSayi;

            return edediOrta;
        }
    }
}
