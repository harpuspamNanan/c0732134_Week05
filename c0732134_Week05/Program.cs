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
            secondFloor = new Node();
            thirdFloor = new Node();
            fourthFloor = new Node();

            firstFloor.floorNumber = "First Floor";
            secondFloor.floorNumber = "Second Floor";
            thirdFloor.floorNumber = "Third Floor";
            fourthFloor.floorNumber = "Fourth Floor";
            
            firstFloor.elevatorUp = secondFloor;
            secondFloor.elevatorUp = thirdFloor;
            thirdFloor.elevatorUp = fourthFloor;
            fourthFloor.elevatorUp = null;

            Console.WriteLine("The Floor Number is : " + firstFloor.floorNumber);
            Console.WriteLine("The Floor Number is : " + secondFloor.floorNumber);
            Console.ReadLine();
        }
    }
}
