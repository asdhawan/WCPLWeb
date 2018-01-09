using CommonEFUtils;
using CommonUtils;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace WCPLWebClasses {
    internal class daPlayer : BaseCollectableDataObject<Player, WCPLWebEntities.Player, WCPLWebEntities.wcplDbEntities> {
        internal static CollectionPlayer GetAllPlayers() { return GetData(); }

        internal static Player GetOnePlayer(int PlayerId) { return GetData(filterOnRecId(PlayerId)).FirstOrDefault(); }

        internal static void Insert(Player o) { WCPLWebEntities.wcplDbEntities context = NewEntityContext(); o.PlayerId = Insert(o, context, context.Players).PlayerId; }
        internal static void Update(Player o) { WCPLWebEntities.wcplDbEntities context = NewEntityContext(); Update(o, context, context.Players); }
        internal static void Delete(Player o) { WCPLWebEntities.wcplDbEntities context = NewEntityContext(); Delete(o, context, context.Players); }

        internal static void SaveCollection(Dictionary<Player, CommonEnums.DBChangeType> changesDictionary) {
            WCPLWebEntities.wcplDbEntities context = NewEntityContext();
            SaveCollection(changesDictionary, context, context.Players);
        }

        internal static Expression<Func<WCPLWebEntities.Player, Player>> EntityMappingExpression { get { return x => AutoMapper.Mapper.Map<WCPLWebEntities.Player, Player>(x); } }

        private static CollectionPlayer GetData(Expression<Func<WCPLWebEntities.Player, bool>> filterExpression = null) {
            CollectionPlayer retData = new CollectionPlayer();
            retData.AddRange(
                NewEntityContext().Players
                    .AsExpandable()
                    .Where(filterExpression ?? NoFilter)
                    .AsEnumerable()
                    .Select(x => AutoMapper.Mapper.Map<WCPLWebEntities.Player, Player>(x))
                    .OrderBy(x => x.PlayerId));
            return retData;
        }

        private static Expression<Func<WCPLWebEntities.Player, bool>> filterOnRecId(int PlayerId) { return x => x.PlayerId == PlayerId; }
    }
}
