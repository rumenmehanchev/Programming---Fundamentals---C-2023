namespace CharactersInRange
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            GetAllSignBetweenTwoChar(firstChar, secondChar);
        }

        static void GetAllSignBetweenTwoChar(char firstChar, char secondChar)
        {

            int startCharacter = Math.Min(firstChar, secondChar);
            int endCharacter = Math.Max(firstChar, secondChar);

            for (int i = startCharacter + 1; i < endCharacter; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}
