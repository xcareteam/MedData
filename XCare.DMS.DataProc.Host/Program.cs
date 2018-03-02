using System;
using System.Windows.Forms;
using log4net;
using XCare.DMS.DataProc.Daemon;
using XCare.DMS.DataProc.MessageHandler;

namespace XCare.DMS.DataProc.Host
{
    internal static class Program
    {
        private static readonly ILog Log = LogManager.GetLogger("ErrorLogger");

        /// <summary>
        ///     应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BindExceptionHandler();
            MessageBus.Start();
            DaemonService.Start();
            Application.ApplicationExit += (sender, e) => { MessageBus.Stop(); };
            Application.Run(new FrmMain());
        }

        private static void BindExceptionHandler()
        {
            //设置应用程序处理异常方式：ThreadException处理
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //处理UI线程异常
            Application.ThreadException += (sender, e) => { Log.Error(null, e.Exception); };
            //处理未捕获的异常
            AppDomain.CurrentDomain.UnhandledException +=
                (sender, e) => { Log.Error(null, e.ExceptionObject as Exception); };
        }
    }
}