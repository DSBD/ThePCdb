using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public sealed partial class BrowsePage : Page
    {

        public BrowsePage()
        {
            this.InitializeComponent();

            CategoryBox.Items.Add("CPU");
            CategoryBox.Items.Add("MotherBoard");
            CategoryBox.Items.Add("RAM");
            CategoryBox.Items.Add("Cooling");
            CategoryBox.Items.Add("Case");
            CategoryBox.Items.Add("Storage");
            CategoryBox.Items.Add("GPU");
            CategoryBox.Items.Add("PSU");
            PartBox.Items.Add("No Category Selected");
            PartBox.DisplayMemberPath = "Name";
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomeScreen));
        }

        private void DetermineCategory(object category)
        {
            
            if ((string)category == "CPU")
            {
                foreach (CPUPart CPU in Warehouse.CPUList)
                {
                    PartBox.Items.Add(CPU);
                }
            }
            else if ((string)category == "MotherBoard")
            {
                foreach (MotherboardPart MotherBoard in Warehouse.MotherboardList)
                {
                    PartBox.Items.Add(MotherBoard);
                }
            }
            else if ((string)category == "RAM")
            {
                foreach (RAMPart RAM in Warehouse.RAMLIST)
                {
                    PartBox.Items.Add(RAM);
                }
            }
            else if ((string)category == "Cooling")
            {
                foreach (CoolingPart Cooling in Warehouse.CoolingList)
                {
                    PartBox.Items.Add(Cooling);
                }
            }
            else if ((string)category == "Case")
            {
                foreach (CasePart Case in Warehouse.CaseList)
                {
                    PartBox.Items.Add(Case);
                }
            }
            else if ((string)category == "Storage")
            {
                foreach (StoragePart Storage in Warehouse.StorageList)
                {
                    PartBox.Items.Add(Storage);
                }
            }
            else if ((string)category == "GPU")
            {
                foreach (GPUPart GPU in Warehouse.GPUList)
                {
                    PartBox.Items.Add(GPU);
                }
            }
            else if ((string)category == "PSU")
            {
                foreach (PSUPart PSU in Warehouse.PSUList)
                {
                    PartBox.Items.Add(PSU);
                }
            }
            else
            {
                PartBox.Items.Add("No Category Selected");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PartBox.Items.Clear();
            DetermineCategory(CategoryBox.SelectedItem);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

