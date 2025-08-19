using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_Tracker
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial int Count { get; set; }
        [ObservableProperty]
        public partial string CountDescription { get; set; }

        [RelayCommand]
        public void IncrementCount()
        {
            Count++;
        }  
        [RelayCommand]
        public void CountDescriptionChanged()
        {
            CountDescription = $"Count is {Count}";
            Count++;
        }
        public string CountDescriptionDisplay => string.IsNullOrEmpty(CountDescription) ? "No value available" : CountDescription;

    }
}
