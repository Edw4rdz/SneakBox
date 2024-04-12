
using System;
using DataServices;
namespace Business_Logic
{
    public class BusinessL
    {
        public bool VerifyingUserLogin(string username, string password)
        {
            DataServicesBL dataService = new DataServicesBL();
            var result1 = dataService.GetUser(username);
            var result2 = dataService.GetPassword(password);
            return result1 != null ? true : false;
        }
    }
}