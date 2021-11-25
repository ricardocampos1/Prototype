using HouseModule.Rooms;
using System;

namespace HouseModule
{
    class Program
    {
        static void Main(string[] args)
        {
            var livingRoom = new Room
            {
                Name = "Sala de estar",
                Lenght = 3,
                Height = 3
            };

            var dinnerRoom = (Room)livingRoom.Clone();
            dinnerRoom.Name = "Sala de jantar";
            dinnerRoom.Height = 4;

            Console.WriteLine(livingRoom.GetDetails());
            Console.WriteLine(dinnerRoom.GetDetails());
        }
    }
}
