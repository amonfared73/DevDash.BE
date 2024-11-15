using DevDash.Domain.BaseModels;

namespace DevDash.Domain.Models
{
    public class Repository : DashObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
