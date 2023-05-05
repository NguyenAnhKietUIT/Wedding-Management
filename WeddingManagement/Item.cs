namespace WeddingManagement
{
    internal class Item
    {
        private string ItemNo;
        private string ItemName;
        private long ItemPrice;
        private string Note;
        private bool Available;

        public Item(string ItemNo, string ItemName, 
            long ItemPrice, string Note = "", bool available = true)
        {
            this.ItemNo = ItemNo;
            this.ItemName = ItemName;
            this.ItemPrice = ItemPrice;
            this.Note = Note;
            Available = available;
        }

        public Item() { }
    }
}
