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
            var list = new List<int>(); //требует вызова System.Collections.Generic //не вызова, а инициализации
            AddNumbers(list); //Это не сработает, если AddNumbers будет не static, либо 
                              //класс Program не будет обьявлен явно потому, что ты обращаешься явно
                              //к статическому методу без инициализации класса
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
        public static void AddNumbers(List<int> numbers) // делаем метод, принимающий лист интов 
                                                         //"принимающий", но нигде нет конструкции, которая
                                                         //передает на вход этого метода лист интов.
                                                         //См. строку 14
        {
            numbers.Add(1);
            numbers.Add(5);
            numbers.Add(10);
        }
    }
}
