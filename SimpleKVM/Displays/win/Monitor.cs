using DDCKVMService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace SimpleKVM.Displays.win
{
    public class Monitor : Displays.Monitor
    {
        public Monitor(string uniqueId, string model, List<int> validSources) : base(uniqueId, model, validSources)
        {
        }

        public override int GetCurrentSource()
        {
            uint currentSource = 0;
            MonitorController.EnumMonitors(physicalMonitor =>
            {
                if (physicalMonitor.UniqueId == MonitorUniqueId)
                {
                    physicalMonitor.PhysicalMonitor.GetVCPRegister(0x60, out currentSource);
                }
            });

            return (int)currentSource;
        }

        //public static string ControlMyMonitorExe => Path.Combine(AppDomain.CurrentDomain.BaseDirectory ?? "", @"ext\win\controlmymonitor\ControlMyMonitor.exe");

        public override bool SetSource(int newSourceId, int secondSourceId)
        {
            /*
            var monitorListCommand = new ProcessStartInfo
            {
                FileName = ControlMyMonitorExe,
                Arguments = $"/SetValueIfNeeded \"{ MonitorDeviceName }\" 60 {inputId}"
            };

            monitorListCommand.StartAndReadStdout();
            */

            bool result = false;
            MonitorController.EnumMonitors(physicalMonitor =>
            {
                if (physicalMonitor.UniqueId == MonitorUniqueId)
                {
                    physicalMonitor.PhysicalMonitor.GetVCPRegister(0x60, out uint currentSource);
                    uint bogus = 4864;

                    if (newSourceId == secondSourceId)
                    {
                        physicalMonitor.PhysicalMonitor.SetVCPRegister(0x60, (uint)newSourceId); // TODO force change to newSourceId
                    }
                    else if (currentSource == bogus + newSourceId)
                    {
                        physicalMonitor.PhysicalMonitor.SetVCPRegister(0x60, (uint)secondSourceId); // TODO change to secondary source
                    }
                    else if(currentSource == bogus + secondSourceId) // TODO check with secondary source
                    {
                        physicalMonitor.PhysicalMonitor.SetVCPRegister(0x60, (uint)newSourceId); // TODO change to new source
                    }
                }
            });

            return result;
        }
    }
}
