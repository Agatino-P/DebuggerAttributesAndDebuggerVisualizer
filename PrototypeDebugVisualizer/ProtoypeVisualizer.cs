using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

[assembly: System.Diagnostics.DebuggerVisualizer(
typeof(PrototypeDebugVisualizer.ProtoypeVisualizer), typeof(VisualizerObjectSource),
Target = typeof(int), Description = "My Visualizer")]
namespace PrototypeDebugVisualizer
{
    public class ProtoypeVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            if  (! (objectProvider.GetObject() is int intList))
                    return;
            
            Window win = new Window();
            win.Title = "My Visualizer";
            win.Width = 400;
            win.Height = 300;
            win.Background = Brushes.Blue;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ListBox lb = new ListBox();
            lb.ItemsSource = new List<int> { intList };
            win.Content = lb;
            win.ShowDialog();
        }

        public static void TestShowVisualizer(object objectToVisualize)
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(ProtoypeVisualizer));
            visualizerHost.ShowVisualizer();
        }
    }
}
