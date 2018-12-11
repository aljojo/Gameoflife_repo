using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            Int64 world_width = 8;
            Int64 world_length = 8;
            Int64 num_steps = 1000;
            World world = new World( world_width, world_length);
            world.initialize_world_randomly();

            for(Int64 i=0; i<num_steps; i++)
            {
                world.Run_the_World_one_step();
            }
            //GraphicalDisplay graphics = new GraphicalDisplay();
            //Application.Run(graphics);
        }
    }
}


