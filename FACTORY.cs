using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpy
{
    public class FACTORY
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public static FACTORY[] GetFactories()
        {
            return new FACTORY[]
            {
                new FACTORY { Id = 1, Name = "NPZ1", Description = "Первый завод" },
                new FACTORY { Id = 2, Name = "NPZ2", Description = "Второй завод" }
            };
        }
    }
}
