using SQLiteSample2.Data.Entity;
using SQLiteSample2.DataAccess.Helper;
using System;
using System.Linq;

namespace SQLiteSample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tableName = "firstTable";
            tableName.CreateTable();
            tableName.Add(new KeyValueModel() { Key = "First", Value = "Record" });
            Console.WriteLine(tableName.Get("First"));
            foreach (var item in tableName.Get())
                Console.WriteLine(item);

            var model = tableName.Get().First();
            model.Value = "Recorded";
            tableName.Update(model);
            Console.WriteLine(tableName.Get("First"));
            foreach (var item in tableName.Get())
                Console.WriteLine(item);

            tableName.Delete(model.Key);
            foreach (var item in tableName.Get())
                Console.WriteLine(item);

            Console.Read();
        }
    }
}
