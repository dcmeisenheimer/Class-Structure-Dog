using System;
using System.IO;
namespace OOP_DOG
{
    public class DogReport
    {
        private Dog [] myDog;
        public DogReport(Dog [] myDog)
        {
            this.myDog = myDog;
        }
        public void CombinationReport()
        {
            for (int i = 0; i < Dog.GetCount() - 1; i++)
            {
                for (int j = i + 1; j < Dog.GetCount(); j++)
                {
                    int sum = myDog[i].GetWeight() + myDog[j].GetWeight();

                    if (sum > 75)
                    {
                        System.Console.WriteLine($"{myDog[i].GetName()} and {myDog[i].GetName()} have a combined weight of " + sum + " pounds");
                    }
                }
            }
        }
        public void PrintAvgWeight()
        {
            int sum = 0;
            for (int i = 0; i < Dog.GetCount(); i++)
            {
                sum += myDog[i].GetWeight();
            }
            System.Console.WriteLine("The average weight is " + (sum / Dog.GetCount()));
        }
        public void PrintAllDogs()
        {
            for (int i = 0; i < Dog.GetCount(); i++)
            {
                System.Console.WriteLine(myDog[i].ToString());
            }
        }
        public void WeightByBreed()
        {
            int sum = myDog[0].GetWeight();
            int count = 1;
            string curr = myDog[0].GetBreed();
            System.Console.WriteLine(myDog[0].ToString());

            for (int i = 1; i < Dog.GetCount(); i++)
            {
                if (curr == myDog[i].GetBreed())
                {
                    sum += myDog[i].GetWeight();
                    count++;
                    System.Console.WriteLine(myDog[i].ToString());

                }
                else
                {
                    ProcessBreak(ref curr,ref sum,ref count, i);
                    System.Console.WriteLine(myDog[i].ToString());
                }
            }

            ProcessBreak(ref curr,ref sum,ref count, 0);
        }
        private void ProcessBreak(ref string curr, ref int sum, ref int count, int i)
        {
            int avg = sum / count;
            System.Console.WriteLine($"{curr} average weight is {avg} pounds\n" );
            sum = myDog[i].GetWeight();
            count = 1;
            curr = myDog[i].GetBreed();
        }
    }
}