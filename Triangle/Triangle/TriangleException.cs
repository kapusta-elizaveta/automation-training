using System;

namespace Triangle
{
    public class TriangleException : Exception
    {
        public TriangleException(string message) : base(message){}
    }
}