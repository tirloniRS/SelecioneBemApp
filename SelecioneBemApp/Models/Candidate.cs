using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SelecioneBemApp.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        [Display(Name = "Nome do Candidato")]
        public string Name { get; set; }
        [Display(Name = "Celular")]
        public string CellNumber { get; set; }
        [Display(Name = "Nome do Candidato")]
        public string Email { get; set; }
        public string Linkedin { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Interview interview { get; set; }

        public Candidate()
        {
        }

        public Candidate(int id, string name, string cellNumber, string email, string linkedin, string city, string state, Interview interview)
        {
            Id = id;
            Name = name;
            CellNumber = cellNumber;
            Email = email;
            Linkedin = linkedin;
            City = city;
            State = state;
            this.interview = interview;
        }

    }
}
