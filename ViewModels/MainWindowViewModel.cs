using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Threading.Tasks;
using WPF_stock_client.Views;

namespace WPF_stock_client.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
        
    }
}
