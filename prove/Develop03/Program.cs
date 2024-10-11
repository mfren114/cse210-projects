using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Console.WriteLine("Hello Develop03 World!");

        Reference scriptRef = new Reference("1 Nephi", "22", "2");
        Scripture scripture = new Scripture(scriptRef, "And I, Nephi, said unto them: Behold they were manifest unto the prophet by the voice of the Spirit; for by the Spirit are all things made known unto the prophets, which shall come upon the children of men according to the flesh.");
        Word word = new Word(scripture);
        
        string user = "";
        while (user != "quit")
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptRef.RefDisplay(), word.RefDisplay()));
            user = Console.ReadLine();
            word.RemoveWords();
        }
        
    }
}