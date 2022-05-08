using Prism.Ioc;
using Prism.Regions;
using System.Windows;
using WPF_stock_client.Views;

namespace WPF_stock_client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainWindow>();
            containerRegistry.RegisterForNavigation<View1>();
            containerRegistry.RegisterForNavigation<View2>();
        }

        // 在這裡指定 Region 要顯示的 View ，也是可行的
        protected override void Initialize()
        {
            base.Initialize();
            //IContainerProvider container = (App.Current as PrismApplication).Container;
            IContainerProvider container = Container;
            IRegionManager regionManager = container.Resolve<IRegionManager>();
            //regionManager.RegisterViewWithRegion("ContentRegion", typeof(MyView));

            //var view = container.Resolve<MyView>();
            regionManager.RequestNavigate("ContentRegion", nameof(View1));


            //IRegion region = regionManager.Regions["ContentRegion"];
            //var view = container.Resolve<MyView>();
            //region.Add(view);
        }
    }
}
