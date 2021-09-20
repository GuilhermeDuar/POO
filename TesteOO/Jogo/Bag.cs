using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO.Jogo
{
    class Bag
    {
        Item[] itemsInBag;
        int itemsCount;

        public Bag(int size)
        {
            this.itemsInBag = new Item[size];
            this.itemsCount = 0;
        }

        public void addItem(int id, String name, int quantity)
        {
            if (itemsCount < itemsInBag.Length)
            {
                this.itemsInBag[itemsCount++] = new Item(id, name, quantity);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Bolsa cheia.");
            }
        }

        public void removeItem(int idLookingFor)
        {
            for (int i = 0; i < itemsInBag.Length; i++)
            {
                if (this.itemsInBag[i].id == idLookingFor)
                {
                    this.itemsInBag[i] = null;
                    this.itemsCount--;
                    return;
                }
            }
            System.Windows.Forms.MessageBox.Show("Impossível Remover Item.");
        }
    }
}
