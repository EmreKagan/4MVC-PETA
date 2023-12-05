
using GoogleAuthentication.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Expense_Tracker.Models
{
    public class UserProfileModel
    {
        public List<string> UserProfile(JObject user) 
        {
            string id = user["id"].ToString();
            string email = user["email"].ToString();
            string verified_email = user["verified_email"].ToString();
            string name = user["name"].ToString();
            string given_name = user["given_name"].ToString();
            string family_name = user["family_name"].ToString();
            string picture = user["picture"].ToString();
            string locale = user["locale"].ToString();
            var result = new List<string> { id,email,verified_email,name,given_name,family_name,picture,locale };
            return result;
        }


    }
}
