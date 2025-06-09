using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using static csharpy.FACTORY;
using static csharpy.TANK;
using static csharpy.UNIT;

namespace csharpy
{
    class Program
    {
        static void Main(string[] args)
        {
            READER.LoadTanksFromJson("tanks.json");            
            lab1();
            lab2();

        }
        static void lab2()
        {
            System.Console.WriteLine("list of all deals: ");
            DEALS[]? deals = READER.LoadDealsFromJson("JSON_sample_1.json");
            System.Console.WriteLine("list of 5 first deals sorted by date with at least 100 sum:");
            DEALS[]? sorted_deals = DEALS.GetNumberOfDeals(deals);
            DEALS.dealprinter(sorted_deals);

            System.Console.WriteLine("sum of deals sorted by month: ");
            DEALS[]? dealsbymonth = DEALS.GetSumOfDealsByMonth(deals);
            DEALS.dealprinter(dealsbymonth);
        }
        static void lab1()
        {
            
            var tanks = GetTanks();//экземпляры классов
            var factories = GetFactories();
            var units = GetUnits();
            // вывод всех резервуаров
            Console.WriteLine("Список резервуаров:");
            foreach (var tank in tanks)
            {
                var unit = units.FirstOrDefault(u => u.Id == tank.UnitId);
                var factory = factories.FirstOrDefault(f => f.Id == unit?.Id);
                Console.WriteLine($"Резервуар: {tank.Name}, Описание: {tank.Description}, " +
                                    $"Цех: {unit?.Name}, Фабрика: {factory?.Name}");
            }

            // общ сумма
            var totalVolume = GetTotalVolume(tanks);
            Console.WriteLine($"\nОбщая сумма загрузки всех резервуаров: {totalVolume}");

            // резервуар по имени
            Console.WriteLine("\nВведите название резервуара для поиска:");
            string? searchName = Console.ReadLine();
            var foundTank = FindTankByName(tanks, searchName);
            if (foundTank != null)
            {
                var unit = units.FirstOrDefault(u => u.Id == foundTank.UnitId);
                var factory = factories.FirstOrDefault(f => f.Id == unit?.Id);
                Console.WriteLine($"Найденный резервуар: {foundTank.Name}, Описание: {foundTank.Description}, " +
                                    $"Цех: {unit?.Name}, Фабрика: {factory?.Name}");
            }
            else
            {
                Console.WriteLine("Резервуар не найден.");
            }

        }

    }
}