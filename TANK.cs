using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpy
{
    public class TANK
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Volume { get; set; }
        public int MaxVolume { get; set; }
        public int UnitId { get; set; }

        public static TANK[] GetTanks()
        {
            return new TANK[]
            {
                new TANK { Id = 1, Name = "RES1", Description = "Надземный - вертикальный", Volume = 1500, MaxVolume = 2000, UnitId = 1 },
                new TANK { Id = 2, Name = "RES2", Description = "Надземный - горизотальный", Volume = 2500, MaxVolume = 3000, UnitId = 1 },
                new TANK { Id = 3, Name = "EXTRARES24", Description = "Надземный - горизонтальный", Volume = 3000, MaxVolume = 3000, UnitId = 2 },
                 new TANK { Id = 4, Name = "RES35", Description = "Надземный - вертикальный", Volume = 3000, MaxVolume = 3500, UnitId = 2 },
                  new TANK { Id = 5, Name = "RES47", Description = "Подземный - двустенный", Volume = 2000, MaxVolume = 2000, UnitId = 2 },
                   new TANK { Id = 6, Name = "RES256", Description = "Подводный", Volume = 100, MaxVolume = 100, UnitId = 3 }
            };
        }
        public static TANK? FindTankByName(TANK[] tanks, string? name)
        {
            TANK specific_tank = new TANK { };
            for (int i = 0; i < tanks.Length; i++)
            {
                if (tanks[i].Name == name)
                {
                    specific_tank.Description = tanks[i].Description;
                    specific_tank.Id = tanks[i].Id;
                    specific_tank.MaxVolume = tanks[i].MaxVolume;
                    specific_tank.Name = tanks[i].Name;
                    specific_tank.UnitId = tanks[i].UnitId;
                    specific_tank.Volume = tanks[i].Volume;
                    return specific_tank;
                }
            }

            return null;
        }
        public static int GetTotalVolume(TANK[] tanks)
        {
            int totalVolume = 0;
            for (int i = 0; i < tanks.Length; i++)
            {
                totalVolume += tanks[i].Volume;
            }
            return totalVolume;
        }
    }
}
