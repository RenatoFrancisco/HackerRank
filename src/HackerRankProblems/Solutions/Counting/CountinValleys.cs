public class Countingvalleys
{
    public static int Resolve(int steps, string path)
    {
        var seaLevel = 0;
        var valleys = 0;
        
        foreach (var step in path)
        {
           if (step == 'U') seaLevel++;
           else seaLevel--;

           if (step == 'U' && seaLevel == 0) valleys++;
        }

        return valleys;
    }
}