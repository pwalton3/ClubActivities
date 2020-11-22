using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;


#region
using StarTed.BLL;
using StarTed.Entities;
#endregion
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
                ClubController sysmgr = new ClubController();
                List<Clubs> info = sysmgr.Club_List();
                info.Sort((x, y) => x.ClubID.CompareTo(y.ClubID));
                ClubList.DataSource = info;
                ClubList.DataTextField = nameof(Clubs.ClubID);
                ClubList.DataValueField = nameof(Clubs.ClubID);
                ClubList.DataBind();
                ClubList.Items.Insert(0, "select....");
            }
            catch(Exception ex)
            {
                errormsgs.Add(GetInnerException(ex).ToString());
                LoadMessageDisplay(errormsgs, "alert alert-danger");
            }
        }

        protected void ClubList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ClubList.SelectedIndex == 0)
            {
                errormsgs.Add("Please select a club");
                LoadMessageDisplay(errormsgs, "alert alert-danger");
                ClubListGrid.DataSource = null;
                ClubListGrid.DataBind();
            }
            else
            {
                try
                {
                    StartDateController sysmgr = new StartDateController();
                    List<Clubs> info = sysmgr.ClubActivities_FindByClub(ClubList.SelectedValue);
                    if(info.Count == 0)
                    {
                        errormsgs.Add("No data found for that ClubID");
                        LoadMessageDisplay(errormsgs, "alert alert-info");
                    }
                    else
                    {
                        info.Sort((x, y) => x.ClubID.CompareTo(y.ClubID));
                        ClubListGrid.DataSource = info;
                        ClubListGrid.DataBind();
                    }
                }
                catch (Exception ex)
                {
                    errormsgs.Add(GetInnerException(ex).ToString());
                    LoadMessageDisplay(errormsgs, "alert alert-info");
                }
            }
        }
        protected Exception GetInnerException(Exception ex)
        {
            
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            return ex;
        }
        private void LoadMessageDisplay(List<string> errormsglist, string cssClass)
        {
            //Message.CssClass = cssClass;
            //Message.DataSource = errormsglist;
            //Message.DataBind();
        }
    }
}