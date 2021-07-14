using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> customers = new MyDictionary<int, string>();
            customers.Add(1,"Muhammed Uğur Koçak");
            customers.Add(2,"Ege Tosun");
            customers.Add(3, "Uğur Koçak");
            customers.ShowMyDictionaryList();

        }
    }
}
