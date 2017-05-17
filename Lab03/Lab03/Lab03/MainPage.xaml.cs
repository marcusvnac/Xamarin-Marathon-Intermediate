using Lab03.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnCarregar.Clicked += async (sender, e) =>
            {
                var tags = await Api.GetTagsAsync();
                lvwTags.ItemsSource = tags;
            };
        }
    }
}
