namespace SelecioneBemApp.Models
{
    public class Opportunity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }

        public string Manager { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }

    }
}
