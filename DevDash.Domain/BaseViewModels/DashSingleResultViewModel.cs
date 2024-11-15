using DevDash.Domain.ViewModels;

namespace DevDash.Domain.BaseViewModels
{
    public class DashSingleResultViewModel<T> : DashBaseResultViewModel where T : DashBaseViewModel
    {
        public T? Result { get; set; }
    }
}
