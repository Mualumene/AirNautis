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
using System.Windows.Shapes;

namespace AirNautis
{
    /// <summary>
    /// Interaction logic for Hangar_airplanes.xaml
    /// </summary>
    public partial class Hangar_airplanes : Window
    {
        private ServiceAirNautis.AirNautisServiceClient airNautisService;
        private ServiceAirNautis.Hangar selected_hangar;

        public Hangar_airplanes(int hangar_number)
        {
            airNautisService = new ServiceAirNautis.AirNautisServiceClient();
            InitializeComponent();
            Fill_Information(hangar_number);
        }

        public void Fill_Information(int hangar_number)
        {

            selected_hangar = airNautisService.GetHangar(hangar_number);
            

            txtBoxCapacity.Text = selected_hangar.Capacity.ToString();
            txtBoxCurrent.Text = airNautisService.GetAirplanesByHangar(hangar_number).Count().ToString();

            // Non editable TextBox
            txtBoxCapacity.IsReadOnly = true;
            txtBoxCurrent.IsReadOnly = true;

            dgHangarAirplane.ItemsSource = airNautisService.GetAirplanesByHangar(hangar_number);
        }

        private void dgHangarAirplane_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ServiceAirNautis.Airplane selected = dgHangarAirplane.SelectedItem as ServiceAirNautis.Airplane;
            Details_Airplane detailedAirplane = new Details_Airplane(selected);
            detailedAirplane.ShowDialog();
        }
    }
}
