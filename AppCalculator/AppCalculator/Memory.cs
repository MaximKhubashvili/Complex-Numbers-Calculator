using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculator
{
    public class Memory<T> where T : iNumber
    {
        private T FNumber;
        bool FState;
        public Memory()
        {
            FState = false;
        }
        public void Set(T E)
        {
            FNumber = E;
            FState = true;
        }
        public T Get()
        {
            FState = true;
            return FNumber;
        }
        public void Sum(T E)
        {
            FState = true;
            FNumber = (T)FNumber.Add(E);
        }
        public void Deduct(T E)
        {
            FState = true;
            FNumber = (T)FNumber.Deduct(E);
        }
        public void Clear()
        {
            FNumber = default(T);
            FState = false;
        }
        public string GetState()
        {
            if (FState)
                return "_On";
            return "_Off";
        }
    }
}
