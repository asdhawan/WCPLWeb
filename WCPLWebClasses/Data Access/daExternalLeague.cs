using CommonEFUtils;
using CommonUtils;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace WCPLWebClasses {
    internal class daExternalLeague : BaseCollectableDataObject<ExternalLeague, WCPLWebEntities.ExternalLeague, WCPLWebEntities.wcplDbEntities> {
        internal static CollectionExternalLeague GetAllExternalLeagues() { return GetData(); }
        internal static CollectionExternalLeague GetAllExternalLeagues(int specialEventId) { return GetData(filterOnSpecialEventId(specialEventId)); }

        internal static ExternalLeague GetOneExternalLeague(int ExternalLeagueId) { return GetData(filterOnRecId(ExternalLeagueId)).FirstOrDefault(); }

        internal static void Insert(ExternalLeague o) { WCPLWebEntities.wcplDbEntities context = NewEntityContext(); o.ExternalLeagueId = Insert(o, context, context.ExternalLeagues).ExternalLeagueId; }
        internal static void Update(ExternalLeague o) { WCPLWebEntities.wcplDbEntities context = NewEntityContext(); Update(o, context, context.ExternalLeagues); }
        internal static void Delete(ExternalLeague o) { WCPLWebEntities.wcplDbEntities context = NewEntityContext(); Delete(o, context, context.ExternalLeagues); }

        internal static void SaveCollection(Dictionary<ExternalLeague, CommonEnums.DBChangeType> changesDictionary) {
            WCPLWebEntities.wcplDbEntities context = NewEntityContext();
            SaveCollection(changesDictionary, context, context.ExternalLeagues);
        }

        internal static Expression<Func<WCPLWebEntities.ExternalLeague, ExternalLeague>> EntityMappingExpression { get { return x => AutoMapper.Mapper.Map<WCPLWebEntities.ExternalLeague, ExternalLeague>(x); } }

        private static CollectionExternalLeague GetData(Expression<Func<WCPLWebEntities.ExternalLeague, bool>> filterExpression = null) {
            CollectionExternalLeague retData = new CollectionExternalLeague();
            retData.AddRange(
                NewEntityContext().ExternalLeagues
                    .AsExpandable()
                    .Where(filterExpression ?? NoFilter)
                    .AsEnumerable()
                    .Select(x => AutoMapper.Mapper.Map<WCPLWebEntities.ExternalLeague, ExternalLeague>(x))
                    .OrderBy(x => x.ExternalLeagueId));
            return retData;
        }

        private static Expression<Func<WCPLWebEntities.ExternalLeague, bool>> filterOnRecId(int ExternalLeagueId) { return x => x.ExternalLeagueId == ExternalLeagueId; }
        private static Expression<Func<WCPLWebEntities.ExternalLeague, bool>> filterOnSpecialEventId(int specialEventId) { return x => x.SpecialEvent_ExternalLeague.Where(y => y.SpecialEventId == specialEventId).Select(y => y.ExternalLeagueId).Contains(x.ExternalLeagueId); }
    }
}
