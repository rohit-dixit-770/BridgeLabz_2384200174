using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementSystem
{
    internal class MovieManageSLL
    {
        private Node head;
        private Node tail;

        public MovieManageSLL()
        {
            head = null;
            tail = null;
        }

        // Add a movie record at the beginning
        public void AddAtBeginning(string movieTitle, string director, int yearOfRelease, double rating)
        {
            Node newNode = new Node(movieTitle, director, yearOfRelease, rating);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
        }

        // Add a movie record at the end
        public void AddAtEnd(string movieTitle, string director, int yearOfRelease, double rating)
        {
            Node newNode = new Node(movieTitle, director, yearOfRelease, rating);
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
        }

        // Add a movie record at a specific position
        public void AddAtPosition(string movieTitle, string director, int yearOfRelease, double rating, int position)
        {
            if (position == 0)
            {
                AddAtBeginning(movieTitle, director, yearOfRelease, rating);
                return;
            }

            Node newNode = new Node(movieTitle, director, yearOfRelease, rating);
            Node current = head;
            for (int i = 0; i < position - 1; i++)
            {
                if (current == null)
                {
                    Console.WriteLine("Position out of bounds");
                    return;
                }

                current = current.next;
            }

            newNode.next = current.next;
            if (current.next != null)
            {
                current.next.prev = newNode;
            }
            newNode.prev = current;
            current.next = newNode;
        }

        // Remove a movie record by Movie Title
        public void RemoveByMovieTitle(string movieTitle)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node current = head;
            while (current != null && current.movieTitle != movieTitle)
            {
                current = current.next;
            }

            if (current == null)
            {
                Console.WriteLine("Movie with given title not found");
                return;
            }

            if (current.prev != null)
            {
                current.prev.next = current.next;
            }
            else
            {
                head = current.next;
            }

            if (current.next != null)
            {
                current.next.prev = current.prev;
            }
            else
            {
                tail = current.prev;
            }
        }

        // Search for a movie record by Director
        public Node SearchByDirector(string director)
        {
            Node current = head;
            while (current != null)
            {
                if (current.director == director)
                {
                    return current;
                }

                current = current.next;
            }

            return null;
        }

        // Search for a movie record by Rating
        public Node SearchByRating(double rating)
        {
            Node current = head;
            while (current != null)
            {
                if (current.rating == rating)
                {
                    return current;
                }

                current = current.next;
            }

            return null;
        }

        // Display all movie records in forward order
        public void DisplayAllMoviesForward()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.ToString());
                current = current.next;
            }
        }

        // Display all movie records in reverse order
        public void DisplayAllMoviesReverse()
        {
            Node current = tail;
            while (current != null)
            {
                Console.WriteLine(current.ToString());
                current = current.prev;
            }
        }

        // Update movie rating based on the Movie Title
        public void UpdateRating(string movieTitle, double newRating)
        {
            Node movie = head;
            while (movie != null)
            {
                if (movie.movieTitle == movieTitle)
                {
                    movie.rating = newRating;
                    return;
                }
                movie = movie.next;
            }

            Console.WriteLine("Movie with given title not found");
        }

    }
}
