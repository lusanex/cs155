namespace Homework2.Homework2Part1
{
    public class PigLatin
    {
        public void Run(string[]? args =null)
        {
            Console.WriteLine("Enter your first name:");
            string first = Console.ReadLine().ToLower();

            Console.WriteLine("Enter your last name:");
            string last = Console.ReadLine().ToLower();

            string pigLatinFirst = ConvertToPigLatin(first);
            string pigLatinLast = ConvertToPigLatin(last);

            Console.WriteLine($"Your name in Pig Latin is: {pigLatinFirst} {pigLatinLast}");
        }
        
        public string ConvertToPigLatin(string word)
        {
            if (string.IsNullOrEmpty(word))
                return word;

            // Move the first letter to the end and add "ay"
            string pigLatin = word.Substring(1) + word[0] + "ay";

            // Capitalize the first letter
            return char.ToUpper(pigLatin[0]) + pigLatin.Substring(1);
        }
    }
}
