using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
             
                Rectangle rect = new Rectangle();

  
                rect.height = 2;
                rect.width = 3;

               
                rect.Show();

                // Рассчитываем и выводим периметр
                double p = rect.Perimetr();
                Console.WriteLine($"Периметр прямоугольника = {p}");

                Console.ReadKey();
            }
        }

        class Rectangle
        {
            
            public double height; // высота
            public double width;  // ширина

         
            public void Show()
            {
                Console.WriteLine($"Прямоугольник: высота = {height}, ширина = {width}");
            }

            // Метод расчета периметра
            public double Perimetr()
            {
                return 2 * height + 2 * width;
            }
        }
    }
}
    

