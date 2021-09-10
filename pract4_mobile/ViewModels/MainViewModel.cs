using pract4_mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace pract4_mobile.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MenuOptionsModel Bar { get; }
        public MenuOptionsModel FineDining { get; }
        public MenuOptionsModel Cafes { get; }
        public MenuOptionsModel Nearby { get; }
        public MenuOptionsModel FastFood { get; }
        public MenuOptionsModel FeaturedFoods{ get; }


        public MainViewModel()
        {
            Bar = new MenuOptionsModel("Bars", "beer.png", "10 Places");
            FineDining = new MenuOptionsModel("Fine Dining", "food.png", "15 Places");
            Cafes = new MenuOptionsModel("Cafes", "cafe.png", "23 Places");
            Nearby = new MenuOptionsModel("Nearby", "map.png", "50 Places");
            FastFood = new MenuOptionsModel("Fast Food", "burger.png", "30 Places");
            FeaturedFoods = new MenuOptionsModel("Featured Foods", "pie.png", "12 Places");
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
