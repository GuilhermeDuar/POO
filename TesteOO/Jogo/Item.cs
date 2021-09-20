using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO.Jogo
{
    public class Item
    {
        public int id;
        public String name;
        public int quantity;
        
        public Item()
        {
            this.id = -1;
            this.name = "nothing";
            this.quantity = 0;
        }
        
        public Item(int idB, String nameB, int quantityB)
        {
            this.id = idB;
            this.name = nameB;
            this.quantity = quantityB;
        }
    }
}
