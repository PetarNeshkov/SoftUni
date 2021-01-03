using System;

namespace Characters_in_Range__Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());
            CharactersInRange(firstCharacter, secondCharacter);
        }
        static void CharactersInRange(char firstCharacter,char secondCharacter)
        {
            if (firstCharacter>secondCharacter)
            {
                char temp;
                temp = firstCharacter;
                firstCharacter = secondCharacter;
                secondCharacter = temp;
            }
            for (int i = firstCharacter+1; i < secondCharacter; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
