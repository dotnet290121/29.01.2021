using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2901
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5.5, -19.4);
            Point p2 = new Point(7.111, 101.1);
            Point p3 = new Point(7.111, 101.1);

            Console.WriteLine($"p2 == p3 ? {p2 == p3}");
            Console.WriteLine($"p1 == null ? {p2 == null}");
            Console.WriteLine($"p2 != p3 ? {p2 != p3}");

            Point p4 = p1 + p2;
            Point p5 = p1 - p2;

            Console.WriteLine($"p1: {p1}");
            Console.WriteLine($"p2: {p2}");
            Console.WriteLine($"p3: {p3}");
            Console.WriteLine($"p4 [p1+p2]: {p4}");
            Console.WriteLine($"p5 [p1-p2]: {p5}");

            Student danny = new Student
            {
                Id = 1,
                Age = 27,
                Name = "Danny"
            };
            Student moshe = new Student
            {
                Id = 2,
                Age = 32,
                Name = "Moshe"
            };
            Student shlomo = new Student
            {
                Id = 3,
                Age = 41,
                Name = "Shlomo"
            };
            Student dannyOther = new Student
            {
                Id = 4,
                Age = 18,
                Name = "Danny"
            };
            ClassRoom room = new ClassRoom();
            room.Add(danny);
            room.Add(dannyOther);
            room.Add(moshe);
            Console.WriteLine($"room[1]: {room[1]}");
            room[1] = shlomo;
            Console.WriteLine($"room[3]: {room[3]}");
            room.Add(danny);

            var dayys = room["Danny"];
            Console.WriteLine("All dannys:");
            dayys.ForEach(_ => Console.WriteLine(_));

            // logical?
            //room["Danny"] = 10;

            // looks familiar?
            //Dictionary<string, string> d1 = new Dictionary<string, string>();
            //d1["hello"]
            //d1.getItemByKey("Hello");
        }
    }
}
