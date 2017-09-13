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
    /// Interaction logic for Details_Hangar.xaml
    /// </summary>
    public partial class Details_Hangar : Window
    {

        private ServiceAirNautis.AirNautisServiceClient airNautisService;

        public Details_Hangar()
        {
            airNautisService = new ServiceAirNautis.AirNautisServiceClient();
            InitializeComponent();
            Populate_Hangar();
        }

        private void Populate_Hangar()
        {
            dgHangar.ItemsSource = airNautisService.GetAllHangars();
        }

        private void dgHangar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ServiceAirNautis.Hangar selected = dgHangar.SelectedItem as ServiceAirNautis.Hangar;
            Hangar_airplanes hangar_airplane = new Hangar_airplanes(selected.Number);
            hangar_airplane.ShowDialog();
        }

    }
}
