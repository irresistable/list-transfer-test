using System;
using System.Collections.Generic;

namespace list_transfer_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>(); //требует вызова System.Collections.Generic
            //AddNumbers numbers = new AddNumbers(list);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
        public void AddNumbers(List<int> numbers) // делаем метод, принимающий лист интов 
        {
            numbers.Add(1);
            numbers.Add(5);
            numbers.Add(10);
        }
    }
}
