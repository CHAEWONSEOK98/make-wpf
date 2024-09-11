using WpfExplorer.Properties;

namespace WpfExplorer
{
    class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .AddWireDataContext<WireDataContext>()
                .AddInversionModule<HelperModules>()
                .AddInversionModule<ViewModules>()
                .Run();
        }
    }
}
