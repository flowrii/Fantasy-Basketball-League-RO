using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_v2
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }

    public class ResultJ : IAbstractCollection
    {
        public List<Result> response { get; set; }
        public int results { get; set; }
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        // Gets Result count
        public int Count
        {
            get { return response.Count; }
        }
        // Indexer
        public Result this[int index]
        {
            get { return response[index]; }
            set { response.Add(value); }
        }
    }

    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    public interface IAbstractIterator
    {
        Result First();
        Result Next();
        bool IsDone { get; }
        Result CurrentResult { get; }
    }
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    public class Iterator : IAbstractIterator
    {
        ResultJ collection;
        int current = 0;
        int step = 1;
        // Constructor
        public Iterator(ResultJ collection)
        {
            this.collection = collection;
        }
        // Gets first Result
        public Result First()
        {
            current = 0;
            return collection[current] as Result;
        }
        // Gets next Result
        public Result Next()
        {
            current += step;
            if (!IsDone)
                return collection[current] as Result;
            else
                return null;
        }
        // Gets or sets stepsize
        public int Step
        {
            get { return step; }
            set { step = value; }
        }
        // Gets current iterator Result
        public Result CurrentResult
        {
            get { return collection[current] as Result; }
        }
        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return current >= collection.Count; }
        }
    }
}