using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace csharpy
{
     internal class READER
    {
        public static TANK[]? LoadTanksFromJson(string filePath)
        {
            string jsonFilePath = "tanks.json";

            // Read JSON from file
            string jsonString = File.ReadAllText(jsonFilePath);

            // Deserialize JSON into an array of tank objects
            TANK[]? tanks = JsonSerializer.Deserialize<TANK[]>(jsonString);

            // Output the deserialized data
            if (tanks != null)
            {
                for (int i = 0; i < tanks.Length; i++)
                {
                    Console.WriteLine($"Id: {tanks[i].Id}, Name: {tanks[i].Name}, Description: {tanks[i].Description}, Volume:{tanks[i].Volume}, MaxVolume: {tanks[i].MaxVolume}, UnitId: {tanks[i].UnitId} ");
                }
            }

            return tanks;
        }
        public static DEALS[]? LoadDealsFromJson(string filePath)
        {
            string jsonFilePath = "JSON_sample_1.json";

            // Read JSON from file
            string jsonString = File.ReadAllText(jsonFilePath);

            // Deserialize JSON into an array of tank objects
            DEALS[]? deals = JsonSerializer.Deserialize<DEALS[]>(jsonString);

            // Output the deserialized data
            /*foreach (var deal in deals)
            {
                Console.WriteLine($"Sum: {deal.Sum}, Id: {deal.Id}, Date: {deal.Date} ");
            }*/
            if (deals != null)
            {
                for (int i = 0; i < deals.Length; i++)
                {
                    Console.WriteLine($"Sum: {deals[i].Sum}, Id: {deals[i].Id}, Date: {deals[i].Date} ");
                }
            }

            return deals;
        }
    }
}
