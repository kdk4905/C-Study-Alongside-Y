namespace _01HellowCSharpWin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //For1을 새로 만들고 띄우면서
            //메인이 끝남
            //메인을 건드릴 일은 거의 없음
            Application.Run(new Calculator());
        }
    }
}