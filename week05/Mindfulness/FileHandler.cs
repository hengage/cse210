
public class FileHandler
{

   public List<string> LoadFromCsv(string filePath)
    {
        List<string> lines = new List<string>();
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                        lines.Add(line.Trim());
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
        return lines;
    }
}