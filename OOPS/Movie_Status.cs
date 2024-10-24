using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Movie_Status
    {
        public string Title;
        public int year;
        public float rating;

        public Movie_Status()
        {
            Title = "";
            year = 0;
            rating = 0.0f;
        }

        public void Accept()
        {
            Console.Write("Enter Movie Title: ");
            Title = Console.ReadLine();

            Console.Write("Enter Release Year: ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Enter Movie Rating (0.0 - 5.0): ");
            rating = float.Parse(Console.ReadLine());
        }

        public void Compute()
        {
            if (rating >= 0.0f && rating <= 2.0f)
            {
                Console.WriteLine("Movie Status: FLOP");
            }
            else if (rating >= 2.1f && rating <= 3.4f)
            {
                Console.WriteLine("Movie Status: SEMI HIT");
            }
            else if (rating >= 3.5f && rating <= 4.5f)
            {
                Console.WriteLine("Movie Status: HIT");
            }
            else if (rating >= 4.6f && rating <= 5.0f)
            {
                Console.WriteLine("Movie Status: SUPER HIT");
            }
            else
            {
                Console.WriteLine("Invalid rating! Rating should be between 0.0 and 5.0.");
            }
        }

        public void Display()
        {
            Console.WriteLine("\nMovie Title: " + Title);
            Console.WriteLine("Release Year: " + year);
            Console.WriteLine("Rating: " + rating);
            Compute(); 
        }
    }
}
