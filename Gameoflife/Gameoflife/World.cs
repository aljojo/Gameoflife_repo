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
        private Cell[,] cell_population;

        public World(Int64 wid, Int64 len)
        {
            width = wid;
            length = len;

            cell_population = new Cell[wid, len];
            for (Int64 i = 0; i < width; i++)
            {
                for (Int64 j = 0; j < length; j++)
                {
                    cell_population[i, j] = new Cell();
                }
            }
        }

        public void initialize_world_randomly()
        {
            Random random = new Random();
            Int64 r = 0;
            for (Int64 i = 0; i < width; i++)
            {
                for (Int64 j = 0; j < length; j++)
                {
                    r = random.Next(0, 2);
                    if (r == 1)
                    {
                        cell_population[i, j].set_cell_to_be_alive(true);
                    }
                }
            }
            update_world();
        }

        public void Run_the_World_one_step()
        {
            for (Int64 i = 0; i < width; i++)
            {
                for (Int64 j = 0; j < length; j++)
                {
                    Int64 num_neighbourcells_alive = Get_number_of_alive_neighbour_cells(i, j);
                    Apply_evolution_rules_to_cell(cell_population[i, j], num_neighbourcells_alive);
                }
            }
            update_world();
        }

        public Int64 Get_number_of_alive_neighbour_cells(Int64 i, Int64 j)
        {
            Int64 Num_alive_cells = 0;
            for (Int64 i_neighbour = -1; i_neighbour <= 1; i_neighbour++)
            {
                for (Int64 j_neighbour = -1; j_neighbour <= 1; j_neighbour++)
                {
                    if(isinsideworld(i + i_neighbour, j + j_neighbour) && i_neighbour!=0 && j_neighbour!=0){
                        if(cell_population[i+i_neighbour, j + j_neighbour].is_cell_alive_now())
                        {
                            Num_alive_cells++;
                        }
                    }
                }    
            }
            return Num_alive_cells;
        }

        private Boolean isinsideworld(Int64 i, Int64 j)
        {
            Boolean isinside_width = i > -1 && i < width;
            Boolean isinside_length = j > -1 && j < length;
            return (isinside_width && isinside_length);
        }

        private void Apply_evolution_rules_to_cell(Cell cell, Int64 num_neighbourcells_alive)
        {
            if (cell.is_cell_alive_now())
            {
                if (num_neighbourcells_alive < 2)
                {
                    cell.set_cell_to_be_alive(false);
                }
                if (num_neighbourcells_alive >= 2 && num_neighbourcells_alive <= 3)
                {
                    cell.set_cell_to_be_alive(true);
                }
                if (num_neighbourcells_alive > 3)
                {
                    cell.set_cell_to_be_alive(false);
                }
            }
            else
            {
                if (num_neighbourcells_alive == 3)
                {
                    cell.set_cell_to_be_alive(true);
                }
                else
                {
                    cell.set_cell_to_be_alive(false);
                }
            }
        }

        private void update_world()
        {
            for (Int64 i = 0; i < width; i++)
            {
                for (Int64 j = 0; j < length; j++)
                {
                    cell_population[i, j].update_cell_status();
                }
            }
        }
    }
}
