using System;

namespace EventMgr.Services
{
    public class SessionState
    {
        public string? UserName { get; set; }
        public bool IsLoggedIn { get; set; } = false;

        public void LogIn(string userName)
        {
            UserName = userName;
            IsLoggedIn = true;
        }

        public void LogOut()
        {
            UserName = null;
            IsLoggedIn = false;
        }
    }
}