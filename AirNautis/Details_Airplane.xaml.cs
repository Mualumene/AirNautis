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
    
    public partial class Details_Airplane : Window
    {

        private ServiceAirNautis.AirNautisServiceClient airNautisService = new ServiceAirNautis.AirNautisServiceClient();
        private ServiceAirNautis.Airplane airplane;

        public Details_Airplane(ServiceAirNautis.Airplane new_airplane)
        {
            airplane = new_airplane;
            InitializeComponent();
            Fill_Information(new_airplane);
        }

        public void Fill_Information(ServiceAirNautis.Airplane airplane_received)
        {
            txtBoxModelData.Text = airplane_received.Model;
            txtBoxCapacityData.Text = airplane_received.Capacity.ToString();
            txtBoxYearData.Text = airplane_received.Year.ToString();
            txtBoxHangarData.Text = airplane_received.Hangar.ToString();

            // Non editable TextBox
            txtBoxModelData.IsReadOnly = true;
            txtBoxCapacityData.IsReadOnly = true;
            txtBoxYearData.IsReadOnly = true;
            txtBoxHangarData.IsReadOnly = true;
        }

        private void EditAirplane_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Edit_Airplane editableAirplane = new Edit_Airplane(this.airplane);
            editableAirplane.ShowDialog();
            

        }
    }
}
