using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClass
{
    public interface IStack
    {
        void Push(int number);
        int Pop();
        bool IsEmpty();
    }
}
