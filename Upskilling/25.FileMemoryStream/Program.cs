using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== FileStream and MemoryStream Demo =====\n");

        Console.Write("Enter the name of the text file to create/read: ");
        string fileName = Console.ReadLine();

        Console.Write("\nEnter some text to write into the file:\n");
        string content = Console.ReadLine();

        // ----------------------------
        // Writing to FileStream
        // ----------------------------
        using (FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
        {
            byte[] data = Encoding.UTF8.GetBytes(content);
            fileStream.Write(data, 0, data.Length);
        }

        Console.WriteLine("\nText written successfully.");

        // ----------------------------
        // Reading from FileStream
        // ----------------------------
        using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[fileStream.Length];

            fileStream.Read(buffer, 0, buffer.Length);

            string fileContent = Encoding.UTF8.GetString(buffer);

            Console.WriteLine("\nContent Read From File:");
            Console.WriteLine(fileContent);
        }

        // ----------------------------
        // MemoryStream
        // ----------------------------
        Console.Write("\nEnter text to store in MemoryStream: ");
        string memoryText = Console.ReadLine();

        using (MemoryStream memoryStream = new MemoryStream())
        {
            byte[] memoryBytes = Encoding.UTF8.GetBytes(memoryText);

            memoryStream.Write(memoryBytes, 0, memoryBytes.Length);

            Console.WriteLine("\nNumber of Bytes Written: " + memoryStream.Length);

            memoryStream.Position = 0;

            byte[] readBytes = memoryStream.ToArray();

            Console.WriteLine("MemoryStream Content:");
            Console.WriteLine(Encoding.UTF8.GetString(readBytes));
        }

        Console.WriteLine("\nProgram Completed Successfully.");
    }
}