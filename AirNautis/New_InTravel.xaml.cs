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

    public partial class New_InTravel : Window
    {
        private ServiceAirNautis.AirNautisServiceClient airNautisService;

        public New_InTravel()
        {
            airNautisService = new ServiceAirNautis.AirNautisServiceClient();
            InitializeComponent();
            fill_ComboBox();

        }

        private void btnFlight_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxOrigin.Text) && !String.IsNullOrEmpty(comboHangar.Text) && !String.IsNullOrEmpty(comboAirplane.Text))
            {

                int airplane_id = int.Parse(comboAirplane.SelectedValue.ToString());
                int hangar_number = int.Parse(comboHangar.SelectedValue.ToString());


                ServiceAirNautis.Travel new_travel = new ServiceAirNautis.Travel();
                new_travel.Airplane = airplane_id;
                new_travel.Origin = txtBoxOrigin.Text;
                new_travel.Destination = hangar_number.ToString();
                
                if(airNautisService.NewIncomingTravel(new_travel)){

                    MessageBox.Show(string.Format("Airplane comming from {0} its on his way to hangar {1} !", txtBoxOrigin.Text, hangar_number), "Success", MessageBoxButton.OK);
                    DialogResult = true;
                }
                else
                {
                    MessageBox.Show(string.Format("Hangar {0} is currently full !", hangar_number), "Alert", MessageBoxButton.OK);
                    
                }
                

                
            }

        }

        private void fill_ComboBox()
        {
            comboAirplane.DataContext = airNautisService.GetOutAirplanes();
            comboHangar.DataContext = airNautisService.GetAvaiableHangars();

        }
    }
}
