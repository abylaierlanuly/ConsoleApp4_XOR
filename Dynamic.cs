using System;
using System.Collections.Generic;
using System.Text;

namespace XORarray
{
    abstract class Dynamic
    {
        public abstract void AddValue(int num);
        public abstract int GetValue(int index);
        public abstract void Resize(int newSize);

    }
}
