namespace UnoServer
{
    public class Room
    {
        public string Id { get; set; }
        public List<string> PlayerList { get; set; }

        public Room(string roomId, string playerId)
        {
            Id = roomId;
            PlayerList = new List<string>();
            PlayerList.Add(playerId);
        }

        public void Join(string playerId)
        {

        }
    }
}
