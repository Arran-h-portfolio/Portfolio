namespace GameProject.Models;
public class MemoryGame
{
    public string? Sentence { get; set; }
    public int CurrentSentenceIndex { get; set; }
    public string? CurrentSentence { get; set; }
    public bool IsGameOver { get; set; }
    public bool IsGameStarted { get; set; } = false;
    public int CorrectSentencesTyped { get; set; }
    public int TotalSentences { get; set; }
    // Setting up rounds system
    public int CurrentRound { get; set; } = 1;
    public Dictionary<int, Dictionary<int, string>>? Rounds { get; set; }
    public Dictionary<int, string>? Sentences { get; set; }
    public int Score { get; set; }
    public int HighScore { get; set; }
    public int PreviousHighScore { get; set; }


}

