using DEMO_PROJECT_07226.Business.services;

namespace DEMO_PROJECT_07226;

internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        ApplicationConfiguration.Initialize();
        MainService.getInstance().OpenMainWindow();
    }
}