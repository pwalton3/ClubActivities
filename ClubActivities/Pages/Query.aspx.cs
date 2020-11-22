using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClubActivities.Pages
{
    public partial class Query : System.Web.UI.Page
    {
        List<string> errormsgs = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                BindClubList();

            }
        }

        private void BindClubList()
        {
            try
            {
                ClubContoller
            }
        }

        protected void ClubList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ClubList.SelectedIndex == 0)
            {
                errormsgs.Add("Please select a club");
                LoadMessageDisplay(errormsgs, "alert alert-danger");
            }
            else
            {

            }
        }

        private void LoadMessageDisplay(List<string> errormsgs, string v)
        {
            throw new NotImplementedException();
        }
    }
}