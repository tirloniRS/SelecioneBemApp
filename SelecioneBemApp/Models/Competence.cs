namespace SelecioneBemApp.Models
{
    public class Competence
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Opportunity> Opportunities { get; set; } = new List<Opportunity>();
        public Question question { get; set; }

        public Competence()
        {
        }

        public Competence(int id, string name, string description, Question question)
        {
            Id = id;
            Name = name;
            Description = description;
            this.question = question;
        }
    }
}
