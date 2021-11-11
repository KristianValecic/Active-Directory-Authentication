using System;
using System.DirectoryServices;

namespace Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ErrorMessage.Visible = false;
            txtResults.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (GetAllUsers())
            {
                txtResults.Visible = true;
            }
            else
            {
                ErrorMessage.Visible = true;
            }
        }

        protected bool GetAllUsers()
        {

            DirectoryEntry de = new DirectoryEntry("LDAP://192.168.229.130", Username.Value, Password.Value);

            DirectorySearcher ds = new DirectorySearcher(de);
            ds.Filter = "(&(objectCategory=User)(objectClass=person))";

            SearchResultCollection results;
            try
            {
                txtResults.Items.Clear();
                results = ds.FindAll();
                foreach (SearchResult sr in results)
                {
                    txtResults.Visible = true;
                    txtResults.Items.Add(sr.Properties["name"][0].ToString());
                }
                return true;
            }
            catch
            {
                txtResults.Items.Clear();
                return false;
            }

        }

    }
}