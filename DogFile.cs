using System; 
using System.IO;
namespace OOP_DOG
{
    public class DogFile
    {
        private string fileName;

        public DogFile(string fileName)
        {
            this.fileName = fileName;
        }
        public Dog [] GetAllDogs()
        {
            Dog [] myDogs = new Dog [50];

            Dog.SetCount(0);

            StreamReader inFile = new StreamReader(fileName);

            string line = inFile.ReadLine();

            while (line != null)
            {
                string [] data = line.Split('#');

                myDogs[Dog.GetCount()] = new Dog(data[0], data[1], int.Parse(data[2]));

                Dog.IncCount();

                line = inFile.ReadLine();
            }

            inFile.Close();

            return myDogs;
        }
    }
}