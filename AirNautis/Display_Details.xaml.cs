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
    public partial class Display_Details : Window
    {

        private ServiceAirNautis.AirNautisServiceClient airNautisService;

        public Display_Details()
        {
            InitializeComponent();
            airNautisService = new ServiceAirNautis.AirNautisServiceClient();
            fill_ComboBox();
        }

        private void fill_ComboBox()
        {
            comboAirplane.DataContext = airNautisService.GetAllAirplanes();

        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {

            if (!String.IsNullOrEmpty(comboAirplane.Text))
            {

                int airplane_id = int.Parse(comboAirplane.SelectedValue.ToString());

                Full_Details fullDetails_window = new Full_Details(airplane_id);
                fullDetails_window.ShowDialog();

            }

        }
    }
}
