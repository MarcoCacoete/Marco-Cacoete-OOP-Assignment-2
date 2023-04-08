namespace OOP_assignment_2;

public  class Statistics
{
    public static string DataString(string UserName,double UserPercentage)
    {
        string UserStats = Convert.ToString(UserPercentage);
        UserStats = UserName +" "+ UserStats;
        Console.WriteLine(UserStats);
        FileLoader(UserStats);
        return UserStats;
    }
    public static double Percentage(double Correct, double Wrong)
    {
        double Total = Correct + Wrong;
        double FinalPercentage = Math.Round((Correct / Total)*100,1);
        Console.WriteLine(Total);
        Console.WriteLine(Test.CorrectQuestions);
        Console.WriteLine(Test.WrongQuestions);
        Console.WriteLine("Percentage of correct answers: "+FinalPercentage+"%");
        return FinalPercentage;
    }
   private static void StatList(List<string> StatsList,string DataString)
    {
        
        List<string> PercentageList = new List<string>();
        
        
        StatsList.Add(DataString);
        foreach(string i in PercentageList)
        {
            Console.WriteLine(i);
        }
        
    }
    private static void FileLoader(string DataString)
    {
        var StatsFile = File.ReadAllLines("Statistics.txt");
        var StatsList = new List<string>(StatsFile);
        StatList(StatsList,DataString);
    }
}
