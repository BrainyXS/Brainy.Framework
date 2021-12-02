using Brainy.Framework.Contract.Navigation;
using ReactiveUI;

namespace Brainy.Framework.Contract
{
    public class ViewModelBase : ReactiveObject
    {
        public INavigation Navigation { get; set; }

    }
}