using CommonUtils;
using System;

namespace WCPLWebClasses {
    public class Player : BaseBusinessObject<Player> {
        //Properties
        [System.ComponentModel.DataAnnotations.Key]
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreateDateTime { get; set; }

        //Public Methods
        public override void Update() { daPlayer.Update(this); }
        public override Player UpdateAndReturn() { Update(); return GetOnePlayer(PlayerId); }
        public override void Insert() { daPlayer.Insert(this); }
        public override Player InsertAndReturn() { Insert(); return GetOnePlayer(PlayerId); }

        public override void Delete() { daPlayer.Delete(this); }

        //Data Access Methods
        public static Player GetOnePlayer(int playerId) { return daPlayer.GetOnePlayer(playerId); }
    }
}
