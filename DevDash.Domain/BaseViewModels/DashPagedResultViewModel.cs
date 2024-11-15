using DevDash.Domain.ViewModels;

namespace DevDash.Domain.BaseViewModels
{
    public class DashPagedResultViewModel<T> : DashBaseResultViewModel where T : DashBaseViewModel
    {
        public IQueryable<T> Result { get; set; }
    }
}
