
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class program1
    {
        static void Main1(string[] args)
        {
            /*IAnimal dog = new Dog();
            dog.sound();
            dog.eat();

            Console.WriteLine();

            IAnimal cat = new Cat();
            cat.sound();
            cat.eat();*/

            /*IShape circle = new Circle();
            circle.Draw();
            circle.Description();

            Console.WriteLine();

            IShape rectangle = new Rectangle();
            rectangle.Draw();
            rectangle.Description();*/

            /*ICalculator a4 = new A4();
            Console.WriteLine("Enter Two Numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Addition:{a4.Add(a, b)}");
            Console.WriteLine($"Subtraction:{a4.Sub(a, b)}");
            Console.WriteLine($"Multiplication:{a4.Mul(a, b)}");
            Console.WriteLine($"Division:{Math.Round(a4.Div(a, b),2)}");*/

            Details details = new Details();
            details.personal("Vicky", "Vicky@gmail.com", "8838718250");
            details.education(90.0d, 91.0d, 8.86, 0.0);
            details.bank("Union Bank", "2345654321", "UBIN0132454","189GH", 20000.0);
            details.displayAccountDetails("Savings", "Sivanantham");



        }
    }
}
