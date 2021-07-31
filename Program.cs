using System;

namespace SingletonDemo
{
    class Program
    {

        static void Main(string[] args)
        {

            var db = SingletonDataContainer.Instance;
            Console.WriteLine(db.GetPopulation("Sofia"));
            
            var db2 = SingletonDataContainer.Instance;
            Console.WriteLine(db2.GetPopulation("Buchrest"));

            //var db3 = SingletonDataContainer.Instance;
            //var db4 = SingletonDataContainer.Instance;

        }
    }
}
