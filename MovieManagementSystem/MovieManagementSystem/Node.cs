namespace MovieManagementSystem
{
    public class Node
    {
        public string movieTitle;
        public string director;
        public int yearOfRelease;
        public double rating;
        public Node next;
        public Node prev;

        public Node(string movieTitle, string director, int yearOfRelease, double rating)
        {
            this.movieTitle = movieTitle;
            this.director = director;
            this.yearOfRelease = yearOfRelease;
            this.rating = rating;
            next = null;
            prev = null;
        }

        public override string ToString()
        {
            return $"Title: {movieTitle}, Director: {director}, Year: {yearOfRelease}, Rating: {rating}";
        }

    }
}
