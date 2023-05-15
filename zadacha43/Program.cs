/* Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями y = 
k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
*/

System.Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

(double, double) FindPoint(double mult1, double plus1, double mult2, double plus2)
{
    // k1*x+b1=k2*x+b2
    // k1*x-k2*x=b2-b1
    // (k1-k2)*x=b2-b1
    double res_x = (plus2-plus1)/(mult1-mult2);
    double res_y = mult1*res_x+plus1;
    var res = (res_x, res_y);
    return res;
}

var (x, y) = FindPoint(k1, b1, k2, b2);
System.Console.Write($"x = {x}, y = {y}");
