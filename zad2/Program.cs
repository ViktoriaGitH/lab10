using System;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion1 = new Lion(190, 120, "Panthera leo", "Various");
            lion1.DisplayInfo();

            AfricanLion africanLion1 = new AfricanLion(200, 130);
            africanLion1.DisplayInfo();

            AsiaticLion asiaticLion1 = new AsiaticLion(180, 110);
            asiaticLion1.DisplayInfo();
        }
    }



    public class Lion
    {
        private double weight;
        private double height;
        private string latinName;
        private string habitat;

        public Lion(double weight, double height)
        {
            this.weight = weight;
            this.height = height;
        }

        public Lion(double weight, double height, string latinName, string habitat)
        {
            this.weight = weight;
            this.height = height;
            this.latinName = latinName;
            this.habitat = habitat;
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public string LatinName
        {
            get { return latinName; }
            set {  latinName = value; }
        }

        public string Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Лъв: Латинско име - {latinName}, Тегло - {weight}, Височина - {height}, Среда - {habitat}");
        }
    }

    public class AsiaticLion : Lion
    {
        public AsiaticLion (double weight , double height)
            :base(weight, height , "Panthera leo persica" , "Asia")
        { 
        }
    }

    public class AfricanLion : Lion
    {
        public AfricanLion(double weight, double height)
            : base(weight, height, "Panthera leo leo", "Africa")
        {
        }
    }


}