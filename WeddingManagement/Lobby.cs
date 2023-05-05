namespace WeddingManagement
{
    internal class Lobby
    {
        private string LobbyNo;
        private string LobbyTypeNo;
        private string LobbyName;
        private int MaxTable;
        private string Note;
        private bool Available;

        public Lobby() { }

        public Lobby(string LobbyNo, string LobbyTypeNo, string LobbyName, 
            int MaxTable, string Note, bool available)
        {
            this.LobbyNo = LobbyNo;
            this.LobbyTypeNo = LobbyTypeNo;
            this.LobbyName = LobbyName;
            this.MaxTable = MaxTable;
            this.Note = Note;
            Available = available;
        }
    }
}
