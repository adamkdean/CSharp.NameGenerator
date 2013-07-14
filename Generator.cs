using System;
using System.Text;

namespace CSharp.NameGenerator
{
    public static class Generator
    {
        public static string GenerateString(string pattern, string vowels = "", string consonants = "")
        {
            var sb = new StringBuilder();
            pattern = pattern.ToLower();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == 'c')
                {
                    if (consonants != "") sb.Append((new Consonant(consonants)).Value);
                    else sb.Append((new Consonant()).Value);
                }
                else if (pattern[i] == 'v')
                {
                    if (vowels != "") sb.Append((new Vowel(vowels)).Value);
                    else sb.Append((new Vowel()).Value);
                }
                else if (pattern[i] == ' ') sb.Append(" ");
            }

            return sb.ToString();
        }
    }
}