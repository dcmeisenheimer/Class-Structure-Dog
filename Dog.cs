using System;
using System.IO;
namespace OOP_DOG
{
    public class Dog
    {
        private string name;
        private string breed;
        private int weight;

        private static int count;
        
        public Dog(string name, string breed, int weight)
        {
            this.name = name;
            this.breed= breed;
            this.weight = weight;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetBreed(string breed)
        {
            this.breed = breed;
        }
        public string GetBreed()
        {
            return breed;
        }
        public void SetWeight(int weight)
        {
            this.weight = weight;
        }
        public int GetWeight()
        {
            return weight;
        }
        public static void SetCount(int temp)
        {
            count = temp;
        }
        public static int GetCount()
        {
            return count;
        }
        public static void IncCount()
        {
            count++;
        }
        public override string ToString()
        {
            return name  + " is a " + breed + " and weighs " + weight + "lbs.";
        }
        public int CompareTo(Dog compareDog)
        {
            return this.breed.CompareTo(compareDog.GetBreed());
        }
    }
}