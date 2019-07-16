using System;
using System.Collections.Generic;
using System.Diagnostics;
using FunMultipleOfFiveAndNine;

namespace MultipleOfFiveAndNine
{
    public class Program
    {
        private static int top = 100000000;
        private static IEnumerable<int> listOfNumbers = NaturalNumber.LessEqualThen(top);
        private static Stopwatch stopWatch = new Stopwatch();
        static void Main(string[] args)
        {
            stopWatch.Start();
            Console.WriteLine($"Calculate the sum of first multiples of 5 and 9 less equal then {top}. Sum: {listOfNumbers.SumOfFiveORNineMultipliers()}");
            stopWatch.Stop();
            Console.WriteLine($"Time Elapsed: {stopWatch.Elapsed.Format()}");

            stopWatch.Restart();
            Console.WriteLine($"Functional list calculate the sum of first multiples of 5 and 9 less equal then {top}. Sum: { MultiplesOf5And9.CalculateSumList(top)}");
            stopWatch.Stop();
            Console.WriteLine($"Time Elapsed: {stopWatch.Elapsed.Format()}");

            stopWatch.Restart();
            Console.WriteLine($"Functional seq calculate the sum of first multiples of 5 and 9 less equal then {top}. Sum: { MultiplesOf5And9.CalculateSumSeq(top)}");
            stopWatch.Stop();
            Console.WriteLine($"Time Elapsed: {stopWatch.Elapsed.Format()}");

            stopWatch.Restart();
            Console.WriteLine($"Functional optimized seq calculate the sum of first multiples of 5 and 9 less equal then {top}. Sum: { MultiplesOf5And9.CalculateSumSeq(top)}");
            stopWatch.Stop();
            Console.WriteLine($"Time Elapsed: {stopWatch.Elapsed.Format()}");

            stopWatch.Restart();
            Console.WriteLine($"Calculate with slow method the sum of first multiples of 5 and 9 less equal then {top}. Sum: {listOfNumbers.SumOfFiveORNineMultipliersSlow()}");
            stopWatch.Stop();
            Console.WriteLine($"Time Elapsed: {stopWatch.Elapsed.Format()}");

            stopWatch.Restart();
            Console.WriteLine($"Calculate optimized the sum of first multiples of 5 and 9 less then {top}. Sum: {listOfNumbers.SumOfFiveORNineMultipliersOptimized()}");
            stopWatch.Stop();
            Console.WriteLine($"Time Elapsed: {stopWatch.Elapsed.Format()}");
            Console.ReadKey(true);
        }
    }
}
