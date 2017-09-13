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
    /// Interaction logic for Historic_Travel.xaml
    /// </summary>
    public partial class Historic_Travel : Window
    {

        private ServiceAirNautis.AirNautisServiceClient airNautisService;
       
        public Historic_Travel()
        {
            airNautisService = new ServiceAirNautis.AirNautisServiceClient();
            InitializeComponent();
            Populate_Historic();
        }

        private void Populate_Historic()
        {
            dgHistoric.ItemsSource = airNautisService.GetTravels();
        }
    }
}
