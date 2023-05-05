using System;

namespace WeddingManagement
{
    internal class Shift
    {
        private string ShiftNo;
        private string ShiftName;
        private TimeSpan Starting;
        private TimeSpan Ending;
        private bool Available;

        public Shift(string ShiftNo, string ShiftName, TimeSpan Starting, 
            TimeSpan Ending, bool available)
        {
            this.ShiftNo = ShiftNo;
            this.ShiftName = ShiftName;
            this.Starting = Starting;
            this.Ending = Ending;
            Available = available;
        }

        public Shift()
        {
        }
    }
}
