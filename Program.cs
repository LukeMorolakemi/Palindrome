namespace Palindrome;

  public class palindrome 
{


public static void Main(string[] args)
    {
        //STRING  MANIPULATION (PALINDROME)
        string Firstword = "Samuel";
        string reversedword = ReverseString(Firstword);

        Console.WriteLine($"First Word: {Firstword}");
        Console.WriteLine($"Reversed Word: {reversedword}");


        bool isPalindrome = IsPalindrome(Firstword);

        Console.WriteLine($"Is Palindrome: {isPalindrome}");
        //method checking if its a palindrome
        static bool IsPalindrome(string input)
        {
            string reversedString = ReverseString(input);
            return input.Replace(" ", "").Equals(reversedString.Replace(" ", ""), StringComparison.OrdinalIgnoreCase);
        }


        //method used in coverting to a charArray
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}