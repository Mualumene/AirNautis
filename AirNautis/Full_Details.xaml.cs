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
    /// Interaction logic for Full_Details.xaml
    /// </summary>
    public partial class Full_Details : Window
    {

        private ServiceAirNautis.AirNautisServiceClient airNautisService;
        private ServiceAirNautis.Airplane selected_airplane;
        

        public Full_Details(int airplane_id)
        {
            airNautisService = new ServiceAirNautis.AirNautisServiceClient();
            InitializeComponent(); 
            Fill_Information(airplane_id);
        }

        public void Fill_Information(int airplane_id)
        {

            selected_airplane = airNautisService.GetAirplaneById(airplane_id);
            txtBoxModelData.Text = selected_airplane.Model;
            txtBoxCapacityData.Text = selected_airplane.Capacity.ToString();
            txtBoxYearData.Text = selected_airplane.Year.ToString();
            txtBoxActiveData.Text = selected_airplane.Active.ToString();

            // Non editable TextBox
            txtBoxModelData.IsReadOnly = true;
            txtBoxCapacityData.IsReadOnly = true;
            txtBoxYearData.IsReadOnly = true;
            txtBoxActiveData.IsReadOnly = true;

            dgTravels.ItemsSource = airNautisService.GetAirplaneTravels(airplane_id);
        }
    }
}
