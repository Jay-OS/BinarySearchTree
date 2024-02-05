using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree.Utilities.BinarySearchTreeBalancer
{
    internal sealed class BinarySearchTreeValueBalancer
    {
        private readonly List<int> _valueList;

        public BinarySearchTreeValueBalancer()
        {
            _valueList = new List<int>();
        }

        public int[] BalanceValues(int[] values)
        {
            AddMidValueToList(values);
            return _valueList.ToArray();
        }

        private void AddMidValueToList(int[] values)
        {
            if (values.Length == 0)
            {
                return;
            }

            if (values.Length == 1)
            {
                _valueList.Add(values[0]);
                return;
            }

            var midpoint = (int)Math.Floor(values.Length / 2d);
            _valueList.Add(values[midpoint]);

            var leftArray = values.Take(midpoint).ToArray();
            var rightArray = values.Skip(midpoint + 1).Take(values.Length - (midpoint + 1)).ToArray();

            AddMidValueToList(leftArray);
            AddMidValueToList(rightArray);
        }
    }
}
