namespace DsaPratice.Array
{
    public class MyStaticArray
    {
        public int Capacity { get; private set; }
        public int Length { get; private set; }
        private int[] _data;

        public MyStaticArray()
        {
            Capacity = 5;
            _data = new int[Capacity];
        }

        public MyStaticArray(int size)
        {
            if (size < 1)
            {
                throw new InvalidOperationException("The size can't be less than one.");
            }
            Capacity = size;
            _data = new int[size];
        }

        public int GetValueByIndex(int index)
        {
            ValidateArrayIndex(index);
            return _data[index];
        }
        public void UpdateValueByIndex(int index, int value)
        {
            ValidateArrayIndex(index);
            _data[index] = value;
        }
        public void InsertAtEnd(int value)
        {
            ValidateArrayCapacity();
            _data[Length] = value;
            Length++;
        }
        public void DeleteAtEnd()
        {
            ValidateArrayLength();
            _data[Length - 1] = default;
            Length--;
        }
        public void InsertAtBeginning(int value)
        {
            ValidateArrayCapacity();
            // shift all elements to right by one positon
            for(int i = Length - 1; i >= 0; i--)
            {
                _data[i + 1] = _data[i];
            }
            _data[0] = value;
            Length++;
        }
        public void DeleteAtBeginning()
        {
            ValidateArrayLength();
            // shift all elements to left by one positon
            for (int i = 0; i < Length - 1; i++)
            {
                _data[i] = _data[i + 1];
            }
            Length--;
            _data[Length] = default;
        }
        public void InsertAtGivenIndex(int index, int value)
        {
            ValidateArrayCapacity();
            ValidateArrayIndex(index);
            for(int i = Length - 1; i >= index; i--)
            {
                _data[i + 1] = _data[i];
            }
            UpdateValueByIndex(index, value);
            Length++;
        }
        public void DeleteAtGivenIndex(int index)
        {
            ValidateArrayLength();
            for (int i = index; i < Length - 1; i++)
            {
                _data[i] = _data[i + 1];
            }
            Length--;
            _data[Length] = default;
        }
        public bool FindIndex(int value, out int? index)
        {
            index = null;
            for(int i = 0; i < Length; i++)
            {
                if(_data[i] == value)
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }
        public int[] FindAllIndex(int value)
        {
            List<int> result = new List<int>();
            for(int i = 0; i < Length; i++)
            {
                if (_data[i] == value)
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }
        public void Print()
        {
            Console.WriteLine();
            Console.Write("[");
            for (int i = 0; i < Length; i++)
            {
                Console.Write(_data[i]);
                if (i < Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write($"]");
            Console.WriteLine();
        }
        public void Clear()
        {
            _data = new int[Capacity];
            Length = 0;
        }
        public void IncreaseCapacity(int capacity)
        {
            if(capacity <= Capacity)
            {
                throw new InvalidOperationException("The new capacity. Cannot be less than existing capacity");
            }
            Capacity = capacity;
            var newData = new int[Capacity];
            for(int i = 0; i < Length; i++)
            {
                newData[i] = _data[i];
            }
            _data = newData;
        }
        private void ValidateArrayLength()
        {
            if (Length == 0)
            {
                throw new InvalidOperationException("Array is empty. Cannot delete.");
            }
        }
        private void ValidateArrayCapacity()
        {
            if (Length >= Capacity)
            {
                throw new InvalidOperationException("Array is full. Cannot insert new element.");
            }
        }
        private void ValidateArrayIndex(int index)
        {
            if (index < 0 || index > Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range.");
            }
        }
    }
}
