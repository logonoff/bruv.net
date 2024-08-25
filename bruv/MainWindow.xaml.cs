using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Windows.Interop;

namespace bruv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Random random = new Random();

            int fate = random.Next(1, 3);

            if (fate == 1)
            {
                (new System.Media.SoundPlayer(bruv.Properties.Resources.bruv)).Play();
            } else
            {
                (new System.Media.SoundPlayer(bruv.Properties.Resources.bruh)).Play();
            }

            // Construct an Icon.
            Icon icon1 = new Icon(SystemIcons.Error, 68, 68);

            // Call ToBitmap to convert it.
            Bitmap bmp = icon1.ToBitmap();

            // Convert bitmap to ImageBrush
            var bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(bmp.GetHbitmap(),
                                              IntPtr.Zero,
                                              Int32Rect.Empty,
                                              BitmapSizeOptions.FromEmptyOptions());

            thisIsARectangle.Fill = new ImageBrush(bitmapSource);
        }

        private void LeaveTheFuckOut(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
