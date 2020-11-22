using StarTed.DAL;
using StarTed.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTed.BLL
{
    public class StartDateController
    {
        public List<Clubs> ClubActivities_FindByClubAndDate(DateTime startdate)
        {
            using (var context = new DAL.StarTedContext())
            {
                IEnumerable<Clubs> results =
                    context.Database.SqlQuery<Clubs>("ClubActivities_FindByClubAndDate @StartDate", startdate);
                return results.ToList();
            }

        }
        public List<Clubs> ClubActivities_FindByClub(string ClubID)
        {
            using (var context = new StarTedContext())
            {
                IEnumerable<Clubs> results =
                    context.Database.SqlQuery<Clubs>("ClubActivities_FindByClub @ClubID", ClubID);
                return results.ToList();
            }
        }
    }
}
