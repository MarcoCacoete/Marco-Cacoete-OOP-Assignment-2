using System.Runtime.InteropServices.JavaScript;

namespace OOP_assignment_2;
using System.IO;
public  class Statistics
{
    public static string DataString(string userName,double userPercentage,double total)
    {
        string UserStats ="User: " + userName+" has answered "+ userPercentage+"% of "+total+" answers correctly. "+ DateTime.Now;
        FileLoader(UserStats);
        return UserStats;
    }
    public static double Percentage(double correct, double wrong)
    {
        double Total = correct + wrong;
        double FinalPercentage = Math.Round((correct / Total)*100,1);
        Console.WriteLine("Percentage of correct answers: "+FinalPercentage+"%");
        return FinalPercentage;
    }
  
    private static void FileLoader(string dataString)
    {
        List<string> StatsList = File.ReadAllLines("Statistics.txt").ToList();
        StatList(StatsList,dataString);
    }

    private static void FileWriter(List<string> list)
    {
        foreach(string i in list)
        {
            Console.WriteLine(i);
        }
        File.WriteAllLines("Statistics.txt",list);
    }
    private static void StatList(List<string> statsList,string dataString)
    {
        statsList.Add(dataString);
        FileWriter(statsList);
    }
}
