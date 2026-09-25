using System;
namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[]
            {
 new Car()
{
 Name = "Zinco"
 }, new Car()
 {
 Name = "VW"
 }, new Car()
 {
 Name = "BMW"
 }
            };
            Array.Sort(cars);
            Array.ForEach(cars, x => Console.WriteLine(x.Name));
        }
    }
    public class Car : IComparable
    {
        public string Name
        {
            get;
            set;
        }
        public int MaxSpeed
        {
            get;
            set;
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Car))
            {
                throw new ArgumentException("Compared Object is not of car");
            }
            Car car = obj as Car;
            return Name.CompareTo(car.Name);
        }
    }
}