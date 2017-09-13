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
    /// Interaction logic for Activate_Airplane.xaml
    /// </summary>
    public partial class Activate_Airplane : Window
    {
        private ServiceAirNautis.AirNautisServiceClient airNautisService;

        public Activate_Airplane()
        {
            InitializeComponent();
            airNautisService = new ServiceAirNautis.AirNautisServiceClient();
            fill_ComboBox();

        }

        private void fill_ComboBox()
        {
            comboAirplane.DataContext = airNautisService.GetInactiveAirplanes();

        }

        private void btnActivate_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(comboAirplane.Text))
            {

                int airplane_id = int.Parse(comboAirplane.SelectedValue.ToString());

                if (airNautisService.ActivateAirplane(airplane_id))
                {

                    MessageBox.Show(string.Format("Airplane reactivated !"), "Success", MessageBoxButton.OK);
                    DialogResult = true;
                }
                else
                {
                    MessageBox.Show(string.Format("Not possible to reactivate airplane !"), "Alert", MessageBoxButton.OK);

                }



            }
        }
    }
}
