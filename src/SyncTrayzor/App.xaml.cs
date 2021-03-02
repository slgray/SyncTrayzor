using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;

namespace SyncTrayzor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // WPF force software rendering
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            RenderOptions.ProcessRenderMode = RenderMode.SoftwareOnly;
        }
    }
}
