using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AirNautis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private ServiceAirNautis.AirNautisServiceClient airNautisService = null;

        private void NewHangar_Click(object sender, RoutedEventArgs e)
        {
            New_Hangar newHangar_window = new New_Hangar();
            newHangar_window.ShowDialog();

        }

        private void NewAirplane_Click(object sender, RoutedEventArgs e)
        {
            New_Airplane newAirplane_window = new New_Airplane();
            newAirplane_window.ShowDialog();

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            airNautisService = new ServiceAirNautis.AirNautisServiceClient();

            this.Populate_DataGrid();
            
        }

        private void Outgoing_Click(object sender, RoutedEventArgs e)
        {
            New_OutTravel newOutTravel_window = new New_OutTravel();
            newOutTravel_window.ShowDialog();

        }

        private void Incoming_Click(object sender, RoutedEventArgs e)
        {
            New_InTravel newInTravel_window = new New_InTravel();
            newInTravel_window.ShowDialog();

        }

        private void Historic_Click(object sender, RoutedEventArgs e)
        {
            Historic_Travel historicTravel_window = new Historic_Travel();
            historicTravel_window.ShowDialog();

        }

        private void Activate_Click(object sender, RoutedEventArgs e)
        {
            Activate_Airplane activate_window = new Activate_Airplane();
            activate_window.ShowDialog();

        }

        private void Deactivate_Click(object sender, RoutedEventArgs e)
        {
            Deactivate_Airplane deactivate_window = new Deactivate_Airplane();
            deactivate_window.ShowDialog();

        }

        private void Details_Click(object sender, RoutedEventArgs e)
        {

            Display_Details displayDetails_window = new Display_Details();
            displayDetails_window.ShowDialog();

        }

        private void DetailsHangar_Click(object sender, RoutedEventArgs e)
        {
            Details_Hangar detailsHangar_window = new Details_Hangar();
            detailsHangar_window.ShowDialog();

        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            Populate_DataGrid();           
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Populate_DataGrid()
        {

            dgMain.ItemsSource = airNautisService.GetHangarAirplanes();
            
        }


        private void dgMain_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            ServiceAirNautis.Airplane selected = dgMain.SelectedItem as ServiceAirNautis.Airplane;
            Details_Airplane detailedAirplane = new Details_Airplane(selected);
            detailedAirplane.ShowDialog();

        }

        


       


    }
}
