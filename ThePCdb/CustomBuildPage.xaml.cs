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
                CPUBox.DisplayMemberPath = "Name";
                CPUBox.Items.Add(CPU);
            }
            foreach (MotherboardPart MotherBoard in Warehouse.MotherboardList)
            {
                MotherBoardBox.DisplayMemberPath = "Name";
                MotherBoardBox.Items.Add(MotherBoard);
            }
            foreach (RAMPart RAM in Warehouse.RAMLIST)
            {
                RAMBox.DisplayMemberPath = "Name";
                RAMBox.Items.Add(RAM);
            }
            foreach (CoolingPart Cooling in Warehouse.CoolingList)
            {
                CoolingBox.DisplayMemberPath = "Name";
                CoolingBox.Items.Add(Cooling);
            }
            foreach (CasePart Case in Warehouse.CaseList)
            {
                CaseBox.DisplayMemberPath = "Name";
                CaseBox.Items.Add(Case);
            }
            foreach (StoragePart Storage in Warehouse.StorageList)
            {
                StorageBox.DisplayMemberPath = "Name";
                StorageBox.Items.Add(Storage);
            }
            foreach (PSUPart PSU in Warehouse.PSUList)
            {
                PSUBox.DisplayMemberPath = "Name";
                PSUBox.Items.Add(PSU);
            }
            foreach (GPUPart GPU in Warehouse.GPUList)
            {
                GPUBox.DisplayMemberPath = "Name";
                GPUBox.Items.Add(GPU);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomeScreen));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppCore.Build custBuild = new Build((Components.CasePart)CaseBox.SelectedValue, (Components.CoolingPart)CoolingBox.SelectedValue, (Components.CPUPart)CPUBox.SelectedValue, (Components.GPUPart)GPUBox.SelectedValue, (Components.MotherboardPart)MotherBoardBox.SelectedValue, (Components.PSUPart)PSUBox.SelectedValue, (Components.RAMPart)RAMBox.SelectedValue, (Components.StoragePart)StorageBox.SelectedValue);

            this.Frame.Navigate(typeof(BuildInfo), (Build)custBuild);
        }
    }
}
