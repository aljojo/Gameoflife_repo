using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Gameoflife
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Int64 world_width = 128;
            Int64 world_length = 128;
            Double timestep = 0.1;
            World world = new World( world_width, world_length, timestep);

            GraphicalDisplay graphics = new GraphicalDisplay();
            graphics.Show();
            //System.Threading.Thread.Sleep(5000);
        }
    }
}


