using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpy
{
    public class DEALS
    {
        public int Sum { get; set; }
        public string? Id { get; set; }
        public DateTime Date { get; set; }
        public static DEALS[]? GetNumberOfDeals(DEALS[]? deals)
        {
            return deals?
                .Where(s => s.Sum >= 100) // Filter for deals with at least 100 sum
                .OrderByDescending(s => s.Date).Take(5) // Sort by Sum in descending order
                                                        //.Take(5)
                .ToArray(); // Convert the result back to an array

        }
        public static DEALS[]? GetSumOfDealsByMonth(DEALS[]? deals)
        {
            return deals?
                .GroupBy(d => new { d.Date.Year, d.Date.Month })
                .Select(g => new DEALS
                {
                    Id = $"{g.Key.Year}-{g.Key.Month}", // Creating a unique Id for the monthly summary
                    Sum = g.Sum(d => d.Sum),
                    Date = new DateTime(g.Key.Year, g.Key.Month, 1) // Set the DateTime to the first day of the month
                })
                .OrderBy(deal => deal.Date) // Order by DateTime
                .ToArray(); // Convert to array
        }

        public static void dealprinter(DEALS[]? deals)
        {
            if (deals != null)
            {
                for (int i = 0; i < deals.Length; i++)
                {
                    System.Console.WriteLine("Sum: " + deals[i].Sum + " Id: " + deals[i].Id + " Date: " + deals[i].Date);
                }
            }
        }
    }
}
