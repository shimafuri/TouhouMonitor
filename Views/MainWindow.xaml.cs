using System;
using System.Windows;
using System.Windows.Interop;

namespace TouhouMonitor.Views
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

        private void Window_SourceInitialized(object sender, EventArgs e)
        {
            IntPtr hwnd = new WindowInteropHelper((Window)sender).Handle;
            
            int old = PInvoke.User32.GetWindowLong(hwnd, PInvoke.User32.WindowLongIndexFlags.GWL_STYLE);
            PInvoke.User32.SetWindowLong(
                hwnd,
                PInvoke.User32.WindowLongIndexFlags.GWL_STYLE,
                (PInvoke.User32.SetWindowLongFlags)old & ~PInvoke.User32.SetWindowLongFlags.WS_MAXIMIZEBOX
            );
        }
    }
}
