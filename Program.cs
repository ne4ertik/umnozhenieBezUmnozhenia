namespace umnozhenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //цикл сложения 
            static double cikl(double num1, double num2)
            {
                double x = 0;
                for (int i = 0; i != num2; i++)
                {
                    x += num1;
                }
                return x;
            } 

            //деление
            static double delenie(double num1, double num2)
            {

                double x = num1/(1/num2);
                return x;

            }

            //через логарифмы
            static double logi(double num1, double num2)
            {

                double x = Math.Exp(Math.Log(num1)+Math.Log(num2));
                return x;

            }

            //через логарифм по основанию 10 и степень 

            static double logiPow(double num1, double num2)
            {

                double x = Math.Pow(10,Math.Log10(num1) + Math.Log10(num2));
                return x;

            }

            //через логарифм по основанию 2 и степень 
            static double logiPowDva(double num1, double num2)
            {

                double x = Math.Pow(2, Math.Log2(num1) + Math.Log2(num2));
                return x;

            }

            //через тангенс 
            static double tang(double num1, double num2)
            {

                double x = 1-(num1+num2)/Math.Tan(Math.Atan(num1)+Math.Atan(num2));
                return x;

            }

            Console.WriteLine(" Введите два числа, которые надо умножить ");
            double number1= Convert.ToInt32(Console.ReadLine());
            double number2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(cikl(number1, number2));
            Console.WriteLine(delenie(number1, number2));
            Console.WriteLine(logiPow(number1, number2));
            Console.WriteLine(tang(number1, number2));
            Console.WriteLine(logiPowDva(number1, number2));
            Console.WriteLine(logi(number1,number2));
            
        }
    } 
    
}

