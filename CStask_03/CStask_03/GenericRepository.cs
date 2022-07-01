using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStask_03
{
    internal class Entity
    {
        public int Id;
    }
    internal class GenericRepository : IRepository<Entity>
    {
        Entity[] arr = new Entity[10];
        int size = 10;
        int index = 0;
        public void Add(Entity item)
        {
            index += 1;
            if (index < size)
            {
                arr[index] = item;
                return;
            }
            else
            {
                size = size * 2;
                Array.Resize(ref arr, size);
                arr[index] = item;
            }
        }

        public IEnumerable<Entity> GetAll()
        {
            return arr;
        }

        public Entity GetById(int id)
        {
            return arr[id];
        }

        public void Remove(Entity item)
        {
            int removed = 0;

            for (int i = 0; i <= index; i++)
            {
                if (arr[i] == item)
                {
                    arr[i] = arr[i + 1];
                    removed++;
                }
            }
            index -= removed;

        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
