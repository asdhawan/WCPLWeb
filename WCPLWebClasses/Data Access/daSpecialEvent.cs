using CommonEFUtils;
using CommonUtils;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace WCPLWebClasses {
    internal class daSpecialEvent : BaseCollectableDataObject<SpecialEvent, WCPLWebEntities.SpecialEvent, WCPLWebEntities.wcplDbEntities> {
        internal static CollectionSpecialEvent GetAllSpecialEvents() { return GetData(); }

        internal static SpecialEvent GetOneSpecialEvent(int specialEventId) { return GetData(filterOnRecId(specialEventId)).FirstOrDefault(); }

        internal static void Insert(SpecialEvent o) { WCPLWebEntities.wcplDbEntities context = NewEntityContext(); o.SpecialEventId = Insert(o, context, context.SpecialEvents).SpecialEventId; }
        internal static void Update(SpecialEvent o) { WCPLWebEntities.wcplDbEntities context = NewEntityContext(); Update(o, context, context.SpecialEvents); }
        internal static void Delete(SpecialEvent o) { WCPLWebEntities.wcplDbEntities context = NewEntityContext(); Delete(o, context, context.SpecialEvents); }

        internal static void SaveCollection(Dictionary<SpecialEvent, CommonEnums.DBChangeType> changesDictionary) {
            WCPLWebEntities.wcplDbEntities context = NewEntityContext();
            SaveCollection(changesDictionary, context, context.SpecialEvents);
        }

        internal static Expression<Func<SpecialEvent, SpecialEvent>> EntityMappingExpression { get { return x => AutoMapper.Mapper.Map<SpecialEvent, SpecialEvent>(x); } }

        private static CollectionSpecialEvent GetData(Expression<Func<WCPLWebEntities.SpecialEvent, bool>> filterExpression = null) {
            CollectionSpecialEvent retData = new CollectionSpecialEvent();
            retData.AddRange(
                NewEntityContext().SpecialEvents
                    .AsExpandable()
                    .Where(filterExpression ?? NoFilter)
                    .AsEnumerable()
                    .Select(x => AutoMapper.Mapper.Map<WCPLWebEntities.SpecialEvent, SpecialEvent>(x))
                    .OrderBy(x => x.SpecialEventId));
            return retData;
        }

        private static Expression<Func<WCPLWebEntities.SpecialEvent, bool>> filterOnRecId(int SpecialEventId) { return x => x.SpecialEventId == SpecialEventId; }
    }
}
