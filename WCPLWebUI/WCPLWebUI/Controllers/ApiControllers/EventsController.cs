using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Description;
using System.Web.Mvc;
using WCPLWebClasses;

namespace WCPLWebUI.Controllers.ApiControllers {
    [RoutePrefix("/api/events")]
    public class EventsController : BaseApiController {

        [Route("")]
        [ResponseType(typeof(List<SpecialEvent>))]
        public HttpResponseMessage Get() {
            return ExecuteRequest<List<SpecialEvent>>(() => {
                return CollectionSpecialEvent.GetAllSpecialEvents().ToList();
            });
        }
    }
}