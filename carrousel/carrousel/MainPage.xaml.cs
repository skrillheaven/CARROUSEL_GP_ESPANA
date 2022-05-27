using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace carrousel
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<FileImageSource> imageSources = new ObservableCollection<FileImageSource>();
        ObservableCollection<FileImageSource> checop = new ObservableCollection<FileImageSource>();
        public MainPage()
        {
            InitializeComponent();
            imageSources.Add("gp1.jpg");
            imageSources.Add("gp2.jpg");
            imageSources.Add("gp3.jpg");
            imageSources.Add("gp4.jpg");

            imgSlider.Images = imageSources;

            checop.Add("CP1.jpg");
            checop.Add("cp2.jpg");
            checop.Add("cp3.jpg");

            imgcheco.Images = checop;

        }
    }
}
