using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace D3JavaScript
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
           

            
            
            //            [0,-0,0,0,0,3 ],
            //[1,-1,1,2,1,6 ],
            //[2,-2,4,4,0.5,2],
            //[3,-3,9,6,0.33,4],
            //[4, -4, 16, 8, 0.25, 9],
            //["hello", "a", "b", "c", "d", "e", "a"]
            //JavaScriptSerializer ser = new JavaScriptSerializer();

        WebView1.Navigate(new Uri("ms-appx-web:///Assets/ParallelCoordinates2.html"));
            WebView1.LoadCompleted += WebView1_LoadCompleted;

        }

        private async void WebView1_LoadCompleted(object sender, NavigationEventArgs e)
        {
            await WebView1.InvokeScriptAsync("updateData", new string[]{"2","2","2","2","2","2"});
        }

        //public string getData() {
        //    int[,] array2D = new int[,] { { 0, -0, 0, 0, 0, 3 }, { 1, -1, 1, 2, 1, 6 }, { 3, -3, 9, 6, 1, 4 } };
        //    var jsData = JsonConvert.SerializeObject(array2D);
        //    return jsData;
        //}
    }
}
