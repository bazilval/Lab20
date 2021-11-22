using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*В приложении объявить тип делегата, который ссылается на метод. 
 * Требования к сигнатуре метода следующие:

-       метод получает входным параметром переменную типа double;

-       метод возвращает значение типа double, которое является результатом вычисления.

Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:

-       длину окружности по формуле D = 2 * π* R;

-       площадь круга по формуле S = π* R²;

-       объем шара. Формула V = 4/3 * π * R³.*/

namespace Lab20
{

    class Program
    {
        delegate double Del(double d);
        static double CircleLen(double r) { return 2 * Math.PI * r; }
        static double CircleSquare(double r) { return Math.PI * r * r; }
        static double SphereValue(double r) { return 4 / 3 * Math.PI * r * r * r; }


        static void Main(string[] args)
        {
            Del del = CircleLen;
            del += CircleSquare;
            del += SphereValue;

            Console.WriteLine($"{del(4.5):f3}");
            Console.ReadKey();
        }
    }
}
