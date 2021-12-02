using Autofac;
using Brainy.Framework.Testtool.TestPage;
using Brainy.Framework.Testtool.TestPage2;

namespace Brainy.Framework.Testtool
{
    public class MainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainViewModel>();
            builder.RegisterType<OtherViewModel>();
        }
    }
}