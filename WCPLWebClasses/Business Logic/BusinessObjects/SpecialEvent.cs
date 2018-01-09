using CommonUtils;
using System;

namespace WCPLWebClasses {
    public class SpecialEvent : BaseBusinessObject<SpecialEvent> {
        //Properties
        [System.ComponentModel.DataAnnotations.Key]
        public int SpecialEventId { get; set; }
        public string EventName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool EntryFeeYN { get; set; }
        public decimal? EntryFeeAmount { get; set; }
        public decimal? EntryFeeAmountOnline { get; set; }
        public bool RegistrationRequiredYN { get; set; }
        public DateTime? RegistrationStartDate { get; set; }
        public DateTime? RegistrationEndDate { get; set; }
        public string CustomPageURL { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool MultiLeagueEventYN { get; set; }

        //Public Methods
        public override void Update() { daSpecialEvent.Update(this); }
        public override SpecialEvent UpdateAndReturn() { Update(); return GetOneSpecialEvent(SpecialEventId); }
        public override void Insert() { daSpecialEvent.Insert(this); }
        public override SpecialEvent InsertAndReturn() { Insert(); return GetOneSpecialEvent(SpecialEventId); }

        public override void Delete() { daSpecialEvent.Delete(this); }

        //Data Access Methods
        public static SpecialEvent GetOneSpecialEvent(int SpecialEventId) { return daSpecialEvent.GetOneSpecialEvent(SpecialEventId); }
    }
}
