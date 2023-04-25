using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Threading.Channels;

namespace MovieDatabase
{
    public class Program
    {
        static void Main()
        {
            Movie movie1 = new Movie("Home Alone","drama");
            Movie movie2 = new Movie("Escape Room", "scifi");
            Movie movie3 = new Movie("Escape Room", "drama");
            Movie movie4 = new Movie("Escape Room", "horror");
            Movie movie5 = new Movie("Adam Driver65", "drama");
            Movie movie6 = new Movie("Adam Driver65", "action");
            Movie movie7 = new Movie("2020", "scifi");
            Movie movie8 = new Movie("2020", "drama");
            Movie movie9 = new Movie("2020", "action");
            Movie movie10 = new Movie("Star war", "scifi");
            Movie movie11 = new Movie("Star war", "animated");
            Movie movie12 = new Movie("Star war", "action");
            Movie movie13 = new Movie("Avatar", "scifi");
            Movie movie14 = new Movie("Avatar", "animated");
            Movie movie15 = new Movie("ToyStory", "animated");
            List<Movie> MovieList = new List<Movie>();
            MovieList.Add(movie1);
            MovieList.Add(movie2);
            MovieList.Add(movie3);
            MovieList.Add(movie4);
            MovieList.Add(movie5);
            MovieList.Add(movie6);
            MovieList.Add(movie7);
            MovieList.Add(movie8);
            MovieList.Add(movie9);
            MovieList.Add(movie10);
            MovieList.Add(movie11);
            MovieList.Add(movie12);
            MovieList.Add(movie13);
            MovieList.Add(movie14);
            MovieList.Add(movie15);
            Console.WriteLine("Category list: animated drama horror scifi action");
            bool check = true;
            do
            {
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("There are 15 movies in this list.");
                string enter = Validator.ValidateEnter();
                Console.WriteLine();
               
                foreach (Movie movie in MovieList)
                {
                    if (movie.Category == enter)
                    {
                        Console.WriteLine(movie.Title);
                       
                    }
                }
             
               
                Console.WriteLine();
                Console.WriteLine("Continue? (y/n):");
                string contunue = Console.ReadLine().ToLower().Trim();
                if (contunue == "y")
                {
                    check = true;
                    continue;

                }
                else if (contunue == "n")
                {
                    Console.WriteLine("Thank you!");
                    check=false;
                }
                else
                {
                    Console.WriteLine("This is an invalid enter,let's try again!");
                    check = true;
                    continue;
                }

            }while (check);

        }

    }
}