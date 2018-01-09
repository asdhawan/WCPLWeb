using CommonUtils;
using System;

namespace WCPLWebClasses {
    public class ExternalLeague : BaseBusinessObject<ExternalLeague> {
        //Properties
        [System.ComponentModel.DataAnnotations.Key]
        public int ExternalLeagueId { get; set; }
        public string ExternalLeagueName { get; set; }

        //Public Methods
        public override void Update() { daExternalLeague.Update(this); }
        public override ExternalLeague UpdateAndReturn() { Update(); return GetOneExternalLeague(ExternalLeagueId); }
        public override void Insert() { daExternalLeague.Insert(this); }
        public override ExternalLeague InsertAndReturn() { Insert(); return GetOneExternalLeague(ExternalLeagueId); }

        public override void Delete() { daExternalLeague.Delete(this); }

        //Data Access Methods
        public static ExternalLeague GetOneExternalLeague(int ExternalLeagueId) { return daExternalLeague.GetOneExternalLeague(ExternalLeagueId); }
    }
}
