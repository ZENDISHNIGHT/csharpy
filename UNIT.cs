using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpy
{
    public class UNIT
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public static UNIT[] GetUnits()
        {
            return new UNIT[]
            {
            new UNIT { Id = 1, Name = "ГФУ1", Description = "Газофракц уст" },
            new UNIT { Id = 1, Name = "АВТ6", Description = "Атмосвак трубч" },
            new UNIT { Id = 2, Name = "АВТ10", Description = "Атмосвак трубч" }
            };
        }
    }
}
