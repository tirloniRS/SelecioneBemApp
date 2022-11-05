using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SelecioneBemApp.Models
{
    public class Interview
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; } = DateTime.Now;
        public DateTime End { get; set; }
        public Candidate candidate { get; set; }
        public ICollection<Question> Questions { get; set; } = new List<Question>();

        public Interview()
        {
        }

        public Interview(int id, string name, DateTime start, DateTime end, Candidate candidate)
        {
            Id = id;
            Name = name;
            Start = start;
            End = end;
            this.candidate = candidate;
        }
    }
}
