using System;

namespace Triangle
{
    public class TriangleCheck
    {
        public bool Cheking(int a, int b, int z)
        {
            if ((a + b > z) && (a + z > b) && (b + z > a) ) return true;
            else return false;

        }
    }
}