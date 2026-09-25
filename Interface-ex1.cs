// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// namespace Interface_2
// {
//     interface IAnimal
//     {
//         void Eat();
//     }
//     interface IFlyingObject
//     {
//         void Fly();
//     }
//     public class Bird : IAnimal, IFlyingObject
//     {
//         public void Eat()
//         {
//             Console.WriteLine("I'm eating");
//         }
//         public void Fly()
//         {
//             Console.WriteLine("I'm flying");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             IAnimal iAn = new Bird();
//             iAn.Eat();
//             IFlyingObject iFl = new Bird();
//             iFl.Fly();
//         }
//     }
// }
