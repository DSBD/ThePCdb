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
    public sealed partial class PartInfo : Page
    {
        Components.Part selectedPart;

        public PartInfo()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BrowsePage));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            selectedPart = (Components.Part)e.Parameter;
            PartName.Text = $"Name: {selectedPart.Name}";
            PartPrice.Text = $"Price: ${selectedPart.Price.ToString()}";
            PartRating.Text = $"Rating: {selectedPart.Rating.ToString()}/10";
            PartType.Text = $"Part Type: {selectedPart.Type}";

            switch (selectedPart.Type)
            {
                case "CPU":
                    Components.CPUPart displayCPU = new Components.CPUPart("ERROR", 000, 0, "CPU", 0, 0, Components.CPUPart.Socket.Other, Components.CPUPart.Chipset.Other, 0, "NULL");
                    foreach (Components.CPUPart part in AppCore.Warehouse.CPUList)
                    {
                        if(part.InternalPartID == selectedPart.InternalPartID)
                        {
                            displayCPU = part;
                            break;
                        }
                    }
                    PartDetails1.Text = $"Cores: {displayCPU.CoreCount}";
                    PartDetails2.Text = $"Frequency: {displayCPU.Frequency} GHz";
                    PartDetails3.Text = $"Cinebench Score: {displayCPU.CineBenchScore}";
                    break;
                case "Motherboard":
                    Components.MotherboardPart displayMotherboard = new Components.MotherboardPart("ERROR", 0, 0, "Motherboard", "NULL", "Other", 0, 0, false, Components.CPUPart.Socket.Other, Components.CPUPart.Chipset.Other);
                    foreach (Components.MotherboardPart part in AppCore.Warehouse.MotherboardList)
                    {
                        if (part.InternalPartID == selectedPart.InternalPartID)
                        {
                            displayMotherboard = part;
                            break;
                        }
                    }
                    PartDetails1.Text = $"Socket: {displayMotherboard.Socket}";
                    PartDetails2.Text = $"Chipset: {displayMotherboard.chipSetCompatibility}";
                    PartDetails3.Text = $"Form Factor: {displayMotherboard.FormFactor}";
                    break;
                case "RAM":
                    Components.RAMPart displayRAM = new Components.RAMPart("ERROR", 0, 0, "RAM", "NULL", "NULL", 0, 0);
                    foreach (Components.RAMPart part in AppCore.Warehouse.RAMLIST)
                    {
                        if (part.InternalPartID == selectedPart.InternalPartID)
                        {
                            displayRAM = part;
                            break;
                        }
                    }
                    PartDetails1.Text = $"Capacity: {displayRAM.Capacity} GB";
                    PartDetails2.Text = $"Frequency: {displayRAM.Frequency} MHz";
                    PartDetails3.Text = $"Type: {displayRAM.RAMType}";
                    break;
                case "Cooling":
                    Components.CoolingPart displayCooling = new Components.CoolingPart("ERROR", 0, 0, "Cooling", "NULL", "NULL", new List<Components.CPUPart.Socket> {Components.CPUPart.Socket.Other});
                    string compList = "";
                    foreach (Components.CoolingPart part in AppCore.Warehouse.CoolingList)
                    {
                        if (part.InternalPartID == selectedPart.InternalPartID)
                        {
                            displayCooling = part;
                            break;
                        }
                    }
                    foreach (Components.CPUPart.Socket socket in displayCooling.Compatability)
                    {
                        compList += $"{socket} ";
                    }
                    PartDetails1.Text = $"Type: {displayCooling.CoolerType}";
                    PartDetails2.Text = $"Compatability: {compList}";
                    break;
                case "Case":
                    Components.CasePart displayCase = new Components.CasePart("ERROR", 0, 0, "Case", "NULL", "NULL", 0, 0, false, false, false);
                    foreach (Components.CasePart part in AppCore.Warehouse.CaseList)
                    {
                        if (part.InternalPartID == selectedPart.InternalPartID)
                        {
                            displayCase = part;
                            break;
                        }
                    }
                    PartDetails1.Text = $"Form Factor: {displayCase.FormFactor}";
                    PartDetails2.Text = $"Drive Bays: {displayCase.DriveBays}";
                    PartDetails3.Text = $"PCI Slots: {displayCase.PCISlots}";
                    break;
                case "Storage":
                    Components.StoragePart displayStorage = new Components.StoragePart("ERROR", 0, 0, "Storage", "NULL", "NULL", 0, "NULL", "NULL");
                    foreach (Components.StoragePart part in AppCore.Warehouse.StorageList)
                    {
                        if (part.InternalPartID == selectedPart.InternalPartID)
                        {
                            displayStorage = part;
                            break;
                        }
                    }
                    PartDetails1.Text = $"Capacity: {displayStorage.Capacity} GB";
                    PartDetails2.Text = $"Type: {displayStorage.DriveType}";
                    PartDetails3.Text = $"Interface: {displayStorage.InterfaceType}";
                    break;
                case "PSU":
                    Components.PSUPart displayPSU = new Components.PSUPart("ERROR", 0, 0, "PSU", "NULL", "NULL", 0, Components.PSUPart.EightyPlus.Other);
                    foreach (Components.PSUPart part in AppCore.Warehouse.PSUList)
                    {
                        if (part.InternalPartID == selectedPart.InternalPartID)
                        {
                            displayPSU = part;
                            break;
                        }
                    }
                    PartDetails1.Text = $"Wattage: {displayPSU.Wattage} W";
                    PartDetails2.Text = $"80Plus Rating: {displayPSU.EPRating}";
                    PartDetails3.Text = $"Form Factor: {displayPSU.FormFactor}";
                    break;
                case "GPU":
                    Components.GPUPart displayGPU = new Components.GPUPart("ERROR", 0, 0, "GPU", "NULL", 0, 0, 0, 0);
                    foreach (Components.GPUPart part in AppCore.Warehouse.GPUList)
                    {
                        if (part.InternalPartID == selectedPart.InternalPartID)
                        {
                            displayGPU = part;
                            break;
                        }
                    }
                    PartDetails1.Text = $"Base Frequency: {displayGPU.CoreFrequency} MHz";
                    PartDetails2.Text = $"Boost Frequency: {displayGPU.BoostFrequency} MHz";
                    PartDetails3.Text = $"3DMark Score: {displayGPU.ThreeDMarkScore}";
                    break;
                default:
                    break;
            }

        }
    }
}