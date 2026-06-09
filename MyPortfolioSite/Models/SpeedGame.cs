namespace SpeedTracker.Models;
public class SpeedGame
{
    // Overall game timer
    public int Timer { get; set; }
    // Time per round to gain per round scores and overall average
    public TimeSpan Elapsed { get; set; }

    public List<double> RoundWpmHistory { get; set; } = new List<double>();
    public double RoundWpm { get; set; }
    public double Wpm { get; set; }
    public double AverageWpm { get; set; }
    public DateTime RoundStartTime { get; set; }
    public DateTime RoundEndTime { get; set; }

}
