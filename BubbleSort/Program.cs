using System.ComponentModel;

namespace ordanation
{
    public class BubbleSort
    {
        int[] array;
        int arraySize;

        //construtor
        public BubbleSort()
        {
            this.array = createArray();
            int arraySize = 0;

        }

        //main
        public static void Main(string[] args)
        {
            var BubbleSort = new BubbleSort();
            BubbleSort.AddElement(BubbleSort.array, 2);
            BubbleSort.AddElement(BubbleSort.array, 5);
            Console.WriteLine(BubbleSort.ShowArray(BubbleSort.array, BubbleSort.arraySize));
        }

        public int[] createArray()
        {
            Console.WriteLine("Digite o tamanho do vetor:");
            int vetSize = Convert.ToInt32(Console.ReadLine());

            int[] vet = new int[vetSize];
            return vet;
        }
        public string ShowArray(int[] array, int arraySize)
        {
            if (arraySize == 0)
            {
                Console.WriteLine("Empty array");
                return null;
            }
            else
            {
                string vectorView = "Vetor:[";
                for (int i = 0; i < arraySize; i++)
                {
                    if (i == arraySize-1)
                    {
                        vectorView += Convert.ToString(array[i]);
                    }
                    else
                    {
                        vectorView += Convert.ToString(array[i]) + ",";
                    }
                }
                return (vectorView + "]");
            }
        }
        public int[] AddElement(int[] vet, int element)
        {
            if (vet.Length <= arraySize)
            {
                Console.WriteLine("Full vector");
                return null;
            }
            else
            {
                vet[arraySize] = element;
                arraySize++;
                return vet;
            }
        }

        public void UserVetFilling()
        {

        }
    }
}