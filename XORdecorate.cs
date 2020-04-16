using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace XORarray
{
    class XORdecorate:Dynamic
    {
        protected DynamicArray dynamic;
        public XORdecorate(DynamicArray dynamic)
        {
            this.dynamic = dynamic;
        }

        public override void AddValue(int num)
        {
            BitArray terr = new BitArray(new int[] { 13 });
            BitArray bt = new BitArray(new int[] { num });
            dynamic.AddValue(getInt(bt.Xor(terr)));
        }

        private int getInt(BitArray bitArray)
        {
            if (bitArray.Length > 32)
                throw new ArgumentException("Argument length shall be at most 32 bits");

            int[] array = new int[1];
            bitArray.CopyTo(array, 0);
            return array[0];
        }

        public override int GetValue(int index)
        {
            return dynamic.GetValue(index);
        }

        public override void Resize(int newSize)
        {
            dynamic.Resize(newSize);
        }
        public int GetValueWithReXOR(int index)
        {
            BitArray terr = new BitArray(new int[] { 13 });
            BitArray bt = new BitArray(new int[] { dynamic.GetValue(index) });
            terr = terr.Xor(bt);
            int[] array = new int[1];
            terr.CopyTo(array, 0);
            return array[0];
        }

        public int GetLength { get { return dynamic.GetLength; } }
    }

}
