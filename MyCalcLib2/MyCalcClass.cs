using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcLib2
{
    public class MyCalcClass
    {
      /// <summary>
      /// Нахождение суммы
      /// </summary>
      /// <param name="x">первое слагаемое</param>
      /// <param name="y">второе слагаемое</param>
      /// <returns>Сумма слагаемых</returns>
       public int Sum(int x,int y)
        { 
            return x + y; 
        }
      
        public int Sub(int x,int y)
        {
            return x- y;
        }

        public int Mul(int x,int y)
        { 
            return x*y; 
        }
        /// <summary>
        /// Нахождение результата деления
        /// </summary>
        /// <param name="x">Первый делитель</param>
        /// <param name="y">Второе делимое</param>
        /// <returns>Результат деления</returns>
        public double Div(double x,double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }

    }
}
