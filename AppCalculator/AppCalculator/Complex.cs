using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculator
{
    public class Complex : iNumber
    {
        private double _re, _im;
        static int _base;
        public bool isZero()
        {
            if (_re != 0 || _im != 0)
                return false;
            return true;
        }
        public Complex()
        {
            _re = 0;
            _im = 0;
        }
        public Complex(double Re, double Im)
        {
            _re = Re;
            _im = Im;
        }
        public Complex(string Value, int Base)
        {
            _base = Base;
            ParseString(Value);
        }

        private void ParseString(string str)
        {
            if (str.Length < 4)
                throw new FormatException();
            //double tRe, tIm;
            string stRe, stIm;
            //if (str.IndexOf('+', 1) != -1)
            if (str.IndexOf('+',1) != -1)
            {
//                tRe = double.Parse(str.Substring(0, str.IndexOf('+', 1)));
//                tIm = double.Parse(str.Substring(str.IndexOf('+', 1) + 2));
                stRe = str.Substring(0, str.IndexOf('+',1));
                stIm = str.Substring(str.IndexOf('+', 1) + 2);

            }
            else
            {
//                tRe = double.Parse(str.Substring(0, str.IndexOf('-', 1)));
//                tIm = double.Parse(str.Substring(str.IndexOf('-', 1) + 2));
                stRe = str.Substring(0, str.IndexOf('-', 1));
                stIm = '-' + str.Substring(str.IndexOf('-', 1) + 2);

            }

            _re = StringToDouble(stRe, _base);
            _im = StringToDouble(stIm, _base);
        }
        public iNumber Copy()
        {
            return new Complex(_re, _im);
        }

        public iNumber Add(iNumber Value)
        {
            double Re = _re + ((Complex)Value)._re;
            double Im = _im + ((Complex)Value)._im;
            return new Complex(Re, Im);
        }

        public iNumber Deduct(iNumber Value)
        {
        
            double Re = _re - ((Complex)Value)._re;
            double Im = _im - ((Complex)Value)._im;
            return new Complex(Re, Im);
        }

        public iNumber Mul(iNumber Value)
        {
            double Re = _re * ((Complex)Value)._re - _im * ((Complex)Value)._im; 
            double Im = _im * ((Complex)Value)._re + ((Complex)Value)._im * _re;
            return new Complex(Re, Im);
        }

        public iNumber Divide(iNumber Value)
        {
            if (((Complex)Value)._re == 0 && ((Complex)Value)._im == 0)
                throw new DivideByZeroException();
            double den = (Math.Pow(((Complex)Value)._re, 2) + Math.Pow(((Complex)Value)._im, 2));
            double Re = (_re * ((Complex)Value)._re + _im * ((Complex)Value)._im) / den;
            double Im = (((Complex)Value)._re * _im - _re * ((Complex)Value)._im) / den;
            return new Complex(Re, Im);
        }
        
        public Complex Minus()
        {
            return (Complex)new Complex("0+i0", _base).Deduct(this);
        }
        public double Abs()
        {
            return Math.Sqrt((_im * _im) + (_re * _re));
        }
        public Complex Pow(int n)
        {
            double mod = Math.Pow(Abs(), n);
            double Re = mod * Math.Cos((double)n * AngleRad());
            double Im = mod * Math.Sin((double)n * AngleRad());
            return new Complex(Re, Im);
        }
        
        public double AngleRad()
        {
            if (_re > 0)
                return Math.Atan(_im / _re);
            if (_re == 0 && _im > 0)
                return Math.PI / 2;
            if (_re < 0)
                return Math.Atan(_im / _re) + Math.PI;
            if (_re == 0 && _im < 0)
                return (-1 * Math.PI) / 2;
            return 0;
        }
        public double AngleDeg()
        {
            return (AngleRad() * 180.0) / Math.PI;
        }
        public bool Equal(iNumber Value)
        {
            if (_im != ((Complex)Value)._im)
                return false;
            if (_re != ((Complex)Value)._re)
                return false;
            return true;
        }

        public iNumber Sqr()
        {
            return Mul(this);
        }
        
        public iNumber Rev()
        {
            double Re = _re / (Math.Pow(_re, 2) + Math.Pow(_im, 2));
            double Im = (_im / (Math.Pow(_re, 2) + Math.Pow(_im, 2))) * -1;
            return new Complex(Re, Im);
        }
        
        public string GetNumberString()
        {

            string value = "";
            value += _re.ToString();
            value += _im < 0 ? "-" : "+";
            value += "i";
            value += Math.Abs(_im).ToString();
            return value;

            value = "";
            value += DoubleToString(_re, _base);
            value += _im < 0 ? "-" : "+";
            value += "i";
            value += DoubleToString(Math.Abs(_im), _base);
            return value;
        }
        
        
        public void SetNumberString(string Value)
        {
            throw new NotImplementedException();
        }
        private double StringToDouble(string Value, int Base)
        {
            if (Base == 10)
            {
                Value = Value.Replace('.', ',');
                return double.Parse(Value);
            }
            double result = 0.0;
            double minus = 1;
            char[] abc = new char[16] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            string integer = Value.Contains('.') == false ? Value : Value.Substring(0, Value.IndexOf('.'));
            if (integer[0] == '-')
            {
                minus = -1;
                integer = integer.Substring(1);
            }
            bool isError = true;
            for (int i = 0; i < integer.Length; i++)
            {
                for (int j = 0; j < Base; j++)
                {
                    if (abc[j] == integer[i])
                    {
                        result += j * Math.Pow(Base, integer.Length - i - 1);
                        isError = false;
                        break;
                    }
                }
                if (isError)
                    throw new FormatException("Value is not Base");
                else
                    isError = true;
            }
            string doub = Value.Contains('.') == false ? "" : Value.Substring(Value.IndexOf('.') + 1, Value.Length - Value.IndexOf('.') - 1);
            isError = true;
            for (int i = 0; i < doub.Length; i++)
            {
                for (int j = 0; j < Base; j++)
                {
                    if (abc[j] == doub[i])
                    {
                        result += j * Math.Pow(Base, (i + 1) * -1);
                        isError = false;
                        break;
                    }
                }
                if (isError)
                    throw new FormatException("Value is not Base");
                else
                    isError = true;
            }
            return result * minus;
        }
        private string DoubleToString(double Value, int Base)
        {
            if (Base == 10)
                return Value.ToString();
            string strInt = "";
            char[] abc = new char[16] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int integer = (int)Value;
            integer *= Value < 0 ? -1 : 1;
            while (integer >= Base)
            {
                strInt += abc[integer % Base];
                integer /= Base;
            }
            strInt += abc[integer];
            strInt += Value < 0 ? "-" : "";
            double doub = Value - (int)Value;
            doub *= Value < 0 ? -1 : 1;
            string result = "";
            for (int i = strInt.Length - 1; i >= 0; i--)
                result += strInt[i];
            return result;
        }
    }
}
