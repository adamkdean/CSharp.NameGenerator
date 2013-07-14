namespace CSharp.NameGenerator
{
    public class Vowel : Phonetic
    {
        public Vowel(string chars = "aeiou")
        {
            this.SetValue(chars);
        }
    }
}