using DevDash.Domain.BaseModels.Responses;

namespace DevDash.Domain.BaseViewModels
{
    public class DashBaseResultViewModel
    {
        public DashResponse ResposnseMessages { get; set; }
        public bool HasError { get; set; }
    }
}
