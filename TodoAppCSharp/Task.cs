namespace TodoAppCSharp
{
    public class Task
    {
        public string? Description { get; set; }
        public bool IsDone { get; set; }

        public override string ToString()
        {
            return IsDone ? $"✔ {Description}" : Description;
        }
    }
}
