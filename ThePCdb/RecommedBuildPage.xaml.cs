using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ThePCdb
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RecommedBuildPage : Page
    {
        public RecommedBuildPage()
        {
            this.InitializeComponent();
            ReccomendedBox.Items.Add("$650.00");
            ReccomendedBox.Items.Add("$950.00");
            ReccomendedBox.Items.Add("$1,000.00");
            ReccomendedBox.Items.Add("$1,250.00");
            ReccomendedBox.Items.Add("$1,500.00");
            ReccomendedBox.Items.Add("$1,750.00");
            ReccomendedBox.Items.Add("$2,000.00");
            ReccomendedBox.Items.Add("$2,250.00");
            ReccomendedBox.Items.Add("$2,500.00");
            ReccomendedBox.Items.Add("$2,750.00");
            ReccomendedBox.Items.Add("$3,000.00");
            ReccomendedBox.Items.Add("$3,250.00");
            ReccomendedBox.Items.Add("$3,500.00");
            ReccomendedBox.Items.Add("$3,750.00");
            ReccomendedBox.Items.Add("$4,000.00");
            ReccomendedBox.Items.Add("$11,000.00");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomeScreen));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BuildInfo));
        }
    }
}
