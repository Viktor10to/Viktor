namespace Test;

using System;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
;
        BubbleSort(arr);

        int min = arr[0];
        int count = 1;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == min + count)
            {
                count++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Сортиран масив:");
        Console.WriteLine(string.Join(", ", arr));

        Console.WriteLine("\nНамерена поредица:");
        for (int i = 0; i < count; i++)
        {
            Console.Write((min + i) + (i < count - 1 ? ", " : "\n")); 
        }

        Console.WriteLine($"\nДължина на поредицата: {count}");
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    // разменяне
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    swapped = true;
                }
            }
            n--; // всяка итерация поставя най-голямото число в края
        } while (swapped);
    }
}


