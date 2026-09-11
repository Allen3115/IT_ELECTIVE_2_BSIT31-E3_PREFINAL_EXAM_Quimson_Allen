namespace MVCExam_Quimson.Models
{
    public class Question
    {
        public int Number { get; set; }
        public string Text { get; set; } = string.Empty;
        public Dictionary<string, string> Choices { get; set; } = new();
        public string SelectedAnswer { get; set; } = string.Empty;
        public string CorrectAnswer { get; set; } = string.Empty;
        public string Topic { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
        public bool IsCorrect => SelectedAnswer.Equals(CorrectAnswer, StringComparison.OrdinalIgnoreCase);
    }
}