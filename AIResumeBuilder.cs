using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment1
{
    public abstract class JobRole
    {
        public string CandidateName { get; set; }
        public abstract void DisplayRole();
    }
    public class SoftwareEngineer : JobRole
    {
        public override void DisplayRole()
        {
            Console.WriteLine($"Candidate: {CandidateName}, Role: Software Engineer");
        }
    }
    public class DataScientist : JobRole
    {
        public override void DisplayRole()
        {
            Console.WriteLine($"Candidate: {CandidateName}, Role: Data Scientist");
        }
    }
    public class Resume<T> where T : JobRole
    {
        private List<T> candidates = new List<T>();

        public void AddCandidate(T candidate)
        {
            candidates.Add(candidate);
        }

        public void ProcessResumes()
        {
            foreach (var candidate in candidates)
            {
                candidate.DisplayRole();
            }
        }
    }

}
