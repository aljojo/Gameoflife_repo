using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameoflife
{
    class Cell
    {
        private Boolean isalive;
        private Boolean willbealive;

        public Cell()
        {
            isalive = false;
            willbealive = false;
        }

        public Boolean is_cell_alive_now()
        {
            return isalive;
        }

        public void set_cell_to_be_alive(Boolean yes_set_to_alive)
        {
            willbealive = yes_set_to_alive;
        }

        public void update_cell_status()
        {
            isalive = willbealive;
            willbealive = false;
        }
    }
}
