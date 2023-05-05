namespace WeddingManagement
{
    internal class LobbyType
    {
        private string LobbyTypeNo { get; set; }
        private string LobbyName { get; set; }
        private long MinTablePrice { get; set; }
        private bool Available { get; set; }

        public LobbyType(string LobbyTypeNo, string LobbyName, 
            long MinTablePrice, bool available)
        {
            this.LobbyTypeNo = LobbyTypeNo;
            this.LobbyName = LobbyName;
            this.MinTablePrice = MinTablePrice;
            Available = available;
        }

        public LobbyType() { }
    }
}
