

//ApiControllerGenerator.generated.cs
//ValuesController.cs
//WebApiConfig.cs
//Global.asax.cs
//AssemblyInfo.cs
//RacePlaceDbf.Context.cs
//RacePlaceDbf.Designer.cs
//AspNetRole.cs
//AspNetUser.cs
//AspNetUserClaim.cs
//AspNetUserLogin.cs
//DatabaseLog.cs
//Entrant.cs
//EntrantEvent.cs
//ErrorLog.cs
//Event.cs
//IndividualResult.cs
//Race.cs
//RaceDetail.cs
//RaceGroup.cs
//RacePlaceDbf.cs
//RaceResult.cs
using System.Linq;
using System.Web.Http.OData;

using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.OData.Builder;

namespace ngRacePlace.ApiControllers
{
    public static class ApiControllerHelpers
    {
        public static void BuildApiEntities(this ODataConventionModelBuilder builder)
        {
            builder.EntitySet<AspNetRole>("AspNetRoles"); // AspNetRoles
            builder.EntitySet<AspNetUserClaim>("AspNetUserClaims"); // AspNetUserClaims
            builder.EntitySet<AspNetUserLogin>("AspNetUserLogins"); // AspNetUserLogins
            builder.EntitySet<AspNetUser>("AspNetUsers"); // AspNetUsers
            builder.EntitySet<DatabaseLog>("DatabaseLogs"); // DatabaseLogs
            builder.EntitySet<EntrantEvent>("EntrantEvents"); // EntrantEvents
            builder.EntitySet<Entrant>("Entrants"); // Entrants
            builder.EntitySet<ErrorLog>("ErrorLogs"); // ErrorLogs
            builder.EntitySet<Event>("Events"); // Events
            builder.EntitySet<IndividualResult>("IndividualResults"); // IndividualResults
            builder.EntitySet<RaceDetail>("RaceDetails"); // RaceDetails
            builder.EntitySet<RaceGroup>("RaceGroups"); // RaceGroups
            builder.EntitySet<RaceResult>("RaceResults"); // RaceResults
            builder.EntitySet<Race>("Races"); // Races
        }
    }
    public class AspNetRolesController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public AspNetRolesController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public AspNetRolesController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/AspNetRole
        public IQueryable<AspNetRole> Get()
        {
            return _db.AspNetRoles;
        }

        // GET api/AspNetRole/5
        public AspNetRole Get(string id) // AspNetRoles
        {
            return _db.AspNetRoles.FirstOrDefault(x => x.Id == id);
        }

    }
    public class AspNetUserClaimsController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public AspNetUserClaimsController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public AspNetUserClaimsController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/AspNetUserClaim
        public IQueryable<AspNetUserClaim> Get()
        {
            return _db.AspNetUserClaims;
        }

        // GET api/AspNetUserClaim/5
        public AspNetUserClaim Get(int id) // AspNetUserClaims
        {
            return _db.AspNetUserClaims.FirstOrDefault(x => x.Id == id);
        }

    }
    public class AspNetUserLoginsController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public AspNetUserLoginsController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public AspNetUserLoginsController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/AspNetUserLogin
        public IQueryable<AspNetUserLogin> Get()
        {
            return _db.AspNetUserLogins;
        }

        // GET api/AspNetUserLogin/5
        public AspNetUserLogin Get(string id) // AspNetUserLogins
        {
            return _db.AspNetUserLogins.FirstOrDefault(x => x.UserId == id);
        }

    }
    public class AspNetUsersController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public AspNetUsersController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public AspNetUsersController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/AspNetUser
        public IQueryable<AspNetUser> Get()
        {
            return _db.AspNetUsers;
        }

        // GET api/AspNetUser/5
        public AspNetUser Get(string id) // AspNetUsers
        {
            return _db.AspNetUsers.FirstOrDefault(x => x.Id == id);
        }

    }
    public class DatabaseLogsController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public DatabaseLogsController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public DatabaseLogsController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/DatabaseLog
        public IQueryable<DatabaseLog> Get()
        {
            return _db.DatabaseLogs;
        }

        // GET api/DatabaseLog/5
        public DatabaseLog Get(int id) // DatabaseLogs
        {
            return _db.DatabaseLogs.FirstOrDefault(x => x.DatabaseLogID == id);
        }

    }
    public class EntrantEventsController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public EntrantEventsController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public EntrantEventsController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/EntrantEvent
        public IQueryable<EntrantEvent> Get()
        {
            return _db.EntrantEvents;
        }

        // GET api/EntrantEvent/5
        public EntrantEvent Get(int id) // EntrantEvents
        {
            return _db.EntrantEvents.FirstOrDefault(x => x.EntrantEventId == id);
        }

    }
    public class EntrantsController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public EntrantsController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public EntrantsController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/Entrant
        public IQueryable<Entrant> Get()
        {
            return _db.Entrants;
        }

        // GET api/Entrant/5
        public Entrant Get(int id) // Entrants
        {
            return _db.Entrants.FirstOrDefault(x => x.EntrantId == id);
        }

    }
    public class ErrorLogsController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public ErrorLogsController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public ErrorLogsController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/ErrorLog
        public IQueryable<ErrorLog> Get()
        {
            return _db.ErrorLogs;
        }

        // GET api/ErrorLog/5
        public ErrorLog Get(int id) // ErrorLogs
        {
            return _db.ErrorLogs.FirstOrDefault(x => x.ErrorLogID == id);
        }

    }
    public class EventsController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public EventsController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public EventsController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/Event
        public IQueryable<Event> Get()
        {
            return _db.Events;
        }

        // GET api/Event/5
        public Event Get(int id) // Events
        {
            return _db.Events.FirstOrDefault(x => x.EventTypeId == id);
        }

    }
    public class IndividualResultsController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public IndividualResultsController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public IndividualResultsController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/IndividualResult
        public IQueryable<IndividualResult> Get()
        {
            return _db.IndividualResults;
        }

        // GET api/IndividualResult/5
        public IndividualResult Get(int id) // IndividualResults
        {
            return _db.IndividualResults.FirstOrDefault(x => x.IndividualResultId == id);
        }

    }
    public class RaceDetailsController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public RaceDetailsController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public RaceDetailsController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/RaceDetail
        public IQueryable<RaceDetail> Get()
        {
            return _db.RaceDetails;
        }

        // GET api/RaceDetail/5
        public RaceDetail Get(int id) // RaceDetails
        {
            return _db.RaceDetails.FirstOrDefault(x => x.RaceDetailId == id);
        }

    }
    public class RaceGroupsController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public RaceGroupsController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public RaceGroupsController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/RaceGroup
        public IQueryable<RaceGroup> Get()
        {
            return _db.RaceGroups;
        }

        // GET api/RaceGroup/5
        public RaceGroup Get(int id) // RaceGroups
        {
            return _db.RaceGroups.FirstOrDefault(x => x.RaceGroupTypeId == id);
        }

    }
    public class RaceResultsController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public RaceResultsController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public RaceResultsController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/RaceResult
        public IQueryable<RaceResult> Get()
        {
            return _db.RaceResults;
        }

        // GET api/RaceResult/5
        public RaceResult Get(int id) // RaceResults
        {
            return _db.RaceResults.FirstOrDefault(x => x.EntrantEventId == id);
        }

    }
    public class RacesController : ODataController
    {
        readonly RacePlaceDbfEntities _db;

        public RacesController()
        {
            _db = new RacePlaceDbfEntities();
        }

        public RacesController(RacePlaceDbfEntities db)
        {
            _db = db;
        }

        /// GET api/Race
        public IQueryable<Race> Get()
        {
            return _db.Races;
        }

        // GET api/Race/5
        public Race Get(int id) // Races
        {
            return _db.Races.FirstOrDefault(x => x.RaceId == id);
        }

    }

    public class ValuesOController : ODataController
    {
        /// GET api/ValuesO
        public IEnumerable<string> Get()
        {
            return new string[] { "value1OData", "value2OData" };
        }

        /// GET api/ValuesO/5
        public string Get(int id)
        {
            return "OData";
        }
    }

    public class ValuesController : ApiController
    {
        /// GET api/Values
        public IEnumerable<string> Get()
        {
            return new string[] { "apiValue1", "apiValue2" };
        }

        /// GET api/Values/5
        public string Get(int id)
        {
            return "apiValue";
        }
    }
}