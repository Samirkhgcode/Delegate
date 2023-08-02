using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class PracticeDelegate
    {
        public delegate bool CheckNums(int num);


        //public bool CheckEventNums(int number)
        //{
        //    return number % 2 == 0;
        //}

        //public bool CheckGreaterFiveNums(int number)
        //{
        //    return number >5;
        //}

        public bool CheckOddNums(int number)
        {
            return number % 2 == 1;
        }

        public void ExecuteMethod()
        {
            SumNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12, 927, 932, }, CheckOddNums);
            //SumOfEvenNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12, 927, 932, }, CheckOddNums);
            // SumOfEvenNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12,927, 932 }, CheckEventNums);
            //SumOfEvenNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12, 927, 932 }, CheckGreaterFiveNums);
        }



        private void SumNumbers(List<int> numbers, Predicate<int> func)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                if (func(number))
                {
                    sum += number;
                }
            }


            //private void SumOfEvenNumbers(List<int> numbers, Func<int, bool> checkOddNums)
            //{
            //    int sum = 0;

            //    foreach (int number in numbers)
            //    {
            //        if (number % 2 == 0)
            //        {
            //            sum += number;
            //        }
            //    }



                //private void SumOddNumbers(List<int> numbers,  Predicate<int>func)                
                //{
                //    int sum = 0;

                //    foreach (int number in numbers)
                //    {
                //        if (number %2 == 1)
                //        {
                //            sum += number;
                //        }
                //    }

                //    Console.WriteLine(sum);
                //}



                //private void SumOfGreaterFourNambers(List<int> numbers)
                //{
                //    int sum = 0;

                //    foreach (int number in numbers)
                //    {
                //        if (number > 4)
                //        {
                //            sum += number;
                //        }
                //    }

                //    Console.WriteLine(sum);
                //}

            }

        }
    }

        

  