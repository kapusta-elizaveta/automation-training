using System;

namespace Triangle
{
    public class TriangleCheck
    {
        public bool Cheking(int a, int b, int z)
        {
            if (a > 0 && b > 0 && z > 0)
            {
                return a + b > z && a + z > b && z + b > a;
            }
            throw new TriangleException(" Side is negative");

        }
    }
}