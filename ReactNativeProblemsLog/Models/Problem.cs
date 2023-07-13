namespace ReactNativeProblemsLog.Models
{
    public class Problem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string? Solution { get; set; }
        public string? Url { get; set; }
        public DateTime LastModified { get; set; }
        public Problem()
        {
            LastModified = DateTime.Now;
        }
    }
}
