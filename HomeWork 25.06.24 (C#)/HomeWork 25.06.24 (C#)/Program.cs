namespace HomeWork_25._06._24__C__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //я надеюсь так считается)) я пытался максимально коротко сделать
            string text1 = "Alex"; 
            Console.WriteLine(text1);
            char[] charArray1 = text1.ToCharArray();
            HashSet<string> charSet1 = new HashSet<string>();

            for (int i = 0; i < charArray1.Length; i++)
            {
                Random.Shared.Shuffle(charArray1);
                charSet1.Add(new string(charArray1));
            }

            foreach(var c in charSet1)
            {
                Console.WriteLine(c);
            }
        }
    }
}
