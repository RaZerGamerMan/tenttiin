using System;
using static System.Console;

// a)Luo abstrakti luokka Mesh.
// Luokalta löytyy seuraava metodi
// public abstract double GetMeshVolume();

// b) Toteuta luokat Cube, Cylinder, Cone, ja Capsule, joiden kantaluokkana toimii Mesh -luokka. 
// Jokaisen luokan konstruktorissa on tarkoitus alustaa luokan jäsenmuuttujia. Jäsenmuuttujien tyyppi on double.
// Cube = alusta sivun pituus, Cylinder = alusta säde ja korkeus, Cone = alusta säde ja korkeus, Capsule = alusta säde ja korkeus
// Toteuta jokaiselle luokalle tilavuuden laskeminen GetMeshVolume() funktiossa, joka palauttaa tuloksen double tyyppinä.

// c) Luo pääohjelmassa olio jokaisesta muodosta.
// Anna erilaisia arvoja luokan konstruktoreissa ja kutsu kyseisten olioiden GetMeshVolume() metodia edim. Console.WriteLine() funktion sisällä.

namespace Exercise6_1
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
                return edge * edge * edge;
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
                return 0.33333 * 3.14159265359 * radius * radius * height;
            }
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
                return Math.PI * Math.Pow(radius, 2) * ((4.0 / 3.0) * radius + height);
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Cube cube = new Cube(2);
            Console.WriteLine("Kuution tilavuus on: " + cube.GetMeshVolume());

            Cylinder cylinder = new Cylinder(2, 5);
            Console.WriteLine("Sylinterin tilavuus on: " + cylinder.GetMeshVolume());

            Cone cone = new Cone(3, 7);
            Console.WriteLine("Kartion tilavuus on: " + cone.GetMeshVolume());

            Capsule capsule = new Capsule(0.3, 1);
            Console.WriteLine("Kapselin tilavuus on: " + capsule.GetMeshVolume());
        }
    }
}