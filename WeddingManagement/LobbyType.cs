namespace WeddingManagement
{
    internal class LobbyType
    {
        public string LobbyTypeNo { get; set; }
        public string LobbyName { get; set; }
        public long MinTablePrice { get; set; }

        public LobbyType(string LobbyTypeNo, string LobbyName, long MinTablePrice)
        {
            this.LobbyTypeNo = LobbyTypeNo;
            this.LobbyName = LobbyName;
            this.MinTablePrice = MinTablePrice;
        }

        public LobbyType() { }
    }
}
