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
                .Run();
        }
    }
}
