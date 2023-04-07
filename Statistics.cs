namespace OOP_assignment_2;

public abstract class Statistics
{
    
    protected abstract void StatList(List<string> StatsList, string DataString);
    protected abstract void FileLoader(string DataString);


}

public class Stats : Statistics
{
 
    protected override void StatList(List<string> StatsList,string DataString)
    {
        
        List<string> PercentageList = new List<string>();
        
        
        StatsList.Add(DataString);
        foreach(string i in PercentageList)
        {
            Console.WriteLine(i);
        }
        
    }
    
    protected override void FileLoader(string DataString)
    {
        var StatsFile = File.ReadAllLines("Statistics.txt");
        var StatsList = new List<string>(StatsFile);
        StatList(StatsList,DataString);
    }
    
    
}