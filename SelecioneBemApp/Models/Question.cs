namespace SelecioneBemApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Grade { get; set; }

        public ICollection<Interview> interviews { get; set; } = new List<Interview>();

        public Question()
        {
        }

        public Question(int id, string title, int grade)
        {
            Id = id;
            Title = title;
            Grade = grade;
        }
    }

}
