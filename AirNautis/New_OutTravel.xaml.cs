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
    /// Interaction logic for New_OutTravel.xaml
    /// </summary>
    public partial class New_OutTravel : Window
    {

        private ServiceAirNautis.AirNautisServiceClient airNautisService;

        public New_OutTravel()
        {
            airNautisService = new ServiceAirNautis.AirNautisServiceClient();
            InitializeComponent();
            fill_ComboBox();
        }

        private void btnFlight_Click(object sender, RoutedEventArgs e)
        {
            

            if (!String.IsNullOrEmpty(txtBoxDestination.Text) && !String.IsNullOrEmpty(comboAirplane.Text)){

                int airplane_id = int.Parse(comboAirplane.SelectedValue.ToString());

                ServiceAirNautis.Travel new_travel = new ServiceAirNautis.Travel();
                new_travel.Airplane = airplane_id;
                new_travel.Destination = txtBoxDestination.Text;

                if(airNautisService.NewOutgoingTravel(new_travel)){

                    MessageBox.Show(string.Format("Airplane on his way to {0} !", txtBoxDestination.Text), "Success", MessageBoxButton.OK);
                    DialogResult = true;

                }else{
                }
                

                
            }

        }

        private void fill_ComboBox()
        {
            comboAirplane.DataContext = airNautisService.GetHangarAirplanes();

        }
    }
}
