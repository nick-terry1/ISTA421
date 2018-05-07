using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11_vectordistance
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a List of 100  randomly generated Vector objects using RandomVector method
            List<Vector> vectorList = new List<Vector>();
            for (int i = 0; i < 100; i++)
            {
                vectorList.Add(Vector.RandomVector(i,i+50));
            }

            // This Vector array will hold the two Vectors returned by the ShortestDistance method
            Vector[] a = new Vector[2];
            a = Vector.ShortestDist(vectorList);

            // printing the two points in a user friendly fashion
            Console.WriteLine("The two points that have the shortest distance between them is:");
            foreach (Vector v in a)
            {
                Console.WriteLine($"({v.x},{v.y},{v.z})");
            }
        }
    }
}
