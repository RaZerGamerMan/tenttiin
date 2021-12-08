using System;

namespace Exercise6_1
{
    class Program
    {
        abstract class Mesh
        {
            public abstract double GetMeshVolume();
        }
        class Cube : Mesh
        {
            private double edge;
            public Cube(double a)
            {
                edge = a;
            }
            public override double GetMeshVolume()
            {
                return Math.Pow(edge, 3);
            }
        }
        class Cylinder : Mesh
        {
            private double radius;
            private double height;
            public Cylinder(double r, double h)
            {
                radius = r;
                height = h;
            }
            public override double GetMeshVolume()
            {
                return Math.PI * Math.Pow(radius, 2) * height;
            }
        }
        class Cone : Mesh
        {
            private double radius;
            private double height;
            public Cone(double r, double h)
            {
                radius = r;
                height = h;
            }
            public override double GetMeshVolume()
            {
                return Math.PI * Math.Pow(radius, 2) * height;
            }
            class Capsule : Mesh
            {
                private double radius;
                private double height;
                public Capsule(double r, double h)
                {
                    radius = r;
                    height = h;
                }
                public override double GetMeshVolume()
                {
                    return Math.PI * Math.Pow(radius, 2) * height;
                }
            }
        }
        static void Main(string[] args)
        {
            Cube cube = new Cube(3);
            Cylinder cylinder = new Cylinder(2, 2);
            Cone cone = new Cone(2, 2);
            PrintMeshVolumes(cube, cylinder, cone);
        }
        static void PrintMeshVolumes(params Mesh[] meshes)
        {
            for (int i = 0; i < meshes.Length; i++)
            {

            }
        }
    }
}
