using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WPF_stock_client.Models;
using WPF_stock_client.Views;

namespace WPF_stock_client.ViewModels
{
    public class View1ViewModel : BindableBase, INavigationAware
    {
        private string message;
        private readonly IRegionManager regionManager;
        private string connectText="開始連線";
        MySocket client;
        private StockModel stock { get; set; }
        private ObservableCollection<StockModel> stocks = new ObservableCollection<StockModel>();

        public string ConnectText
        {
            get { return connectText; }
            set { SetProperty(ref connectText, value); }
        }
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }
        public DelegateCommand GoNextCommand { get; set; }
        public DelegateCommand ConnectCommand { get; set; }
        public int Counter { get; set; }

        public View1ViewModel(IRegionManager regionManager)
        {
            bool isconnect = false;
            this.regionManager = regionManager;
            GoNextCommand = new DelegateCommand(() =>
            {
                regionManager.RequestNavigate("ContentRegion", nameof(View2));
            });
            ConnectCommand = new DelegateCommand(() =>
            {
                if (isconnect)
                {
                    if (client != null)
                    {
                        client.disconnect();
                    }
                }
                else
                {
                    client = MySocket.connect();
                    if (client != null)
                    {
                        client.listener();
                    }
                }

                isconnect = !isconnect;
                ConnectText = isconnect ? "停止連線" : "開始連線";

                stocks.Add(new StockModel() { StockId = 1, StockName = "測試1", CurrentPrice = "50", ChangeRate = "1.5" });
                stocks.Add(new StockModel() { StockId = 1, StockName = "測試2", CurrentPrice = "70", ChangeRate = "20.5" });
                stocks.Add(new StockModel() { StockId = 1, StockName = "測試3", CurrentPrice = "100", ChangeRate = "12.3" });
            });
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public async void OnNavigatedTo(NavigationContext navigationContext)
        {
            await Task.Yield();
            Message = navigationContext.NavigationService.Journal.CanGoBack == false ? "尚未開始導航 " + Counter++ : "可以回上一頁";
        }

    }
}
