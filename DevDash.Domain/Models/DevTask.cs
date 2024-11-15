using DevDash.Domain.BaseModels;

namespace DevDash.Domain.Models
{
    public class DevTask : DashObject
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public Repository Repository { get; set; }
        public int RepositoryId { get; set; }
        public SubSystem SubSystem { get; set; }
        public int SubSystemId { get; set; }
        public DateTime TaskDate { get; set; }
    }
}
