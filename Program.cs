using System;

namespace OOP_DOG
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog [] myDog = new Dog[50];
            DogFile myFile = new DogFile("dogs.txt");

            myDog = myFile.GetAllDogs();

            DogReport myReport = new DogReport(myDog);
            myReport.PrintAllDogs();
            System.Console.WriteLine("\n\n");
            
            DogUtility myUtility = new DogUtility(myDog);
            myUtility.SortByBreed();
            myReport.PrintAllDogs();
            System.Console.WriteLine("\n\n");
            //Control Break Report that prints average weight by breed
            myReport.WeightByBreed();
            
        }
    }
}
