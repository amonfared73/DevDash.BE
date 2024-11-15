using DevDash.Domain.BaseModels;

namespace DevDash.Domain.Models.Dash
{
    public class Repository : DashObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
