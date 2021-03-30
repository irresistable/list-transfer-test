using System;
using System.Collections.Generic;

namespace list_transfer_test
{
    
    //Делать все в рамках одного класса - не верно, так получается путаница что ты
    //дергаешь один метод из другого
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>(); //требует вызова System.Collections.Generic
            AddNumbers(list);
            AddClass addclass = new AddClass();
            //AddAbstractClass. ?
            addclass.AddNumbers(list);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
        static void AddNumbers(List<int> numbers) // делаем метод, принимающий лист интов 
        {
            numbers.Add(1);
            numbers.Add(5);
            numbers.Add(10);
        }
        public class AddClass
        {
            public void AddNumbers(List<int> numbers) // делаем метод, принимающий лист интов 
            {
                numbers.Add(1);
                numbers.Add(5);
                numbers.Add(10);
            }
        }
        public abstract class AddAbstractClass
        {
            public void AddNumbers(List<int> numbers) // делаем метод, принимающий лист интов 
            {
                numbers.Add(1);
                numbers.Add(5);
                numbers.Add(10);
            }
        }

    }
}
