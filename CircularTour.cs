using System;
using System.Collections.Generic;

public class PetrolPump
{
    public int Petrol;
    public int Distance;

    public PetrolPump(int petrol, int distance)
    {
        Petrol = petrol;
        Distance = distance;
    }
}

public class CircularTour
{
    public static int FindStartingPoint(List<PetrolPump> petrolPumps)
    {
        int n = petrolPumps.Count;
        int start = 0, end = 1;
        int currentPetrol = petrolPumps[start].Petrol - petrolPumps[start].Distance;

        while (end != start || currentPetrol < 0)
        {
            // If currentPetrol becomes less than 0, then remove the starting petrol pump from tour
            while (currentPetrol < 0 && start != end)
            {
                currentPetrol -= petrolPumps[start].Petrol - petrolPumps[start].Distance;
                start = (start + 1) % n;

                // If 0 is the starting point, then no solution exists
                if (start == 0)
                {
                    return -1;
                }
            }

            // Add the petrol pump at end to the tour
            currentPetrol += petrolPumps[end].Petrol - petrolPumps[end].Distance;
            end = (end + 1) % n;
        }

        return start;
    }

    public static void Main()
    {
        List<PetrolPump> petrolPumps = new List<PetrolPump> {
            new PetrolPump(4, 6),
            new PetrolPump(6, 5),
            new PetrolPump(7, 3),
            new PetrolPump(4, 5)
        };

        int startingPoint = FindStartingPoint(petrolPumps);

        if (startingPoint == -1)
        {
            Console.WriteLine("No solution exists.");
        }
        else
        {
            Console.WriteLine("The starting point is: " + startingPoint);
            Console.ReadKey();
        }
    }
}
