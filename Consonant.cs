namespace CSharp.NameGenerator
{
    public class Consonant : Phonetic
    {
        public Consonant(string chars = "bcdfghjklmnpqrstvwxyz")
        {
            this.SetValue(chars);
        }
    }
}