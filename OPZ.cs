using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_3
{
    internal class OPZ
    {
        string soursString; //строка скобочного выражения
        string resultToOPZ;
        string oPZString; //запись выражения в форме ОПЗ
        int finalResult; //итог

        public string SoursString
        {
            get{ return soursString; }
            set{ soursString = value; }
        }
        public string OPZString
        {
            get{ return oPZString; }
            set { oPZString = value; }
        }
        public int FinalResult
        {
            get{ return finalResult; }
            set { finalResult = value; }
        }

        public OPZ()
        {
            soursString = "";
            oPZString = "";
        }

        public string ToOPZ(string SoursString)
        {
            foreach (char c in SoursString)
            {
                if (c == '^')
                {
                    resultToOPZ += c;
                }
                else if ((c == '*') || (c == '/'))
                {
                    resultToOPZ += c;
                }
                else if ((c == '+') || (c == '-'))
                {
                    resultToOPZ += c;
                }
                else if (c == ')')
                {
                    resultToOPZ += c;
                }
                else if (c == '(')
                {
                    resultToOPZ += c;
                }
            }
            return resultToOPZ;
        }

        public int Priority(char Value)
        {
            if (Value == '(') return 0;
            if (Value == ')') return 1;
            if ((Value == '+') || (Value == '-')) return 2;
            if ((Value == '*') || (Value == '/')) return 3;
            if (Value == '^') return 4;
            return 10;
      }

        public double Calc(string OPZString)
        {
            foreach (char c in resultToOPZ)
            {

            }
            return 0;//
        }
    }
}
