﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHalkbankList
{
    public interface IMyEnumerator
    {
        object? Current { get; }
        bool MoveNext();
        void Reset();
    }
}
