namespace OOP_DOG
{
    public class DogUtility
    {
        private Dog [] myDog;
        public DogUtility(Dog [] myDog)
        {
            this.myDog = myDog;
        }
        public void SortByBreed()
        {
            for(int i = 0; i < Dog.GetCount() -1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Dog.GetCount(); j++)
                {
                    if (myDog[j].CompareTo(myDog[min])< 0)
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    Swap(min, i);
                }
            }
           
        }
        public void Swap(int x, int y)
        {
            Dog temp = myDog[x];
            myDog[x] = myDog[y];
            myDog[y] = temp;
        }
    }
}