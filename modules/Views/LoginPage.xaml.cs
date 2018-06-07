using SkiaSharp.Views.Forms;
using SkiaSharp;
using Xamarin.Forms;

namespace modules.Views
{
    public partial class LoginPage : ContentPage
    {
        /// <summary>
        /// Ons the appearing.
        /// </summary>
        protected async override void OnAppearing()
        {
            this.MainWrapperLayout.Opacity = 0;
            await this.MainWrapperLayout.FadeTo(1, 500, easing: Easing.SinIn);

            base.OnAppearing();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:modules.Views.LoginPage"/> class.
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ons the canvas view paint surface.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="args">Arguments.</param>
        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            var w = args.Info.Size.Width;
            var h = args.Info.Size.Height;
            var surface = args.Surface;

            var canvas = surface.Canvas;
            canvas.Clear(SKColors.Transparent);

            var paint = new SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Fill,
                Color = SKColor.Parse("#FFFFFF"),
                StrokeWidth = 0
            };

            var path = new SKPath { FillType = SKPathFillType.EvenOdd };
            path.MoveTo(0, h);
            path.LineTo(w, h);
            path.LineTo(w, 0);
            path.LineTo(0, h);
            path.Close();

            canvas.DrawPath(path, paint);
        }
    }
}