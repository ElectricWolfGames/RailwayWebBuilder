using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Linq;
using System.Windows.Media.Imaging;
using System.Windows.Interop;
using System.Reflection.Metadata;
using System.Xml.Linq;
using RailwayWebBuilderCore.Services;
using RailwayWebBuilderCore.KeepForNow;

namespace ThumbnailCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.P)
            {
                string file = "E:\\Trains\\Photos - Main\\2024 Layouts\\Layouts\\Arnold Lane\\Text.png";
                UIElement element = this.Content as UIElement;
                Uri path = new Uri(file);
                CaptureScreen(element, path);
            }
            if (e.Key == Key.A)
            {
                CreateForAllLayouts();
            }

        }

        private void CreateForAllLayouts()
        {
            var layoutDetails = ServiceLocator.Instance.GetService<LayoutbyLayoutDetailsServices>();
            foreach (var layout in layoutDetails.Layouts)
            {
                var (name, gauge) = ItemHelper.GetEnumDescription(layout.Name);
                TextContent.Text = name;

                var gaugeText = ItemHelper.GetEnumGaugeDescription(gauge);
                TextContent2.Text = gaugeText;


                TextContent.InvalidateVisual();
                TextContent2.InvalidateVisual();
                TextContent.UpdateLayout();
                TextContent2.UpdateLayout();

                string file = $"E:\\Trains\\Photos - Main\\2024 Layouts\\Layouts\\{name}\\";
                Directory.CreateDirectory(file);
                UIElement element = this.Content as UIElement;
                Uri path = new Uri(file+"Text.png");
                CaptureScreen(element, path);
            }
        }

        public void CaptureScreen(UIElement source, Uri destination)
        {
            try
            {
                double height, renderHeight, width, renderWidth;

                height = renderHeight = source.RenderSize.Height;
                width = renderWidth = source.RenderSize.Width;

                //Specification for target bitmap like width/height pixel etc.
                RenderTargetBitmap renderTarget = new
                RenderTargetBitmap((int)renderWidth, (int)renderHeight, 0, 0,
                PixelFormats.Pbgra32);
                //creates Visual Brush of UIElement
                VisualBrush visualBrush = new VisualBrush(source);

                DrawingVisual drawingVisual = new DrawingVisual();
                using (DrawingContext drawingContext =
                drawingVisual.RenderOpen())
                {
                    //draws image of element
                    drawingContext.DrawRectangle(visualBrush, null, new
                    Rect(new Point(0, 0), new Point(width, height)));
                }
                //renders image
                renderTarget.Render(drawingVisual);

                //PNG encoder for creating PNG file
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(renderTarget));
                using (FileStream stream = new
                FileStream(destination.LocalPath, FileMode.Create,
                FileAccess.Write))
                {
                    encoder.Save(stream);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

    }


    }