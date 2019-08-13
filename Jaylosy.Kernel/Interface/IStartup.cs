using System;
using System.Collections.Generic;
using System.Text;

namespace Jaylosy.Kernel.Interface
{
    public delegate int RunCallback(string result);
    public delegate int ExecuteCmdCallback(int cmd, string result);
    public interface IStartup
    {
        void Run(string[] parms, RunCallback callback);
        void ExecuteCmd(int cmd, string data);
        void ExecuteCmd(int cmd, string data, ExecuteCmdCallback callback);
    }
}
