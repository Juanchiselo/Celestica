using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Windows.Forms;
using System.Collections;

namespace ITInventory
{
    public class ActiveDirectory
    {

        private static readonly ActiveDirectory instance = new ActiveDirectory();

        public static ActiveDirectory Instance
        {
            get
            {
                return instance;
            }
        }

        private string CreateLDAPPath(string domain, string site)
        {
            string path = "LDAP://" + domain + "/OU=Users,OU=" + site
                + ",DC=americas,DC=ad,DC=celestica,DC=com";

            return path;
        }

        public void GetUserInformation(string username, string domain, string site)
        {
            DirectoryEntry entry = new DirectoryEntry();
            entry.Path = CreateLDAPPath(domain, site);
            entry.AuthenticationType = AuthenticationTypes.Secure;

            DirectorySearcher searcher = new DirectorySearcher(entry);
            searcher.SearchRoot = entry;
            searcher.Filter = "(&(objectCategory=person)(objectClass=user)(sAMAccountName=" + username + "))";

            searcher.PropertiesToLoad.Add("givenname");
            searcher.PropertiesToLoad.Add("sn");

            SearchResult result = searcher.FindOne();

            if (result != null)
            {
                MessageBox.Show(result.Properties["givenname"][0].ToString());
                MessageBox.Show(result.Properties["sn"][0].ToString());
            }
            else
            {
                MessageBox.Show("Not found");
                return;
            }

            

            entry.Dispose();
            searcher.Dispose();
        }
       
        public bool Authenticate(string username,
            string password, string domain)
        {
            bool authentic = false;
            try
            {
                DirectoryEntry entry = new DirectoryEntry("LDAP://" + domain,
                    username, password);
                object nativeObject = entry.NativeObject;
                authentic = true;
            }
            catch (DirectoryServicesCOMException) { }
            return authentic;
        }

        public static List<string> ListOU(string domain)
        {
            List<string> ous = new List<string>();
            using (DirectoryEntry root = new DirectoryEntry("LDAP://" + domain))
            {
                DirectorySearcher searcher = new DirectorySearcher(root);
                searcher.Filter = "(&(objectClass=organizationalUnit))";
                searcher.SearchScope = SearchScope.OneLevel;
                searcher.PropertiesToLoad.Add("ou");
                searcher.Filter = "(objectCategory=organizationalUnit)";

                var result = searcher.FindAll();
                foreach (SearchResult entry in result)
                {
                    ous.Add(entry.GetDirectoryEntry().Properties["ou"][0].ToString());
                }

                result.Dispose();
                searcher.Dispose();
            }
            return ous;
        }
        
//// define properties to load - here I just get the "OU" attribute, the name of the OU
//ouSearcher.PropertiesToLoad.Add("ou");

//// define filter - only select organizational units
//ouSearcher.Filter = "(objectCategory=organizationalUnit)";

//// do search and iterate over results
//foreach (SearchResult deResult in ouSearcher.FindAll())
//{
//    string ouName = deResult.Properties["ou"][0].ToString();
//    }
    }
}
