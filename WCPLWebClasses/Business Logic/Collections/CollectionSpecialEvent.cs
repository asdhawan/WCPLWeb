using System.Collections.Generic;

namespace WCPLWebClasses {
    public class CollectionSpecialEvent : List<SpecialEvent> {
        public static CollectionSpecialEvent GetAllSpecialEvents() { return daSpecialEvent.GetAllSpecialEvents(); }
    }
}
