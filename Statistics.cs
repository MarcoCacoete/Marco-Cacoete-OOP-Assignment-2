using System.Runtime.InteropServices.JavaScript;

namespace OOP_assignment_2;
using System.IO;
public  class Statistics
{   // Class responsible for calculating user statistics and writing them into a txt file.
    public static string DataString(string userName,double userPercentage,double total)  // Method for formatting the string to be added to file.
    {
        string UserStats ="User: " + userName+" has answered "+ userPercentage+"% of "+total+" answers correctly. "+ DateTime.Now;
        FileLoader(UserStats);  // ^ Concatenates 4 variables as well as some text and adds date and time at the end to differentiate entries. Then calls fileloader method with new string.
        return UserStats;
    }
    public static double Percentage(double correct, double wrong) //This method calculates percentage of correct answer, it is used recursively every time user answers question.
    {
        double Total = correct + wrong;                           // Updates total attemps counter.
        double FinalPercentage = Math.Round((correct / Total)*100,1);   // Rounds percentage to 1 decimal place.
        Console.WriteLine("Percentage of correct answers: "+FinalPercentage+"%"); //Message printed after every answer.
        return FinalPercentage;
    }
  
    private static void FileLoader(string dataString) //Method responsible for reading txt file and adding lines to a list.
    {
        List<string> StatsList = File.ReadAllLines("Statistics.txt").ToList(); // Creates a list of strings by reading all lines in txt file adding them an array and converting to list.
        StatList(StatsList,dataString);
    }

    private static void FileWriter(List<string> list) // Method responsible for writing updated list to existing text file with new statistical entries.
    {
        foreach(string i in list)  //For loop to print all data entries in txt file when program terminates.
        {
            Console.WriteLine(i);
        }
        File.WriteAllLines("Statistics.txt",list); //Using file.writealllines it registers the list elements in same file, overwriting existing entries to prevent repeated results.
    }
    private static void StatList(List<string> statsList,string dataString) //Method to add an element to a list and calling FileWriter method.
    {
        statsList.Add(dataString);
        FileWriter(statsList);
    }
}
