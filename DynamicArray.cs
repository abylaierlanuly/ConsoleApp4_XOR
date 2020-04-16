using System;
using System.Collections.Generic;
using System.Text;

namespace XORarray
{
    
    class DynamicArray:Dynamic
    {
        int count = 0;
        int[] array;
        int _size;

        public DynamicArray(int Size)
        {
            _size = Size;
            array = new int[_size];
        }
        

        public override void AddValue(int num)
        {
            if (array.Length<count)
            {
                Resize(array.Length + 5);
                array[count] = num;
                count++;
            }
            else
            {
                array[count] = num;
                count++;
            }
          
        }

        public override void Resize(int newSize)
        {
            int[] newArray = new int[newSize];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public override int GetValue(int index)
        {
            return array[index];
        }
        public int GetLength { get {return count; } }
    }
}
