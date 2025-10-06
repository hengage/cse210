using System;
using System.Collections.Generic;
using System.IO;

public class ActivityLogger
{
    private const string LOG_FILE = "activity_log.txt";
    
    public static void LogActivity(string activityName)
    {
        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {activityName}";
        File.AppendAllText(LOG_FILE, logEntry + Environment.NewLine);
    }
    
    public static Dictionary<string, int> GetActivityCounts()
    {
        var counts = new Dictionary<string, int>();
        
        if (!File.Exists(LOG_FILE))
            return counts;
            
        foreach (string line in File.ReadAllLines(LOG_FILE))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            
            string activityName = line.Split(" - ")[1];
            counts[activityName] = counts.ContainsKey(activityName) ? counts[activityName] + 1 : 1;
        }
        
        return counts;
    }
    
    public static void DisplayActivityCounts()
    {
        var counts = GetActivityCounts();
        
        if (counts.Count == 0)
        {
            Console.WriteLine("No activities have been performed yet.");
            return;
        }
        
        Console.WriteLine("\n--- Activity Performance Log ---");
        foreach (var activity in counts)
        {
            Console.WriteLine($"{activity.Key}: {activity.Value} time(s)");
        }
        Console.WriteLine();
    }
}