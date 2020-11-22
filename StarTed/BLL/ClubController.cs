using StarTed.DAL;
using StarTed.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTed.BLL
{
    class ClubController
    {
        public List<Clubs> Club_List()
        {
            using (var context = new StarTedContext())
            {
                return context.Clubs.ToList();
            }
        }
    }
}
