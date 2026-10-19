using System;

namespace Assim04
{
    internal class Program
    {
        // Method for Q3
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        // Method for Q4
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        // Method for Q5
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        // Method for Q6
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        // Method for Q7
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

        // Method for Q8
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

        // Method for Q9
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }

        // Method for Q10 and Q11 (optional parameter)
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine("Title: " + title + " Pages: " + pages);
        }

        // Method for Q12 (params keyword)
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string t in titles)
            {
                Console.WriteLine(t);
            }
        }

        static void Main(string[] args)
        {
            #region Q1
            // Create a one-dimensional array double prices with values 25 5 40 0 33 75 Print the second price index 1
            double[] prices1 = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices1[1]); // print second price
            #endregion

            #region Q2
            // Create a 2x2 multidimensional array int shelfCopies where shelf 0 has 3 5 copies and shelf 1 has 1 4 copies Print the number of copies on shelf 1 slot 0
            int[,] shelfCopies = {
                { 3, 5 },
                { 1, 4 }
            };
            Console.WriteLine(shelfCopies[1, 0]); // print shelf 1 slot 0
            #endregion

            #region Q3
            // Write a method called PrintWelcomeMessage that takes no parameters and prints Welcome to the Library Call it from Main
            PrintWelcomeMessage();
            #endregion

            #region Q4
            // Write a method PrintBookTitle that prints Book title plus title Call it with Clean Code
            PrintBookTitle("Clean Code");
            #endregion

            #region Q5
            // Write a method AddBonusPages that adds 50 to pages Call it with a variable int pages = 400 and print pages afterward What do you expect to see and why
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages); // expect 400 because value type passes copy only
            #endregion

            #region Q6
            // Write a method ApplyDiscount that subtracts 5 from prices index 0 Call it with double array prices and print prices index 0 afterward What do you expect to see and why
            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            Console.WriteLine(prices[0]); // expect 20 5 because array is reference type and modifies original
            #endregion

            #region Q7
            // Rewrite the method from question 5 as AddBonusPagesByRef using ref Call it and print pages afterward How is the result different from question 5
            int pagesRef = 400;
            AddBonusPagesByRef(ref pagesRef);
            Console.WriteLine(pagesRef); // expect 450 because ref passes original variable reference
            #endregion

            #region Q8
            // Write a method ReplaceArray using ref that replaces prices entirely with a new array Call it with your prices array and print prices Length afterward
            double[] myPrices = { 1.0, 2.0 };
            ReplaceArray(ref myPrices);
            Console.WriteLine(myPrices.Length); // expect 3 because array reference pointed to new array
            #endregion

            #region Q9
            // Write a method TryGetPrice that returns true and sets price to 25 5 if title is Clean Code otherwise returns false and sets price to 0 Call it and print the price if found
            double foundPrice;
            if (TryGetPrice("Clean Code", out foundPrice))
            {
                Console.WriteLine(foundPrice);
            }
            #endregion

            #region Q10
            // Write a method PrintBookInfo where pages is optional Call it once with only a title and once passing both a title and pages
            PrintBookInfo("Clean Code");
            PrintBookInfo("Refactoring", 450);
            #endregion

            #region Q11
            // Using the PrintBookInfo method from the question above call it by naming the parameters passing pages before title
            PrintBookInfo(pages: 400, title: "C Sharp Guide");
            #endregion

            #region Q12
            // Write a method PrintAllTitles using params that prints each title on its own line Call it with three book titles
            PrintAllTitles("Clean Code", "Refactoring", "The Pragmatic Programmer");
            #endregion
        }
    }
}