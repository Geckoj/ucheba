using System;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int previousElement = 0;
        int currentElement = 0;

        int maxEqualEvenCount = 0;
        int equalEvenCount = 0;

        int oneCount = 0;
        int minOneCount = int.MaxValue;
        int memOne = 0;

        int maxEvenSumm = 0;
        int evenSumm = 0;

        for (int i = 0; i < n; i++)
        {
            currentElement = Convert.ToInt32(Console.ReadLine());

            if (currentElement % 2 == 0)
            {
                if (currentElement == previousElement)
                {
                    equalEvenCount++;
                }
                else
                {
                    equalEvenCount = 1;
                }
                maxEqualEvenCount = Math.Max(maxEqualEvenCount, equalEvenCount);
            }
            else
            {
                equalEvenCount = 0;
            }


            //================================//
            memOne = oneCount;
            
            if (currentElement == 1)
            {
                oneCount++;
            }
            else
            {
                oneCount = 0;
            }

            if (oneCount == 0 && memOne != 0)
            {
                minOneCount = Math.Min(minOneCount, memOne);
            }

            previousElement = currentElement;
            Console.WriteLine($"cur: {oneCount},  min: {minOneCount},  mem: {memOne}");

            //===============================//

            if (currentElement % 2 == 0)
            {
                evenSumm += currentElement;
                maxEvenSumm = Math.Max(maxEvenSumm, evenSumm);

            }
            else
            {
                evenSumm = 0;
            }

        }
        if (minOneCount == int.MaxValue)
        {
            minOneCount = Math.Min(minOneCount, oneCount);
        }

        maxEvenSumm = Math.Max(evenSumm, maxEvenSumm);

        Console.WriteLine($"минимальная длина последовательности из единиц: {minOneCount}");
        Console.WriteLine($"максимальная длина четный равных элементов: {maxEqualEvenCount}");
        Console.WriteLine($"максимальная сумма идущих подряд четных элеметов: {maxEvenSumm}");
    }
}
