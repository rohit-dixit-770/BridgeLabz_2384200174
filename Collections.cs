/*
//List Interface Problems

//1.Reverse a List

using System;
using System.Collections;

public class ArrayListReversal
{
    public static void Main()
    {
        // Create an ArrayList and add elements based on user input
        ArrayList arrayList = new ArrayList();
        Console.WriteLine("Enter the number of elements for the ArrayList: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the elements: ");
        for (int i = 0; i < n; i++)
        {
            int element = int.Parse(Console.ReadLine());
            arrayList.Add(element);
        }

        Console.WriteLine("Original ArrayList: ");
        DisplayList(arrayList);

        // Reverse the ArrayList
        ReverseArrayList(arrayList);

        Console.WriteLine("Reversed ArrayList: ");
        DisplayList(arrayList);
    }

    // Method to reverse the elements of an ArrayList
    public static void ReverseArrayList(ArrayList list)
    {
        int left = 0;
        int right = list.Count - 1;

        // Swap elements from the ends towards the center
        while (left < right)
        {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }

    // Method to display elements of an ArrayList
    public static void DisplayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}

// LinkList

using System;
using System.Collections.Generic;

public class LinkedListReversal
{
    public static void Main()
    {
        // Create a LinkedList and add elements based on user input
        LinkedList<int> linkedList = new LinkedList<int>();
        Console.WriteLine("Enter the number of elements for the LinkedList: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the elements: ");
        for (int i = 0; i < n; i++)
        {
            int element = int.Parse(Console.ReadLine());
            linkedList.AddLast(element);
        }

        Console.WriteLine("Original LinkedList: ");
        DisplayList(linkedList);

        // Reverse the LinkedList
        LinkedList<int> reversedLinkedList = ReverseLinkedList(linkedList);

        Console.WriteLine("Reversed LinkedList: ");
        DisplayList(reversedLinkedList);
    }

    // Method to reverse the elements of a LinkedList
    public static LinkedList<T> ReverseLinkedList<T>(LinkedList<T> list)
    {
        LinkedList<T> reversedList = new LinkedList<T>();

        // Add elements to the front of the new LinkedList
        LinkedListNode<T> current = list.First;
        while (current != null)
        {
            reversedList.AddFirst(current.Value);
            current = current.Next;
        }

        return reversedList;
    }

    // Method to display elements of a LinkedList
    public static void DisplayList<T>(LinkedList<T> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}


//2. Find Frequency of Elements
using System;
using System.Collections.Generic;

public class FrequencyCounter
{
    public static void Main()
    {
        // Create a list to store user input strings
        List<string> stringList = new List<string>();

        // Prompt the user to enter the number of elements
        Console.WriteLine("Enter the number of elements in the list: ");
        int n = int.Parse(Console.ReadLine());

        // Prompt the user to enter each element
        Console.WriteLine("Enter the elements: ");
        for (int i = 0; i < n; i++)
        {
            string element = Console.ReadLine();
            stringList.Add(element);
        }

        // Calculate the frequency of each element
        Dictionary<string, int> frequencyDict = CalculateFrequency(stringList);

        // Display the results
        Console.WriteLine("Frequency of elements:");
        foreach (var kvp in frequencyDict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

    // Method to calculate the frequency of each element in the list
    public static Dictionary<string, int> CalculateFrequency(List<string> list)
    {
        Dictionary<string, int> frequencyDict = new Dictionary<string, int>();

        // Iterate through each element in the list
        foreach (string item in list)
        {
            // If the element is already in the dictionary, increment its count
            if (frequencyDict.ContainsKey(item))
            {
                frequencyDict[item]++;
            }
            // Otherwise, add the element to the dictionary with a count of 1
            else
            {
                frequencyDict[item] = 1;
                Console.ReadLine();
            }
            
        }

        return frequencyDict;
    }
}


//3. Rotate Elements in a List
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Accepting user input for the list
        Console.WriteLine("Enter the elements of the list, separated by spaces:");
        string input = Console.ReadLine();
        List<int> inputList = new List<int>();

        foreach (var item in input.Split(' '))
        {
            if (int.TryParse(item, out int number))
            {
                inputList.Add(number);
            }
        }

        // Accepting user input for the number of positions to rotate
        Console.WriteLine("Enter the number of positions to rotate by:");
        int rotateBy = int.Parse(Console.ReadLine());

        List<int> rotatedList = RotateList(inputList, rotateBy);

        Console.WriteLine("Rotated List: " + string.Join(", ", rotatedList));
    }

    static List<int> RotateList(List<int> inputList, int rotateBy)
    {
        int n = inputList.Count;
        rotateBy = rotateBy % n; // Ensure rotateBy is within the bounds of the list length

        List<int> rotatedList = new List<int>(inputList);

        rotatedList.AddRange(inputList.GetRange(0, rotateBy));
        rotatedList.RemoveRange(0, rotateBy);

        return rotatedList;
    }
}


//4. Remove Duplicates While Preserving Order
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Accepting user input for the list
        Console.WriteLine("Enter the elements of the list, separated by spaces:");
        string input = Console.ReadLine();
        List<int> inputList = new List<int>();

        foreach (var item in input.Split(' '))
        {
            if (int.TryParse(item, out int number))
            {
                inputList.Add(number);
            }
        }

        List<int> resultList = RemoveDuplicates(inputList);

        Console.WriteLine("List after removing duplicates: " + string.Join(", ", resultList));
    }

    static List<int> RemoveDuplicates(List<int> inputList)
    {
        List<int> resultList = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        foreach (int item in inputList)
        {
            if (!seen.Contains(item))
            {
                seen.Add(item);
                resultList.Add(item);
            }
        }

        return resultList;
    }
}


//5. Find the Nth Element from the End
using System;
using System.Collections.Generic;

class Node
{
    public char Data;
    public Node Next;

    public Node(char data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    public Node Head;

    public void AddNode(char data)
    {
        Node newNode = new Node(data);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public char FindNthFromEnd(int n)
    {
        Node mainPtr = Head;
        Node refPtr = Head;

        int count = 0;
        while (count < n)
        {
            if (refPtr == null)
            {
                Console.WriteLine("N is greater than the length of the linked list.");
                return '\0';
            }
            refPtr = refPtr.Next;
            count++;
        }

        while (refPtr != null)
        {
            mainPtr = mainPtr.Next;
            refPtr = refPtr.Next;
        }

        return mainPtr.Data;
    }
}

class Program
{
    static void Main()
    {
        LinkedList linkedList = new LinkedList();

        // Accepting user input for the linked list
        Console.WriteLine("Enter the elements of the linked list, separated by spaces:");
        string input = Console.ReadLine();

        foreach (var item in input.Split(' '))
        {
            linkedList.AddNode(Convert.ToChar(item));
        }

        // Accepting user input for N
        Console.WriteLine("Enter the value of N:");
        int n = int.Parse(Console.ReadLine());

        char nthElementFromEnd = linkedList.FindNthFromEnd(n);
        if (nthElementFromEnd != '\0')
        {
            Console.WriteLine("The " + n + "th element from the end is: " + nthElementFromEnd);
        }
    }
}



//Set Interface Problems

//1. Check if Two Sets Are Equal
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Accepting user input for the first set
        Console.WriteLine("Enter the elements of the first set, separated by spaces:");
        string input1 = Console.ReadLine();
        HashSet<int> set1 = new HashSet<int>();

        foreach (var item in input1.Split(' '))
        {
            if (int.TryParse(item, out int number))
            {
                set1.Add(number);
            }
        }

        // Accepting user input for the second set
        Console.WriteLine("Enter the elements of the second set, separated by spaces:");
        string input2 = Console.ReadLine();
        HashSet<int> set2 = new HashSet<int>();

        foreach (var item in input2.Split(' '))
        {
            if (int.TryParse(item, out int number))
            {
                set2.Add(number);
            }
        }

        bool areSetsEqual = set1.SetEquals(set2);
        Console.WriteLine("The sets are equal: " + areSetsEqual);
    }
}




//2. Union and Intersection of Two Sets
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Accepting user input for the first set
        Console.WriteLine("Enter the elements of the first set, separated by spaces:");
        string input1 = Console.ReadLine();
        HashSet<int> set1 = new HashSet<int>();

        foreach (var item in input1.Split(' '))
        {
            if (int.TryParse(item, out int number))
            {
                set1.Add(number);
            }
        }

        // Accepting user input for the second set
        Console.WriteLine("Enter the elements of the second set, separated by spaces:");
        string input2 = Console.ReadLine();
        HashSet<int> set2 = new HashSet<int>();

        foreach (var item in input2.Split(' '))
        {
            if (int.TryParse(item, out int number))
            {
                set2.Add(number);
            }
        }

        // Compute Union
        HashSet<int> unionSet = new HashSet<int>(set1);
        unionSet.UnionWith(set2);

        // Compute Intersection
        HashSet<int> intersectionSet = new HashSet<int>(set1);
        intersectionSet.IntersectWith(set2);

        Console.WriteLine("Union: " + string.Join(", ", unionSet));
        Console.WriteLine("Intersection: " + string.Join(", ", intersectionSet));
    }
}



//3. Symmetric Difference
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Accepting user input for the first set
        Console.WriteLine("Enter the elements of the first set, separated by spaces:");
        string input1 = Console.ReadLine();
        HashSet<int> set1 = new HashSet<int>();

        foreach (var item in input1.Split(' '))
        {
            if (int.TryParse(item, out int number))
            {
                set1.Add(number);
            }
        }

        // Accepting user input for the second set
        Console.WriteLine("Enter the elements of the second set, separated by spaces:");
        string input2 = Console.ReadLine();
        HashSet<int> set2 = new HashSet<int>();

        foreach (var item in input2.Split(' '))
        {
            if (int.TryParse(item, out int number))
            {
                set2.Add(number);
            }
        }

        // Compute Symmetric Difference
        HashSet<int> symmetricDifference = new HashSet<int>(set1);
        symmetricDifference.SymmetricExceptWith(set2);

        Console.WriteLine("Symmetric Difference: " + string.Join(", ", symmetricDifference));
    }
}


//4. Convert a Set to a Sorted List
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Accepting user input for the set
        Console.WriteLine("Enter the elements of the set, separated by spaces:");
        string input = Console.ReadLine();
        HashSet<int> inputSet = new HashSet<int>();

        foreach (var item in input.Split(' '))
        {
            if (int.TryParse(item, out int number))
            {
                inputSet.Add(number);
            }
        }

        // Convert the set to a sorted list
        List<int> sortedList = new List<int>(inputSet);
        sortedList.Sort();

        Console.WriteLine("Sorted List: " + string.Join(", ", sortedList));
    }
}


//5. Find Subsets
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Accepting user input for the first set
        Console.WriteLine("Enter the elements of the first set, separated by spaces:");
        string input1 = Console.ReadLine();
        HashSet<int> set1 = new HashSet<int>();

        foreach (var item in input1.Split(' '))
        {
            if (int.TryParse(item, out int number))
            {
                set1.Add(number);
            }
        }

        // Accepting user input for the second set
        Console.WriteLine("Enter the elements of the second set, separated by spaces:");
        string input2 = Console.ReadLine();
        HashSet<int> set2 = new HashSet<int>();

        foreach (var item in input2.Split(' '))
        {
            if (int.TryParse(item, out int number))
            {
                set2.Add(number);
            }
        }

        bool isSubset = set1.IsSubsetOf(set2);
        Console.WriteLine("The first set is a subset of the second set: " + isSubset);
    }
}


//Queue Interface Problems

//1.Reverse a Queue
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Accepting user input for the queue
        Console.WriteLine("Enter the elements of the queue, separated by spaces:");
        string input = Console.ReadLine();
        Queue<int> queue = new Queue<int>();

        foreach (var item in input.Split(' '))
        {
            if (int.TryParse(item, out int number))
            {
                queue.Enqueue(number);
            }
        }

        // Reverse the queue
        Queue<int> reversedQueue = ReverseQueue(queue);

        Console.WriteLine("Reversed Queue: " + string.Join(", ", reversedQueue));
    }

    static Queue<int> ReverseQueue(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();

        // Dequeue all elements from the queue and push them onto the stack
        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }

        // Pop all elements from the stack and enqueue them back to the queue
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }

        return queue;
    }
}


//2. Generate Binary Numbers Using a Queue
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Accepting user input for the number of binary numbers to generate
        Console.WriteLine("Enter the value of N:");
        int n = int.Parse(Console.ReadLine());

        List<string> binaryNumbers = GenerateBinaryNumbers(n);

        Console.WriteLine("The first " + n + " binary numbers are: " + string.Join(", ", binaryNumbers));
    }

    static List<string> GenerateBinaryNumbers(int n)
    {
        List<string> result = new List<string>();
        Queue<string> queue = new Queue<string>();

        // Initialize the queue with the first binary number
        queue.Enqueue("1");

        while (n-- > 0)
        {
            // Get the front element from the queue
            string current = queue.Dequeue();
            result.Add(current);

            // Generate the next two binary numbers and enqueue them
            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }

        return result;
    }
}


// 3. Hospital Triage System
using System;
using System.Collections.Generic;

class Patient : IComparable<Patient>
{
    public string Name { get; set; }
    public int Severity { get; set; }

    public Patient(string name, int severity)
    {
        Name = name;
        Severity = severity;
    }

    public int CompareTo(Patient other)
    {
        // Higher severity should come first, so we compare in reverse order
        return other.Severity.CompareTo(this.Severity);
    }

    public override string ToString()
    {
        return Name + " (Severity: " + Severity + ")";
    }
}

class Program
{
    static void Main()
    {
        // Accepting user input for the patients and their severities
        Console.WriteLine("Enter the patients and their severities in the format 'Name Severity' (e.g., 'John 3'). Enter 'done' to finish:");
        List<Patient> patients = new List<Patient>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }

            string[] parts = input.Split(' ');
            if (parts.Length == 2 && int.TryParse(parts[1], out int severity))
            {
                patients.Add(new Patient(parts[0], severity));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter in the format 'Name Severity'.");
            }
        }

        PriorityQueue<Patient> triageQueue = new PriorityQueue<Patient>(patients);
        Console.WriteLine("Order of treatment:");

        while (triageQueue.Count > 0)
        {
            Patient patient = triageQueue.Dequeue();
            Console.WriteLine(patient);
        }
    }
}

class PriorityQueue<T> where T : IComparable<T>
{
    private List<T> data;

    public PriorityQueue()
    {
        this.data = new List<T>();
    }

    public PriorityQueue(List<T> items)
    {
        this.data = new List<T>(items);
        for (int i = (data.Count / 2) - 1; i >= 0; i--)
        {
            HeapifyDown(i);
        }
    }

    public void Enqueue(T item)
    {
        data.Add(item);
        HeapifyUp(data.Count - 1);
    }

    public T Dequeue()
    {
        if (data.Count == 0) throw new InvalidOperationException("The queue is empty");
        T item = data[0];
        data[0] = data[data.Count - 1];
        data.RemoveAt(data.Count - 1);
        HeapifyDown(0);
        return item;
    }

    public int Count => data.Count;

    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parent = (index - 1) / 2;
            if (data[index].CompareTo(data[parent]) <= 0)
            {
                break;
            }
            Swap(index, parent);
            index = parent;
        }
    }

    private void HeapifyDown(int index)
    {
        int lastIndex = data.Count - 1;
        while (index < lastIndex)
        {
            int leftChild = (index * 2) + 1;
            int rightChild = leftChild + 1;
            if (leftChild > lastIndex)
            {
                break;
            }
            int swapIndex = leftChild;
            if (rightChild <= lastIndex && data[rightChild].CompareTo(data[leftChild]) > 0)
            {
                swapIndex = rightChild;
            }
            if (data[index].CompareTo(data[swapIndex]) >= 0)
            {
                break;
            }
            Swap(index, swapIndex);
            index = swapIndex;
        }
    }

    private void Swap(int index1, int index2)
    {
        T temp = data[index1];
        data[index1] = data[index2];
        data[index2] = temp;
    }
}


//Map Interface Problems

//1. Word Frequency Counter
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Accepting user input for the text
        Console.WriteLine("Enter the text:");
        string text = Console.ReadLine();

        Dictionary<string, int> wordFrequency = CountWordFrequency(text);

        Console.WriteLine("Word Frequency:");
        foreach (var pair in wordFrequency)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    static Dictionary<string, int> CountWordFrequency(string text)
    {
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
        char[] delimiters = new char[] { ' ', '\r', '\n', ',', '.', '!', '?' };
        string[] words = text.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (wordFrequency.ContainsKey(word))
            {
                wordFrequency[word]++;
            }
            else
            {
                wordFrequency[word] = 1;
            }
        }

        return wordFrequency;
    }
}


//2. Invert a Map
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Accepting user input for the dictionary
        Console.WriteLine("Enter the key-value pairs in the format 'Key=Value' (e.g., 'A=1'). Enter 'done' to finish:");
        Dictionary<string, int> inputDict = new Dictionary<string, int>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }

            string[] parts = input.Split('=');
            if (parts.Length == 2 && int.TryParse(parts[1], out int value))
            {
                inputDict[parts[0]] = value;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter in the format 'Key=Value'.");
            }
        }

        Dictionary<int, List<string>> invertedDict = InvertDictionary(inputDict);

        Console.WriteLine("Inverted Dictionary:");
        foreach (var pair in invertedDict)
        {
            Console.WriteLine($"{pair.Key}: [{string.Join(", ", pair.Value)}]");
        }
    }

    static Dictionary<int, List<string>> InvertDictionary(Dictionary<string, int> inputDict)
    {
        Dictionary<int, List<string>> invertedDict = new Dictionary<int, List<string>>();

        foreach (var pair in inputDict)
        {
            if (!invertedDict.ContainsKey(pair.Value))
            {
                invertedDict[pair.Value] = new List<string>();
            }
            invertedDict[pair.Value].Add(pair.Key);
        }

        return invertedDict;
    }
}

// Real-World System Design Problems

//1. Insurance Policy Management System
using System;
using System.Collections.Generic;

public class Policy : IComparable<Policy>
{
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Policy(string policyNumber, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public int CompareTo(Policy other)
    {
        return this.ExpiryDate.CompareTo(other.ExpiryDate);
    }

    public override bool Equals(object obj)
    {
        if (obj is Policy)
        {
            Policy other = (Policy)obj;
            return this.PolicyNumber == other.PolicyNumber;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    public override string ToString()
    {
        return $"{PolicyNumber}: {CoverageType}, Expiry: {ExpiryDate.ToShortDateString()}";
    }
}

public class InsurancePolicyManagementSystem
{
    private HashSet<Policy> policySet;
    private LinkedList<Policy> linkedPolicySet;
    private SortedSet<Policy> sortedPolicySet;

    public InsurancePolicyManagementSystem()
    {
        policySet = new HashSet<Policy>();
        linkedPolicySet = new LinkedList<Policy>();
        sortedPolicySet = new SortedSet<Policy>();
    }

    public void AddPolicy(Policy policy)
    {
        if (policySet.Add(policy))
        {
            linkedPolicySet.AddLast(policy);
            sortedPolicySet.Add(policy);
        }
    }

    public void RemovePolicy(Policy policy)
    {
        if (policySet.Remove(policy))
        {
            linkedPolicySet.Remove(policy);
            sortedPolicySet.Remove(policy);
        }
    }

    public void DisplayPolicies()
    {
        Console.WriteLine("Policies in HashSet:");
        foreach (var policy in policySet)
        {
            Console.WriteLine(policy);
        }

        Console.WriteLine("\nPolicies in LinkedList:");
        foreach (var policy in linkedPolicySet)
        {
            Console.WriteLine(policy);
        }

        Console.WriteLine("\nPolicies in SortedSet:");
        foreach (var policy in sortedPolicySet)
        {
            Console.WriteLine(policy);
        }
    }
}

class Program
{
    static void Main()
    {
        InsurancePolicyManagementSystem system = new InsurancePolicyManagementSystem();

        // Accepting user input for policies
        Console.WriteLine("Enter policies in the format 'PolicyNumber CoverageType ExpiryDate (yyyy-MM-dd)'. Enter 'done' to finish:");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }

            string[] parts = input.Split(' ');
            if (parts.Length == 3 && DateTime.TryParse(parts[2], out DateTime expiryDate))
            {
                string policyNumber = parts[0];
                string coverageType = parts[1];

                Policy policy = new Policy(policyNumber, coverageType, expiryDate);
                system.AddPolicy(policy);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter in the format 'PolicyNumber CoverageType ExpiryDate (yyyy-MM-dd)'.");
            }
        }

        system.DisplayPolicies();
        
    }
}


//2. Retrieve Policies:
using System;
using System.Collections.Generic;
using System.Linq;

public class Policy : IComparable<Policy>
{
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Policy(string policyNumber, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public int CompareTo(Policy other)
    {
        return this.ExpiryDate.CompareTo(other.ExpiryDate);
    }

    public override bool Equals(object obj)
    {
        if (obj is Policy)
        {
            Policy other = (Policy)obj;
            return this.PolicyNumber == other.PolicyNumber;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    public override string ToString()
    {
        return $"{PolicyNumber}: {CoverageType}, Expiry: {ExpiryDate.ToShortDateString()}";
    }
}

public class InsurancePolicyManagementSystem
{
    private HashSet<Policy> policySet;
    private LinkedList<Policy> linkedPolicySet;
    private SortedSet<Policy> sortedPolicySet;
    private Dictionary<string, int> policyCount;

    public InsurancePolicyManagementSystem()
    {
        policySet = new HashSet<Policy>();
        linkedPolicySet = new LinkedList<Policy>();
        sortedPolicySet = new SortedSet<Policy>();
        policyCount = new Dictionary<string, int>();
    }

    public void AddPolicy(Policy policy)
    {
        if (policySet.Add(policy))
        {
            linkedPolicySet.AddLast(policy);
            sortedPolicySet.Add(policy);
            if (policyCount.ContainsKey(policy.PolicyNumber))
            {
                policyCount[policy.PolicyNumber]++;
            }
            else
            {
                policyCount[policy.PolicyNumber] = 1;
            }
        }
    }

    public void RemovePolicy(Policy policy)
    {
        if (policySet.Remove(policy))
        {
            linkedPolicySet.Remove(policy);
            sortedPolicySet.Remove(policy);
            policyCount[policy.PolicyNumber]--;
            if (policyCount[policy.PolicyNumber] == 0)
            {
                policyCount.Remove(policy.PolicyNumber);
            }
        }
    }

    public void DisplayPolicies()
    {
        Console.WriteLine("Policies in HashSet:");
        foreach (var policy in policySet)
        {
            Console.WriteLine(policy);
        }

        Console.WriteLine("\nPolicies in LinkedList:");
        foreach (var policy in linkedPolicySet)
        {
            Console.WriteLine(policy);
        }

        Console.WriteLine("\nPolicies in SortedSet:");
        foreach (var policy in sortedPolicySet)
        {
            Console.WriteLine(policy);
        }
    }

    public void DisplayPoliciesExpiringSoon()
    {
        Console.WriteLine("\nPolicies Expiring Soon (Within 30 Days):");
        DateTime now = DateTime.Now;
        foreach (var policy in sortedPolicySet)
        {
            if ((policy.ExpiryDate - now).Days <= 30)
            {
                Console.WriteLine(policy);
            }
        }
    }

    public void DisplayPoliciesByCoverageType(string coverageType)
    {
        Console.WriteLine($"\nPolicies with Coverage Type: {coverageType}");
        foreach (var policy in policySet)
        {
            if (policy.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(policy);
            }
        }
    }

    public void DisplayDuplicatePolicies()
    {
        Console.WriteLine("\nDuplicate Policies:");
        foreach (var pair in policyCount)
        {
            if (pair.Value > 1)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} duplicates");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        InsurancePolicyManagementSystem system = new InsurancePolicyManagementSystem();

        // Accepting user input for policies
        Console.WriteLine("Enter policies in the format 'PolicyNumber CoverageType ExpiryDate (yyyy-MM-dd)'. Enter 'done' to finish:");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }

            string[] parts = input.Split(' ');
            if (parts.Length == 3 && DateTime.TryParse(parts[2], out DateTime expiryDate))
            {
                string policyNumber = parts[0];
                string coverageType = parts[1];

                Policy policy = new Policy(policyNumber, coverageType, expiryDate);
                system.AddPolicy(policy);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter in the format 'PolicyNumber CoverageType ExpiryDate (yyyy-MM-dd)'.");
            }
        }

        // Displaying all unique policies
        system.DisplayPolicies();

        // Displaying policies expiring soon
        system.DisplayPoliciesExpiringSoon();

        // Accepting user input for coverage type
        Console.WriteLine("\nEnter the coverage type to filter policies:");
        string coverageTypeInput = Console.ReadLine();
        system.DisplayPoliciesByCoverageType(coverageTypeInput);

        // Displaying duplicate policies
        system.DisplayDuplicatePolicies();
    }
}



//1. Design a Voting System
using System;
using System.Collections.Generic;

public class VotingSystem
{
    private Dictionary<string, int> voteCounts;
    private SortedDictionary<string, int> sortedVoteCounts;
    private LinkedList<KeyValuePair<string, int>> voteOrder;

    public VotingSystem()
    {
        voteCounts = new Dictionary<string, int>();
        sortedVoteCounts = new SortedDictionary<string, int>();
        voteOrder = new LinkedList<KeyValuePair<string, int>>();
    }

    public void CastVote(string candidate)
    {
        if (voteCounts.ContainsKey(candidate))
        {
            voteCounts[candidate]++;
        }
        else
        {
            voteCounts[candidate] = 1;
        }

        sortedVoteCounts[candidate] = voteCounts[candidate];

        voteOrder.AddLast(new KeyValuePair<string, int>(candidate, voteCounts[candidate]));
    }

    public void DisplayVoteCounts()
    {
        Console.WriteLine("Vote Counts:");
        foreach (var pair in voteCounts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    public void DisplaySortedVoteCounts()
    {
        Console.WriteLine("Sorted Vote Counts:");
        foreach (var pair in sortedVoteCounts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    public void DisplayVoteOrder()
    {
        Console.WriteLine("Vote Order:");
        foreach (var pair in voteOrder)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}

class Program
{
    static void Main()
    {
        VotingSystem votingSystem = new VotingSystem();

        // Accepting user input for votes
        Console.WriteLine("Enter votes (type 'done' to finish):");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }

            votingSystem.CastVote(input);
        }

        // Displaying vote counts, sorted vote counts, and vote order
        votingSystem.DisplayVoteCounts();
        votingSystem.DisplaySortedVoteCounts();
        votingSystem.DisplayVoteOrder();
    }
}


//2. Implement a Shopping Cart
using System;
using System.Collections.Generic;

public class ShoppingCart
{
    private Dictionary<string, double> productPrices;
    private LinkedList<KeyValuePair<string, double>> productOrder;
    private SortedDictionary<double, List<string>> sortedProducts;

    public ShoppingCart()
    {
        productPrices = new Dictionary<string, double>();
        productOrder = new LinkedList<KeyValuePair<string, double>>();
        sortedProducts = new SortedDictionary<double, List<string>>();
    }

    public void AddProduct(string product, double price)
    {
        if (!productPrices.ContainsKey(product))
        {
            productPrices[product] = price;
            productOrder.AddLast(new KeyValuePair<string, double>(product, price));

            if (!sortedProducts.ContainsKey(price))
            {
                sortedProducts[price] = new List<string>();
            }
            sortedProducts[price].Add(product);
        }
        else
        {
            Console.WriteLine("Product already exists in the shopping cart.");
        }
    }

    public void DisplayProductPrices()
    {
        Console.WriteLine("Product Prices:");
        foreach (var pair in productPrices)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value:C}");
        }
    }

    public void DisplayProductOrder()
    {
        Console.WriteLine("Product Order:");
        foreach (var pair in productOrder)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value:C}");
        }
    }

    public void DisplaySortedProducts()
    {
        Console.WriteLine("Sorted Products by Price:");
        foreach (var pair in sortedProducts)
        {
            foreach (var product in pair.Value)
            {
                Console.WriteLine($"{product}: {pair.Key:C}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart shoppingCart = new ShoppingCart();

        // Accepting user input for products and prices
        Console.WriteLine("Enter products and prices in the format 'Product Price' (e.g., 'Apple 1.99'). Enter 'done' to finish:");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }

            string[] parts = input.Split(' ');
            if (parts.Length == 2 && double.TryParse(parts[1], out double price))
            {
                string product = parts[0];

                shoppingCart.AddProduct(product, price);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter in the format 'Product Price'.");
            }
        }

        // Displaying product prices, order of insertion, and sorted products
        shoppingCart.DisplayProductPrices();
        shoppingCart.DisplayProductOrder();
        shoppingCart.DisplaySortedProducts();
    }
}


//3. Implement a Banking System
using System;
using System.Collections.Generic;

public class BankingSystem
{
    private Dictionary<int, double> accountBalances;
    private SortedDictionary<double, List<int>> sortedCustomers;
    private Queue<KeyValuePair<int, double>> withdrawalRequests;

    public BankingSystem()
    {
        accountBalances = new Dictionary<int, double>();
        sortedCustomers = new SortedDictionary<double, List<int>>();
        withdrawalRequests = new Queue<KeyValuePair<int, double>>();
    }

    public void AddAccount(int accountNumber, double balance)
    {
        if (!accountBalances.ContainsKey(accountNumber))
        {
            accountBalances[accountNumber] = balance;
            if (!sortedCustomers.ContainsKey(balance))
            {
                sortedCustomers[balance] = new List<int>();
            }
            sortedCustomers[balance].Add(accountNumber);
        }
        else
        {
            Console.WriteLine("Account already exists.");
        }
    }

    public void ProcessWithdrawalRequests()
    {
        while (withdrawalRequests.Count > 0)
        {
            var request = withdrawalRequests.Dequeue();
            int accountNumber = request.Key;
            double amount = request.Value;

            if (accountBalances.ContainsKey(accountNumber) && accountBalances[accountNumber] >= amount)
            {
                double oldBalance = accountBalances[accountNumber];
                accountBalances[accountNumber] -= amount;

                sortedCustomers[oldBalance].Remove(accountNumber);
                if (sortedCustomers[oldBalance].Count == 0)
                {
                    sortedCustomers.Remove(oldBalance);
                }

                double newBalance = accountBalances[accountNumber];
                if (!sortedCustomers.ContainsKey(newBalance))
                {
                    sortedCustomers[newBalance] = new List<int>();
                }
                sortedCustomers[newBalance].Add(accountNumber);

                Console.WriteLine($"Withdrawal of {amount:C} from account {accountNumber} processed. New balance: {newBalance:C}");
            }
            else
            {
                Console.WriteLine($"Withdrawal of {amount:C} from account {accountNumber} failed. Insufficient balance.");
            }
        }
    }

    public void DisplayAccountBalances()
    {
        Console.WriteLine("Account Balances:");
        foreach (var pair in accountBalances)
        {
            Console.WriteLine($"Account {pair.Key}: {pair.Value:C}");
        }
    }

    public void DisplaySortedCustomers()
    {
        Console.WriteLine("Customers sorted by balance:");
        foreach (var pair in sortedCustomers)
        {
            foreach (var account in pair.Value)
            {
                Console.WriteLine($"Account {account}: {pair.Key:C}");
            }
        }
    }

    public void QueueWithdrawalRequest(int accountNumber, double amount)
    {
        withdrawalRequests.Enqueue(new KeyValuePair<int, double>(accountNumber, amount));
        Console.WriteLine($"Withdrawal request of {amount:C} for account {accountNumber} added to the queue.");
    }
}

class Program
{
    static void Main()
    {
        BankingSystem bankingSystem = new BankingSystem();

        // Accepting user input for accounts and balances
        Console.WriteLine("Enter accounts and balances in the format 'AccountNumber Balance' (e.g., '12345 1000'). Enter 'done' to finish:");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }

            string[] parts = input.Split(' ');
            if (parts.Length == 2 && int.TryParse(parts[0], out int accountNumber) && double.TryParse(parts[1], out double balance))
            {
                bankingSystem.AddAccount(accountNumber, balance);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter in the format 'AccountNumber Balance'.");
            }
        }

        // Accepting user input for withdrawal requests
        Console.WriteLine("Enter withdrawal requests in the format 'AccountNumber Amount' (e.g., '12345 500'). Enter 'done' to finish:");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }

            string[] parts = input.Split(' ');
            if (parts.Length == 2 && int.TryParse(parts[0], out int accountNumber) && double.TryParse(parts[1], out double amount))
            {
                bankingSystem.QueueWithdrawalRequest(accountNumber, amount);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter in the format 'AccountNumber Amount'.");
            }
        }

        // Processing withdrawal requests
        bankingSystem.ProcessWithdrawalRequests();

        // Displaying account balances and sorted customers
        bankingSystem.DisplayAccountBalances();
        bankingSystem.DisplaySortedCustomers();
    }
}

*/