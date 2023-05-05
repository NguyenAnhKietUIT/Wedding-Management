namespace WeddingManagement
{
    internal class Service
    {
        private string ServiceNo;
        private string ServiceName;
        private long ServicePrice;
        private string Note;
        private bool Available;

        public Service(string ServiceNo, string ServiceName, long ServicePrice, 
            string Note = "", bool available = true)
        {
            this.ServiceNo = ServiceNo;
            this.ServiceName = ServiceName;
            this.ServicePrice = ServicePrice;
            this.Note = Note;
            Available = available;
        }

        public Service() { }
    }
}
