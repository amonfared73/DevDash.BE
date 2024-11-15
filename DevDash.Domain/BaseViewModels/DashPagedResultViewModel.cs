using DevDash.Domain.ViewModels;

namespace DevDash.Domain.BaseViewModels
{
    public class DashPagedResultViewModel<T> : DashBaseResultViewModel where T : DashBaseViewModel
    {
        public IEnumerable<T> Result { get; set; }
    }
}
