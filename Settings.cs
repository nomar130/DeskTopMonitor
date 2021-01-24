using System;
using System.Collections.Generic;
using System.Text;

namespace DeskTopMonitor
{
    public class Settings
    {
        public string ID, Password, MailTo;
        public int HH1, HH2, HH3, mm1, mm2, mm3;
        public bool RunPerHour;
        public DateTime LastExitTime;
    }
}
