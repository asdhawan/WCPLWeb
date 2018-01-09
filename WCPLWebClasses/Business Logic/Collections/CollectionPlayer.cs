using System.Collections.Generic;

namespace WCPLWebClasses {
    public class CollectionPlayer : List<Player> {
        public static CollectionPlayer GetAllPlayers() { return daPlayer.GetAllPlayers(); }
    }
}
