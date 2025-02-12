
namespace MovieManagementSystem
{
    public class Program
    {
        static void Main()
        {
            MovieManageSLL movieList = new MovieManageSLL();

            // Add new movies
            movieList.AddAtEnd("Munna Bhai M.B.B.S.", "Rajkumar Hirani", 2003, 8.8);
            movieList.AddAtEnd("M.S. Dhoni: The Untold Story", "Neeraj Pandey", 2016, 9.0);
            movieList.AddAtEnd("Interstellar", "Christopher Nolan", 2014, 8.6);

            // Display all movies in forward order
            Console.WriteLine("All Movies (Forward Order):");
            movieList.DisplayAllMoviesForward();

            // Display all movies in reverse order
            Console.WriteLine("\nAll Movies (Reverse Order):");
            movieList.DisplayAllMoviesReverse();

            // Search for a movie by Director
            Console.WriteLine("\nSearch for movie by Director 'Christopher Nolan':");
            Node movie = movieList.SearchByDirector("Christopher Nolan");
            if (movie != null)
            {
                Console.WriteLine(movie.ToString());
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }

            // Update a movie's rating
            Console.WriteLine("\nUpdate Rating for movie 'Munna Bhai M.B.B.S.':");
            movieList.UpdateRating("Munna Bhai M.B.B.S.", 9.0);
            movieList.DisplayAllMoviesForward();

            // Remove a movie by title
            Console.WriteLine("\nRemove movie 'M.S. Dhoni: The Untold Story':");
            movieList.RemoveByMovieTitle("M.S. Dhoni: The Untold Story");
            movieList.DisplayAllMoviesForward();
        }
    }
}
