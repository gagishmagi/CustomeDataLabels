﻿using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomeDataLabels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //lets configure SVG point
            var mapper = Mappers.Xy<SvgPoint>()
                .X((value, index) => index)
                .Y(value => value.Value);

            Charting.For<SvgPoint>(mapper);

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Explorer",
                    Values = new ChartValues<SvgPoint>
                    {
                        new SvgPoint
                        {
                            Value = 10,
                            //<div>Icons made by <a href="http://www.flaticon.com/authors/madebyoliver" title="Madebyoliver">Madebyoliver</a> from <a href="http://www.flaticon.com" title="Flaticon">www.flaticon.com</a> is licensed by <a href="http://creativecommons.org/licenses/by/3.0/" title="Creative Commons BY 3.0" target="_blank">CC 3.0 BY</a></div>
                            //Svg = "M179.649,292.487c0,17.067,7.186,31.439,15.27,46.709c8.982,16.168,21.558,28.744,37.726,38.625  s33.235,14.372,52.996,14.372c18.863,0,36.828-4.491,52.996-14.372c16.168-9.881,27.846-24.253,37.726-40.421h125.754  c-16.168,45.811-44.014,85.333-84.435,114.077s-85.333,44.014-134.737,44.014c-36.828,0-72.758-8.084-105.095-24.253  c-73.656,35.93-126.653,37.726-158.989,5.389C5.389,465.848,0,447.883,0,423.631s4.491-52.098,14.372-81.74  c9.881-30.54,25.151-62.877,47.607-99.705c17.067-28.744,29.642-51.2,78.147-97.909c17.965-17.965,26.049-26.947,30.54-31.439  c-43.116,20.66-98.807,59.284-143.719,98.807c26.947-66.47,64.674-100.604,110.484-129.347  c49.404-29.642,89.825-49.404,143.719-49.404c5.389,0,10.779,0,17.067,0.898C337.74,15.827,373.67,6.845,406.007,4.15  c32.337-1.796,54.793,3.593,68.267,16.168c26.947,26.947,28.744,70.063,7.186,128.449c20.66,35.93,21.558,76.351,21.558,117.67  c0,9.881,0.898,18.863,0,26.947H386.246H179.649V292.487z"
                            Image = "https://upload.wikimedia.org/wikipedia/he/thumb/b/b7/%D7%9C%D7%95%D7%92%D7%95_%D7%9E%D7%99%D7%A7%D7%A8%D7%95%D7%A1%D7%95%D7%A4%D7%98_%D7%90%D7%93%D7%92%27.svg/1200px-%D7%9C%D7%95%D7%92%D7%95_%D7%9E%D7%99%D7%A7%D7%A8%D7%95%D7%A1%D7%95%D7%A4%D7%98_%D7%90%D7%93%D7%92%27.svg.png"
                        }
                    }
                },
                new ColumnSeries
                {
                    Title = "Chrome",
                    Values = new ChartValues<SvgPoint>
                    {
                        new SvgPoint
                        {
                            Value = 15,
                            //<div>Icons made by <a href="http://www.flaticon.com/authors/google" title="Google">Google</a> from <a href="http://www.flaticon.com" title="Flaticon">www.flaticon.com</a> is licensed by <a href="http://creativecommons.org/licenses/by/3.0/" title="Creative Commons BY 3.0" target="_blank">CC 3.0 BY</a></div>
                            //Svg = "M255,0C114.75,0,0,114.75,0,255s114.75,255,255,255s255-114.75,255-255S395.25,0,255,0z M255,51    c76.5,0,140.25,40.8,175.95,102H255c-48.45,0-91.8,35.7-99.45,81.6l-61.2-104.55C132.6,81.6,188.7,51,255,51z M331.5,255    c0,43.35-33.15,76.5-76.5,76.5c-43.35,0-76.5-33.15-76.5-76.5c0-43.35,33.15-76.5,76.5-76.5C298.35,178.5,331.5,211.65,331.5,255z     M51,255c0-38.25,10.2-71.4,28.05-102l89.25,153l0,0c17.85,30.6,51,51,86.7,51c12.75,0,22.95-2.55,33.15-5.1l-61.2,104.55    C127.5,443.7,51,357,51,255z M255,459l89.25-153l0,0c7.65-15.3,15.3-33.15,15.3-51c0-30.6-12.75-58.65-35.7-76.5h122.4    c10.2,22.95,15.3,48.45,15.3,76.5C459,367.2,367.2,459,255,459z"
                            Image = "https://www.y4pc.co.il/images/Guides/11-15/google-chrome-extensions/google-chrome-extensions9.jpg"

                        }
                    }
                },
                new ColumnSeries
                {
                    Title = "Mozilla",
                    Values = new ChartValues<SvgPoint>
                    {
                        new SvgPoint
                        {
                            Value = 8,
                            //<div>Icons made by <a href="http://www.freepik.com" title="Freepik">Freepik</a> from <a href="http://www.flaticon.com" title="Flaticon">www.flaticon.com</a> is licensed by <a href="http://creativecommons.org/licenses/by/3.0/" title="Creative Commons BY 3.0" target="_blank">CC 3.0 BY</a></div>
                            //Svg = "M301.98,103.88c-1.108-0.17-2.194,0.421-2.656,1.442l-3.413,7.555c-1.296-9.931-3.7-25.915-6.875-36.396   c-4.839-16.138-15.087-26.571-15.521-27.008c-0.785-0.789-1.995-0.964-2.973-0.43c-0.976,0.534-1.482,1.649-1.24,2.735   l2.652,11.949c-6.381-6.666-16.632-16.234-26.776-20.898c-2.439-1.189-4.918-2.279-7.089-3.219   c-22.038-19.576-50.3-30.352-79.627-30.352c-41.3,0-78.94,20.689-101.226,55.487c-2.097-1.694-5.037-4.657-6.722-8.928   c-3.064-7.512-4.616-15.951-4.632-16.035c-0.165-0.906-0.813-1.648-1.689-1.932c-0.874-0.284-1.836-0.064-2.501,0.573   C23.326,56.034,25.149,83.49,25.834,89.713c-2.276,2.431-8.709,9.639-15.208,20.038c-8.07,12.921-10.513,35.509-10.612,36.464   c-0.111,1.066,0.468,2.084,1.441,2.532c0.977,0.448,2.126,0.225,2.86-0.553l5.375-5.678c-0.586,2.173-1.176,4.65-1.721,7.424   c-2.421,11.975-1.713,30.55-1.682,31.335c0.046,1.15,0.871,2.121,2,2.35c1.128,0.232,2.267-0.341,2.759-1.382l3.163-6.697   c2.332,16.302,11.285,50.988,45.614,82.941c25.426,23.684,60.79,37.269,97.025,37.271c0.004,0,0.005,0,0.009,0   c35.168,0,68.374-12.578,96.022-36.372c32.692-28.164,44.871-68.384,49.33-97.166c4.814-31.073,1.996-55.158,1.873-56.168   C303.949,104.938,303.09,104.05,301.98,103.88z M246.16,104.785c0.034,0.044,3.426,4.486,4.166,15.868   c0.51,8.518-1.238,22.14-2.341,29.593l-6.661-7.729c-0.719-0.834-1.896-1.102-2.904-0.655c-1.007,0.445-1.604,1.496-1.471,2.588   c0.023,0.192,2.293,19.437-1.526,36.165c-1.808,7.861-4.637,13.512-7.064,17.241l0.931-12.6c0.089-1.209-0.701-2.307-1.876-2.606   c-1.176-0.301-2.396,0.286-2.895,1.391c-0.112,0.249-11.658,25.037-43.279,34.852c-4.416,1.36-9.067,2.05-13.825,2.05   c-16.854,0.001-32.168-8.598-40.849-14.64c0.747,0.038,1.49,0.057,2.229,0.057c12.435,0,21.998-5.357,29.684-9.662   c2.019-1.131,3.926-2.199,5.761-3.106c11.045-5.554,16.18-6.02,20.125-6.02c2.084,0,3.691-1.217,4.195-3.175   c1.235-4.806-4.543-13.372-11.678-17.3c-3.539-1.924-7.323-2.82-11.906-2.82c-7.292,0-16.333,2.3-29.284,5.806   c-2.377,0.634-4.724,0.956-6.976,0.956c-7.936,0.001-13.184-3.838-16.189-7.059c-4.044-4.334-6.347-10.061-6.008-14.945   c0.154-2.227,1.026-4.504,6.325-4.504c4.701,0,9.926,1.938,9.977,1.956c0.285,0.108,0.584,0.161,0.881,0.161   c0.005,0,0.012,0,0.019,0c1.381,0,2.5-1.119,2.5-2.5c0-0.135-0.011-0.268-0.031-0.397l-0.699-21.899   c2.525-1.61,8.567-5.527,14.375-9.749c14.051-10.214,15.933-14.12,14.429-17.087c-1.992-4.04-7.235-4.696-13.306-5.456   c-3.474-0.435-7.411-0.928-10.967-2.105c-7.408-2.462-12.289-8.858-13.4-10.43c-0.23-1.316-0.78-5.75,1.395-9.535   c2.354-4.137,10.495-10.542,13.434-12.662c0.84-0.605,1.22-1.666,0.955-2.667c-0.265-1-1.119-1.735-2.148-1.846   c-0.252-0.028-7.721-0.774-19.922,3.266c-9.934,3.328-17.639,8.722-20.294,10.723c-1.142-0.224-3.097-0.533-6.336-0.867   c19.025-21.484,46.01-33.714,74.76-33.714c21.101,0,41.038,6.417,58.012,18.618l-16.808,2.811   c-1.142,0.191-2.003,1.141-2.082,2.295c-0.079,1.155,0.646,2.213,1.75,2.558c0.224,0.07,22.608,7.146,39.31,20.021   c3.717,2.909,7.115,6.676,10.104,11.199c2.787,5.974,4.968,12.134,6.513,18.387l-5.62-4.367c-0.998-0.775-2.406-0.672-3.296,0.223   C245.454,102.361,245.38,103.792,246.16,104.785z"
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Mozilla_Firefox_logo_2013.svg/1935px-Mozilla_Firefox_logo_2013.svg.png"
                        }
                    }
                }
            };

            DataContext = SeriesCollection;
        }

        public SeriesCollection SeriesCollection { get; set; }
    }

    public class SvgPoint
    {
        public string Image { get; set; }
        public double Value { get; set; }
    }
}
