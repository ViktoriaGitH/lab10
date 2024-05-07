using System;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building(10.5, 200.0, "Иван Вазов 3");
            building1.DisplayInfo();

            House house1 = new House(8.0, 150.0, "Боровкса 45", 2, "Николай Иванов");
            house1.DisplayInfo();
            Console.WriteLine($"Жилищна площ: {house1.CalculateLivingArea()}");

            
            house1.Height = 9.0;
            house1.OwnerName = "Виолета Иванова";

            house1.DisplayInfo();
        }
    }



    public class Building
    {
        
        private double height;
        private double area;
        private string address;

        
        public Building(double height, double area, string address)
        {
            this.height = height;
            this.area = area;
            this.address = address;
        }

        
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Сграда: Адрес - {address}, Височина - {height}, Площ - {area}");
        }
    }

    public class House : Building
    {
        
        private int numberOfFloors;
        private string ownerName;

        public House(double height, double area, string address, int numberOfFloors, string ownerName)
            : base(height, area, address)
        {
            this.numberOfFloors = numberOfFloors;
            this.ownerName = ownerName;
        }

        public int NumberOfFloors
        {
            get { return numberOfFloors; }
            set { numberOfFloors = value; }
        }

        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Къща: Собственик - {ownerName}, Етаж - {numberOfFloors}");
        }

        //площ на къщата
        public double CalculateLivingArea()
        {
           
            return Area * numberOfFloors;
        }
    }
}