using System;
using System.Threading.Tasks;

class Program
{
    // Asynchronous method to simulate file upload
    static async Task<string> UploadFileAsync(string fileName)
    {
        Console.WriteLine("\nUploading file...");
        
        // Simulate a 3-second delay
        await Task.Delay(3000);

        // Simulate exception for invalid filename
        if (string.IsNullOrWhiteSpace(fileName))
        {
            throw new ArgumentException("File name cannot be empty.");
        }

        return $"File '{fileName}' uploaded successfully.";
    }

    static async Task Main(string[] args)
    {
        Console.WriteLine("===== Async File Upload Simulation =====");

        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        try
        {
            string result = await UploadFileAsync(fileName);

            Console.WriteLine(result);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("\nUpload Failed!");
            Console.WriteLine($"Reason: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nUnexpected Error!");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("\nProgram Finished.");
        }
    }
}