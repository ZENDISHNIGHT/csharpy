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
                .Where(s => s.Sum >= 1000) 
                .OrderBy(s => s.Date).Take(4) 
                                                        
                .ToArray(); 

        }
        public static DEALS[]? GetSumOfDealsByMonth(DEALS[]? deals)
        {
            return deals?
                .GroupBy(d => new { d.Date.Year, d.Date.Month })
                .Select(g => new DEALS
                {
                    Id = $"{g.Key.Year}-{g.Key.Month}", 
                    Sum = g.Sum(d => d.Sum),
                    Date = new DateTime(g.Key.Year, g.Key.Month, 1) 
                })
                .OrderBy(deal => deal.Date) 
                .ToArray(); 
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
