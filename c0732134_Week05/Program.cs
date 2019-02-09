using System;

namespace c0732134_Week05
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator e = new Elevator();
            e.setup();
            Console.ReadLine();
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
        Node head;
        Node firstFloor;
        Node secondFloor;
        Node thirdFloor;
        Node fourthFloor;

        public void setup()
        {
            firstFloor = new Node();
            secondFloor = new Node();
            thirdFloor = new Node();
            fourthFloor = new Node();

            head = firstFloor;

            firstFloor.floorNumber = "First Floor";
            secondFloor.floorNumber = "Second Floor";
            thirdFloor.floorNumber = "Third Floor";
            fourthFloor.floorNumber = "Fourth Floor";
            
            firstFloor.elevatorUp = secondFloor;
            secondFloor.elevatorUp = thirdFloor;
            thirdFloor.elevatorUp = fourthFloor;
            fourthFloor.elevatorUp = null;

            
            //Console.WriteLine("The Floor Number is : " + firstFloor.floorNumber);
            //Console.WriteLine("The Floor Number is : " + secondFloor.floorNumber);
            //Console.ReadLine();
        }

        public void makeTreeTraversalList()
        {
            Node temp;
            temp = head;
            while (temp != null)
            {
                temp = temp.elevatorUp;
                Console.WriteLine(temp.floorNumber);
                    
            }
        }
    }
}
