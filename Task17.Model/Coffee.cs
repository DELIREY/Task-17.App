﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Model
{
    public class Coffee : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Private Fields
        private int _coffeeId;
        private string _coffeeName;
        private int _price;
        #endregion
        #region
        public  int CoffeeId
        {
            get => _coffeeId;
            set
            {
                _coffeeId = value;
                RaisePropertyChanged();
            }
        }
        public string CoffeeName
        {
            get => _coffeeName;
            set
            {
                _coffeeName = value;
                RaisePropertyChanged();
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                _price = value;
                RaisePropertyChanged();
            }
        }
        public string Description { get; set; }
        public Country OriginCountry {  get; set; }
        public bool InStock { get; set; }
        public int AmountInStock { get; set; }
        public DateTime FirstAddedToStockDate { get; set; }
        public int ImageId { get; set; }
        #endregion
    }

}
