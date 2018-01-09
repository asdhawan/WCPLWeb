using System.Collections.Generic;

namespace WCPLWebClasses {
    public class CollectionExternalLeague : List<ExternalLeague> {
        public static CollectionExternalLeague GetAllExternalLeagues() { return daExternalLeague.GetAllExternalLeagues(); }
        public static CollectionExternalLeague GetAllExternalLeagues(int specialEventId) { return daExternalLeague.GetAllExternalLeagues(specialEventId); }
    }
}
