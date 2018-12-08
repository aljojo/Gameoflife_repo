using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameoflife
{
    class World
    {
        private Int64 width;
        private Int64 length;
        private Double time_per_evolution_step;
        private Cell[,] cell_population;

        public World(Int64 wid, Int64 len, Double timestep)
        {
            width = wid;
            length = len;
            time_per_evolution_step = timestep;

            cell_population = new Cell[wid, len];
        }
    }
}
