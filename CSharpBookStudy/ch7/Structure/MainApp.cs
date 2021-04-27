using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.ch7.Structure
{
    struct Point3D
    {
        public int x;
        public int y;
        public int z;

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return string.Format($"{x},{y},{z}");
        }
    }

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Point3D p3d1;
    //        p3d1.x = 10;
    //        p3d1.y = 20;
    //        p3d1.z = 40;

    //        Console.WriteLine(p3d1.ToString());

    //        Point3D d2 = new Point3D(100, 200, 300);
    //        Point3D d3 = d2;
    //        d3.z = 400;

    //        Console.WriteLine(d2.ToString());
    //        Console.WriteLine(d3.ToString());
    //    }
    //}
}
