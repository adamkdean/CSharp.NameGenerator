using System;

namespace CSharp.NameGenerator
{
    public class Phonetic
    {
        private static Random rng;
        private Random Rng
        {
            get
            {
                if (rng == null) rng = new Random();
                return rng;
            }
        }

        public char Value { get; private set; }

        protected void SetValue(string chars)
        {
            var index = Rng.Next(0, chars.Length);
            Value = chars[index];
        }
    }
}