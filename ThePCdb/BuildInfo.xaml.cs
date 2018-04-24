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
    public sealed partial class BuildInfo : Page
    {
        AppCore.Build displayBuild;

        public BuildInfo()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomeScreen));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            displayBuild = (AppCore.Build)e.Parameter;

            CPUSlot.Text = $"CPU: {displayBuild.CPU.Name}";
            MotherboardSlot.Text = $"Motherboard: {displayBuild.Motherboard.Name}";
            GPUSlot.Text = $"GPU: {displayBuild.GPU.Name}";
            RAMSlot.Text = $"RAM: {displayBuild.RAMKit.Name}";
            PSUSlot.Text = $"PSU: {displayBuild.PSU.Name}";
            CaseSlot.Text = $"Case: {displayBuild.Case.Name}";
            StorageSlot.Text = $"Storage: {displayBuild.Storage.Name}";
            CoolingSlot.Text = $"Cooling: {displayBuild.Cooling.Name}";
            PriceSlot.Text = $"Total Cost: ${displayBuild.Price}";
        }
    }
}
