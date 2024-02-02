using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTabs
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty] private List<MenuItem>? _menuItems;
        [ObservableProperty] private string? _selected;

        public MainPageViewModel()
        {
            MenuItems = new List<MenuItem>
            {
                new MenuItem { Text = "Words", Value = "Words" },
                new MenuItem { Text = "Games", Value = "Games" },
                new MenuItem { Text = "Statistics", Value = "Statistics" }
            };

            Selected = MenuItems[0].Value;
        }
    }
}