class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Enter the text: ");
        string input = Console.ReadLine();
        Console.WriteLine();

        //string text = "29535123p48723487597645723645";
        FindAndFillNumbers(input);
    
    }

    static void FindAndFillNumbers(string text)
    {
        long sum = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsDigit(text[i]))
            {
                for (int j = i + 1; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        string subText = text.Substring(i, j - i + 1);
                        if (IsOnlyDigit(subText))
                        {
                            MarkingSubText(text, i, j);
                            sum += long.Parse(subText);
                            break;
                        }

                    }
                }
            } 
        }

        Console.WriteLine("\nSumma = " + sum);
    }

     static bool IsOnlyDigit(String str)
    {
        foreach (char c in str)
        {
            if (!char.IsDigit(c)) return false;
        }
        return true;
    }

     static void MarkingSubText(string fullText, int start, int end)
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            if (i >= start && i <= end)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write(fullText[i]);
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
    }

}



