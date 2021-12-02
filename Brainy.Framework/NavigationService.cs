using System;
using System.Threading.Tasks;
using Autofac;
using Avalonia.Controls;
using Brainy.Framework.Contract;

namespace Brainy.Framework
{
    public class NavigationService : INavigation
    {
        private UserControl _frame;
        private IContainer _container;
        private string _assembly;

        public async Task NavigateToAsync<T>() where T : ViewModelBase
        {
            var viewModelType = typeof(T);
            var viewModelInstance = _container.Resolve<T>();
            viewModelInstance.Navigation = this;
            var viewName = viewModelType.Name.Substring(0, viewModelType.Name.Length - "Model".Length);
            var typeSearch = $"{viewModelType.Namespace}." + viewName + $", {_assembly}";
            var viewType = Type.GetType(typeSearch);

            if (viewType != null)
            {
                var viewInstance = Activator.CreateInstance(viewType) as UserControl;


                _frame.Content = viewInstance ??
                                 throw new ApplicationException($"View zu {viewModelType.Name} nicht gefunden");

                viewInstance.DataContext = viewModelInstance;
            }
            else
            {
                throw new Exception("Die View zu " + viewModelType.Name + " konnte nicht gefunden werden");
            }

            await Task.CompletedTask;
        }

        public void StartLoading()
        {
        }

        public void EndLoading()
        {
        }


        public void Setup(UserControl frame, ContainerBuilder builder, string assembly)
        {
            _container = builder.Build();
            _frame = frame;
            _assembly = assembly;
        }
    }
}