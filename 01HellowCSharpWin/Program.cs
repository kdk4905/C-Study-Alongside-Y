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
            //For1�� ���� ����� ���鼭
            //������ ����
            //������ �ǵ帱 ���� ���� ����
            Application.Run(new Calculator());
        }
    }
}