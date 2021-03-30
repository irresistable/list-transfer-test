using System;
using System.Collections.Generic;

namespace list_transfer_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>(); //требует вызова System.Collections.Generic //list ссылается на память для экземпляра листа
            Addition testex = new Addition();
            testex.AddNumbers(list);
            AddNumbers_static(list);
            //Addition_abstract(list); не работает так

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
        public class Addition
        {
            public void AddNumbers(List<int> numbers) // делаем метод, принимающий лист интов.  numbers ссылается на list
            {
                numbers.Add(1);
                numbers.Add(5);
                numbers.Add(10);
            }
        }
        abstract class Addition_abstract
        {
            public void AddInAbstract(List<int> numbers) // делаем метод, принимающий лист интов.  numbers ссылается на list
            {
                numbers.Add(1);
                numbers.Add(5);
                numbers.Add(10);
            }
        }
        static void AddNumbers_static(List<int> numbers) // делаем метод, принимающий лист интов.  numbers ссылается на list
            {
                numbers.Add(1);
                numbers.Add(5);
                numbers.Add(10);
            }
        
    }
}
