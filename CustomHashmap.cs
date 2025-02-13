using System;
using System.Collections.Generic;

public class HashMap<TKey, TValue>
{
    private const int InitialSize = 16;
    private LinkedList<KeyValuePair<TKey, TValue>>[] buckets;

    public HashMap()
    {
        buckets = new LinkedList<KeyValuePair<TKey, TValue>>[InitialSize];
        for (int i = 0; i < InitialSize; i++)
        {
            buckets[i] = new LinkedList<KeyValuePair<TKey, TValue>>();
        }
    }

    // Hash function
    private int GetBucketIndex(TKey key)
    {
        int hash = key.GetHashCode();
        int bucketIndex = hash % InitialSize;
        return Math.Abs(bucketIndex);
    }

    // Insert operation
    public void Insert(TKey key, TValue value)
    {
        int bucketIndex = GetBucketIndex(key);
        LinkedList<KeyValuePair<TKey, TValue>> bucket = buckets[bucketIndex];

        foreach (var pair in bucket)
        {
            if (pair.Key.Equals(key))
            {
                throw new ArgumentException("Key already exists");
            }
        }

        bucket.AddLast(new KeyValuePair<TKey, TValue>(key, value));
    }

    // Delete operation
    public void Delete(TKey key)
    {
        int bucketIndex = GetBucketIndex(key);
        LinkedList<KeyValuePair<TKey, TValue>> bucket = buckets[bucketIndex];

        var node = bucket.First;
        while (node != null)
        {
            if (node.Value.Key.Equals(key))
            {
                bucket.Remove(node);
                return;
            }
            node = node.Next;
        }

        throw new KeyNotFoundException("Key not found");
    }

    // Retrieve operation
    public TValue Retrieve(TKey key)
    {
        int bucketIndex = GetBucketIndex(key);
        LinkedList<KeyValuePair<TKey, TValue>> bucket = buckets[bucketIndex];

        foreach (var pair in bucket)
        {
            if (pair.Key.Equals(key))
            {
                return pair.Value;
            }
        }

        throw new KeyNotFoundException("Key not found");
    }
}

class Program
{
    static void Main()
    {
        HashMap<string, int> hashMap = new HashMap<string, int>();
        hashMap.Insert("apple", 1);
        hashMap.Insert("banana", 2);

        Console.WriteLine("Value for 'apple': " + hashMap.Retrieve("apple"));
        Console.WriteLine("Value for 'banana': " + hashMap.Retrieve("banana"));

        hashMap.Delete("apple");

        try
        {
            Console.WriteLine("Value for 'apple': " + hashMap.Retrieve("apple"));
        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
    }
}
