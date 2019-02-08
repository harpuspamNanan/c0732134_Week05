using System;

namespace c0732134_Week05
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator e = new Elevator();
            e.run();
        }
    }
    class Node
    {
        public Node() { }
        public Node floor;
        public Node elevatorUp;
        public string floorNumber;
    }
    class Elevator
    {
        Node firstFloor;
        Node secondFloor;
        Node thirdFloor;
        Node fourthFloor;

        public void run()
        {
            firstFloor = new Node();
            firstFloor.floorNumber = "First Floor";
            Console.WriteLine("The Floor Number is : " + firstFloor.floorNumber);
            firstFloor.elevatorUp = secondFloor;
            secondFloor.floorNumber = "Second Floor";
            Console.WriteLine("The Floor Number is : " + secondFloor.floorNumber);
            Console.ReadLine();
        }
    }
}
