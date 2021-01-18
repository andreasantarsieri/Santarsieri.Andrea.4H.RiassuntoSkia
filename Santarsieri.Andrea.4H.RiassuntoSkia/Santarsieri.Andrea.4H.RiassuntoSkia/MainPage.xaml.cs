using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Essentials;
using System.IO;

using Xamarin.Forms;


namespace Santarsieri.Andrea._4H.RiassuntoSkia
{
    public partial class MainPage : ContentPage
    {
        public int margineSinistra { get; set; } = 100;
        public int margineSopra { get; set; } = 100;

        public int larghezzaRettangolo { get; set; } = 200;

        public int altezzaRettangolo { get; set; } = 300;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnDisegno_Clicked(object sender, EventArgs e)
        {

        }

        private void SKCanvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            var info = e.Info;
            //var surface = e.Surface;
            var canvas = e.Surface.Canvas;
            canvas.Clear();

            int larghezza = info.Rect.Width; //1200
            int altezza = info.Rect.Height; //794
            
            

        }
        //SKPath AreaDelDisegno()
        //{
        //    SKPath rettangolo = new SKPath();
        //    rettangolo.MoveTo();
        //    return;
        //}
    }
}
