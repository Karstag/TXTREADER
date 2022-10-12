using System.IO;
using System.Text.RegularExpressions;

class ReadTxt
{
    static void Main(string[] args)
    {

        foreach (string file in Directory.GetFiles("D:/check", "*.txt", SearchOption.AllDirectories)) // file path 
        {
            string contest = File.ReadAllText(file);
            using (StreamReader reader = new StreamReader(file))
            {
                string keyword = "Password";
                while ((contest = reader.ReadLine()) != null)
                {

                    if (contest.Contains(keyword))
                    {
                        Console.WriteLine($"{contest}");

                    }
                }
            }

        }
        bool Exit = false;
        while (!Exit)
        {
            Exit = Console.ReadLine() == "exit";
        }
    }
}
