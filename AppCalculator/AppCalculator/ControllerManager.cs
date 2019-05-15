using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AppCalculator
{
    enum TypeCalc
    {
        Real,
        Frac,
        Complex
    }
    public enum Operation
    {
        None,
        Add,
        Deduct,
        Mul,
        Division
    }
    public enum Func
    {
        Revers,
        Sqr,
    }
    class ControllerManager
    {
        TypeCalc _typeCalc;
        Operation _bufOprt;
        Proc<iNumber> _proc;
        Memory<iNumber> _mem;
        public int _base = 10;
        bool _isUsing = false;
        bool _isTotal = false;
        public string strCalculate { get; private set; }
        public string strHistory { get; private set; }

        public ControllerManager()
        {
            strCalculate = "0";
            strHistory = "";
            _typeCalc = TypeCalc.Real;
            _isUsing = false;
            _proc = new Proc<iNumber>();
            _mem = new Memory<iNumber>();
/*
            Main._cm.MC();
            Main.CorrectInput(trackBar1.Value);
            Main._cm._base = trackBar1.Value;
*/
        }

        public string GetStringType()
        {
            TypeCalc tc = GetTypeCalc();
            if (tc == TypeCalc.Complex)
                return "Comp";
            return "Real";
        }
        public TypeCalc GetTypeCalc()
        {
            
            if (strCalculate.Contains("i"))
                return TypeCalc.Complex;
            return TypeCalc.Real;
        }
        public void AddNum(string val)
        {
            if (_isTotal)
            {
                strHistory = "";
                _isTotal = false;
            }
            if (_isUsing)
            {
                strCalculate = val;
                _isUsing = false;
                return;
            }
            if (strCalculate == "0")
                strCalculate = val;
            else
                strCalculate += val;
        }
        public void SetSeparator()
        {
            if (_isTotal)
            {
                strHistory = "";
                _isTotal = false;
            }
            if (_isUsing)
            {
                strCalculate = "0.";
                _isUsing = false;
                return;
            }
            if (strCalculate.Length <= 0)
            {
                strCalculate = "0.";
                return;
            }
            if (strCalculate.Contains('.') && GetTypeCalc() == TypeCalc.Real)
                return;
            
            strCalculate += ".";
        }
        public void BackSpace()
        {
            if (_isTotal)
            {
                strHistory = "";
                _isTotal = false;
            }
            if (strCalculate.Length <= 0)
                return;
            if (_isUsing)
            {
                strCalculate = "0";
                _isUsing = false;
                return;
            }
            strCalculate = strCalculate.Substring(0, strCalculate.Length - 1);
            if (strCalculate.Length > 0)
                if (strCalculate[strCalculate.Length - 1] == '-' || strCalculate[strCalculate.Length - 1] == '+')
                    strCalculate = strCalculate.Substring(0, strCalculate.Length - 1);
            if (_typeCalc == TypeCalc.Frac && strCalculate.Contains("/") == false)
            {
                _typeCalc = TypeCalc.Real;
            }
            if (_typeCalc == TypeCalc.Complex && strCalculate.Contains("i") == false)
                _typeCalc = TypeCalc.Real;
            if (strCalculate.Length <= 0)
                strCalculate = "0";
        }
        public void SetTypeCalc(TypeCalc _type, string Im = "+")
        {
            
            if (_type == TypeCalc.Complex)
            {
                if (GetTypeCalc() == _type)
                {
                    string tmp = strCalculate.Substring(0, strCalculate.IndexOf('i'));
                    tmp = tmp.Substring(0, tmp.Length - 1);
                    tmp += Im + "i" + strCalculate.Substring(strCalculate.IndexOf('i') + 1);
                    strCalculate = tmp;
                }
                else
                    strCalculate += Im + "i";
            }
            if (_type == TypeCalc.Frac && strCalculate.Contains('.'))
                _type = TypeCalc.Real;
            _typeCalc = _type;
        }
        public void PlusMinus()
        {
            if (strCalculate.Length <= 0)
                return;
            if (strCalculate[0] == '-')
            {
                strCalculate = strCalculate.Substring(1);
            }
            else
            {
                strCalculate = "-" + strCalculate;
            }
        }
        public void MC()
        {
            _mem.Clear();
            //_mem.Set(InitNull());
        }
        public void MR()
        {
            if (_isTotal)
            {
                strHistory = "";
                _isTotal = false;
            }
            strCalculate = _mem.Get().GetNumberString();
        }
        public void MS()
        {
            _mem.Set(Init());

        }
        public void MAdd()
        {
            iNumber n = Init();
            
            if (_mem.Get() is Complex)
            {
                if (n is Complex)
                    _mem.Sum(n);
            }
           
        }
        public void MDeduct()
        {
            iNumber n = Init();
          
            if (_mem.Get() is Complex)
            {
                if (n is Complex)
                    _mem.Deduct(n);
                
            }
            
        }
        public void Reset()
        {
            if (_isTotal)
            {
                strHistory = "";
                _isTotal = false;
            }
            _typeCalc = TypeCalc.Real;
            strCalculate = "0";
        }
        public void Compute(Func _func)
        {
            if (_isTotal)
            {
                strHistory = "";
                _isTotal = false;
            }
            _proc.SetRop(Init());
            _proc.RunFunc(_func);
            strCalculate = _proc.GetRop().GetNumberString();
        }
        public void Compute(Operation _operation)
        {
            if (_isTotal)
            {
                strHistory = "";
                _isTotal = false;
            }
            if (_proc.GetState() == Operation.None)
            {
                iNumber n = Init();
                _proc.SetLop(n);
                _proc.SetRop(_proc.GetLop());
                _proc.SetState(_operation);
            }
            else
            {
                iNumber n = Init();
                n = Convert(n, _proc.GetLop().GetType());
                if (n == null)
                {
                    Debug.WriteLine("3");
                    throw new FormatException("Can't continue");
                 }
                _proc.SetRop(n);
                _proc.RunOprtn();
                _proc.SetState(_operation);
            }
            _isUsing = true;
            strHistory += _proc.GetRop().GetNumberString();
            strCalculate = _proc.GetLop().GetNumberString();
            switch (_operation)
            {
                case Operation.Add: strHistory += "+"; break;
                case Operation.Deduct: strHistory += "-"; break;
                case Operation.Division: strHistory += "/"; break;
                case Operation.Mul: strHistory += "*"; break;
            }
        }
        public iNumber Init()
        {
           
                if (strCalculate[strCalculate.Length - 1] == 'i')
                    strCalculate += "0";
                return new Complex(strCalculate, _base);
           
        }
        /*public iNumber InitNull()
        {
            
                if (strCalculate[strCalculate.Length - 1] == '/')
                    strCalculate += "1";
                return new Frac("0/1", 10);
            
        }*/
        public void Total()
        {
            if (!_isTotal)
            {
                if (_proc.GetState() == Operation.None)
                    return;
                iNumber n = Init();
                n = Convert(n, _proc.GetLop().GetType());
                if (n == null)
                {
                    Debug.WriteLine("4");
                    throw new FormatException("Can't continue");
                }
                _proc.SetRop(n);
                _proc.RunOprtn();
                strHistory += _proc.GetRop().GetNumberString() + "=" + _proc.GetLop().GetNumberString();
                strCalculate = _proc.GetLop().GetNumberString();
                _isTotal = true;
                _isUsing = true;
                _bufOprt = _proc.GetState();
                _proc.SetState(Operation.None);
                return;
            }
            else
            {
                _proc.SetState(_bufOprt);
                _proc.RunOprtn();
                _proc.SetState(Operation.None);
                strHistory += "=" + _proc.GetLop().GetNumberString();
                strCalculate = _proc.GetLop().GetNumberString();
            }
        }
        private iNumber Convert(iNumber Value, Type Dest)
        {
            if (Value.GetType() == Dest)
                return Value;
            if (Dest == typeof(Complex))
            {
                SetTypeCalc(TypeCalc.Complex);
                return Init();
            }
            return null;
        }
        public void InsertBuffer(string str)
        {
            strCalculate = str;
        }
    }
}
