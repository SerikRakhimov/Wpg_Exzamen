using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace EarthquakeAPI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }


        private void InfoLoad(string cnt)
        {
            string date;
            string place;
            string magnituda;
            string glubina;

            //          PrBar.Visibility = Visibility.Visible;
            WebRequest req = WebRequest.Create(@"https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&orderby=time-asc&limit=" + cnt);

            string jsonText = "";

            WebResponse response = req.GetResponse();
            using (Stream s = response.GetResponseStream()) //Пишем в поток.
            {
                using (StreamReader r = new StreamReader(s)) //Читаем из потока.
                {
                    jsonText = r.ReadToEnd();
                }
            }
            response.Close(); //Закрываем поток

            //            List<Feature> = JsonConvert.DeserializeObject<List<Feature>>(jsonText);



            //        eathAll = Feature.FromJson(jsonText).ToList();

            RootObject newpeople = JsonConvert.DeserializeObject<RootObject>(jsonText);

           List<Feature> featureAll = newpeople.Features.ToList();




            //ListData.Items.Clear();

            List<Info> InfoAll = new List<Info>();

            foreach (var t in featureAll)
            {
                //var u = DateTimeOffset.FromUnixTimeSeconds(t.Properties.Time);
                
                date = t.Properties.Time.ToString();
               // date = u.ToString();
               place = t.Properties.Place;
                magnituda = t.Properties.Mag.ToString();
                glubina = t.Properties.Sig.ToString();

                InfoAll.Add(new Info
                {
                    Date = date,
                    Place = place,
                    Magnituda = magnituda,
                    Glubina = glubina
                });

            }
            infoDataGrid.ItemsSource = InfoAll;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int cnt = int.Parse(textCount.Text);
            }
            catch 
            {
                MessageBox.Show("Введите число");
                return;
            }
            InfoLoad(textCount.Text);

        }
    }
}
