using Harsco.HTS.ViewModels;

namespace Harsco.HTS.API.Helpers
{
    public class Common
    {
        public bool isLoggedInEqualsDisplay(vmProfile loggedInUser, vmProfile displayUser)
        {
            if (loggedInUser.ProfileId == displayUser.ProfileId)
                return true;
            else
                return false;
        }
    }
}