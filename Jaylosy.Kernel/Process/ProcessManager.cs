using System;
using System.Runtime.InteropServices;

namespace Jaylosy.Kernel.Process
{
    public sealed class ProcessManager
    {
        public const uint WM_SYSCOMMAND = 0x0112;
        public const uint SC_MAXIMIZE = 0xF030;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        public bool StartProcess()
        {
            //获取所有进程
            var temp = System.Diagnostics.Process.GetProcesses();
            //获取当前程序运行的进程实例
            var currentProcess = System.Diagnostics.Process.GetCurrentProcess();
            //根据当前进程的名称查找是否已经有相同的进程运行
            foreach(var process in temp)
            {
                if (process.ProcessName == currentProcess.ProcessName && process.Id != currentProcess.Id)
                {
                    //如果找到同名的进程，则最大化窗口并激活显示
                    IntPtr handle = process.MainWindowHandle;
                    SendMessage(handle, WM_SYSCOMMAND, new IntPtr(SC_MAXIMIZE), IntPtr.Zero); // 最大化  
                    SwitchToThisWindow(handle, true);   // 激活  
                    return false;
                }
            }
            return true;
        }

        public void RunExe(string exeFile,string[] args)
        {
            if (args.Length > 0)
            {
                try
                {
                    System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo(exeFile, args[0]);
                    System.Diagnostics.Process.Start(processStartInfo);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
