using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculator
{

    class Proc<T> where T : iNumber
    {
        private T _Lop, _Rop;
        private Operation _operation;
        public Proc()
        {
            ResetProc();
        }
        public void ResetProc()
        {
            _operation = Operation.None;
        }
        public void ResetOprtn()
        {
            _operation = Operation.None;
        }
        public void RunOprtn()
        {
            switch (_operation)
            {
                case Operation.Add:
                    _Lop = (T)_Lop.Add(_Rop);
                    break;
                case Operation.Deduct:
                    _Lop = (T)_Lop.Deduct(_Rop);
                    break;
                case Operation.Division:
                    _Lop = (T)_Lop.Copy().Divide(_Rop.Copy());
                    break;
                case Operation.Mul:
                    _Lop = (T)_Lop.Mul(_Rop);
                    break;
            }
        }
        public void RunFunc(Func func)
        {
            switch (func)
            {
                case Func.Revers:
                    _Rop = (T)_Rop.Rev();
                    break;
                case Func.Sqr:
                    _Rop = (T)_Rop.Sqr();
                    break;
            
            }
        }
        public T GetLop()
        {
            return (T)_Lop.Copy();
        }
        public void SetLop(T E)
        {
            _Lop = (T)E.Copy();
        }
        public T GetRop()
        {
            return (T)_Rop.Copy();
        }
        public void SetRop(T E)
        {
            _Rop = (T)E.Copy();
        }
        public Operation GetState()
        {
            return _operation;
        }
        public void SetState(Operation oprtn)
        {
            _operation = oprtn;
        }
    }
}
