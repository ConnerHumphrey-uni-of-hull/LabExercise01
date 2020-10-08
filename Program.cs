using System;
using System.Text;
using System.IO;


namespace LabExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = null;
            using (var reader = new StreamReader("input.txt"))
            {
                data = reader.ReadToEnd();
            }

            // converts the each char in the sting to lower
            data = data.ToLower();
            
            
            var sb = new StringBuilder();
            foreach (char c in data)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
                
            }
            data = sb.ToString();

            string [] dataArray = data.Split(" ");
           

            Array.Sort(dataArray);
         

            data = string.Join(" ", dataArray);

            Console.WriteLine(data);

            
            using (var writer = new StreamWriter(@"E:\software engineering labs\LabExercise01\output.txt"))
            {
                writer.Write(data);
            }





    }
    }
}
