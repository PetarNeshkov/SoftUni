﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        public Lake(int[] information)
        {
            Information = information;
        }
        int[] Information;

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Information.Length; i+=2)
            {
                yield return Information[i];
            }
            for (int i = Information.Length - 1; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return Information[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
