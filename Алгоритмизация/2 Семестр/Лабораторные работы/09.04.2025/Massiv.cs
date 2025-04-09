class Program
{
    public class Massiv<T>
    {
        public T[] _items{ get; set; }
        public int _size { get; set; }

        public Massiv(int total_size)
        {
            if (total_size <= 0)
            {
                throw new Exception("Неверно задан размер");
            }
            _items = new T[total_size];
            _size = 0;
        }

        public int Count => _size;

        public void Add(T item)
        {
            T[] array = _items;
            int size = _size;

            if ((uint)size < (uint)array.Length)
            {
                _size = size + 1;
                array[size] = item;
            }
            else
            {
                throw new Exception("Невозможно вставить элемент");
            }
        }

        public T Get_Item(int index)
        {
            T[] array = _items;
            int size = _size;

            if (((uint)index > (uint)array.Length) || (uint)index < 0)
            {
                throw new Exception("Неверно введён индекс");
            }
            else
            {
                for (int i = 0; i < _size; i++)
                {
                    if (i == index)
                    {
                        return _items[i];
                    }
                }
            }
            return default;
        }

        public void Remove(int index)
        {
            T[] array = _items;
            int size = _size;
            if (((uint)index > (uint)size--) || (uint)index < 0)
            {
                throw new Exception("Неверно введён индекс");
            }
            else
            {
                for (int i = 0; i < _size; i++)
                {
                    if ((i >= index) && (i < _items.Length - 1))
                    {
                        _items[i] = _items[i + 1];
                    }
                }
                _size--;
                _items[_items.Length - 1] = default; 
            }
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < Count; i++)
            {
                output += $"{Get_Item(i)}\t";
            }

            return output;
        }
    }
    
    public static void Main()
    {
        Massiv<int> test = new Massiv<int>(10);
        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            test.Add(rnd.Next(10, 500));
        }

        Console.WriteLine("Элемент с индексом 3:");
        Console.WriteLine(test.Get_Item(3));
        Console.WriteLine(test);
        Console.WriteLine("Удаление элемента с индексом 3:");
        test.Remove(3);
        Console.WriteLine(test);
    }   
}
