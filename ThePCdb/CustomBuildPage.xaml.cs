using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ThePCdb.AppCore;
using ThePCdb.Components;
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
    public sealed partial class CustomBuildPage : Page
    {
        public CustomBuildPage()
        {
            this.InitializeComponent();
            foreach (CPUPart CPU in Warehouse.CPUList)
            {
                CPUBox.Items.Add(CPU.Name);
            }
            foreach (MotherboardPart MotherBoard in Warehouse.MotherboardList)
            {
                MotherBoardBox.Items.Add(MotherBoard.Name);
            }
            foreach (RAMPart RAM in Warehouse.RAMLIST)
            {
                RAMBox.Items.Add(RAM.Name);
            }
            foreach (CoolingPart Cooling in Warehouse.CoolingList)
            {
                CoolingBox.Items.Add(Cooling.Name);
            }
            foreach (CasePart Case in Warehouse.CaseList)
            {
                CaseBox.Items.Add(Case.Name);
            }
            foreach (StoragePart Storage in Warehouse.StorageList)
            {
                StorageBox.Items.Add(Storage.Name);
            }
            foreach (PSUPart PSU in Warehouse.PSUList)
            {
                PSUBox.Items.Add(PSU.Name);
            }
            foreach (GPUPart GPU in Warehouse.GPUList)
            {
                GPUBox.Items.Add(GPU.Name);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomeScreen));
        }
    }
}
