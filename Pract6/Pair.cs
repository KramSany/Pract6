using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    internal class Pair
    {
        private int _first;
        private int _second;
        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }

        public int First
        {
            get => _first;
            set
            {
                if (value % 2 != 0)
                    throw new ArgumentException("Вы даун");

                _first = value;
            }
        }
        public int Second
        {
            get { return _second; }
            set
            {
                if (value % 2 != 0)
                    throw new ArgumentException("Вы даун");

                _second = value;
            }
        }
        public int Myltiply()
        {
            return First * Second;
        }
        public Pair Myltiply(Pair value)
        {
            return new Pair(First * value.First, Second * value.Second);
        }

        public static Pair operator ++(Pair pairOne)
        {
            Pair result = new Pair(pairOne.First + pairOne.Second, pairOne.Second);
            return result;

        }
        public override string ToString()
        {
            return $"{First}, {Second}";
        }

    }
}
