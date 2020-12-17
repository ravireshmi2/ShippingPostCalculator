using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingPostCalculator
{
    interface BaseCalculator<T>
    {
        T CalculateCheapestCost(int size);
    }
}
