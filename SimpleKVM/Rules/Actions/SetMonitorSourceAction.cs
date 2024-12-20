using SimpleKVM.Displays;
using System;
using System.Collections.Generic;
using System.Text;
using Action = SimpleKVM.Rules.Actions.IAction;

namespace SimpleKVM.Rules.Actions
{
    public class SetMonitorSourceAction : IAction
    {
        public Monitor Monitor;
        public int SetMonitorSourceIdTo;
        public int SetMonitorSourceIdTo2;

        public SetMonitorSourceAction(Monitor monitor, int sourceId, int secondSourceId)
        {
            Monitor = monitor;
            SetMonitorSourceIdTo = sourceId;
            SetMonitorSourceIdTo2 = secondSourceId;
        }

        public bool IsValid()
        {
            //check that the monitor exists
            return true;
        }

        public bool Run()
        {
            if (SetMonitorSourceIdTo == -1) return false;

            var result = Monitor.SetSource(SetMonitorSourceIdTo, SetMonitorSourceIdTo2);
            return result;
        }
    }
}
