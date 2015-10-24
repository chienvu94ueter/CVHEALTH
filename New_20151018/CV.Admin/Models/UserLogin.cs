using System;

namespace CV.Admin.Models
{
    [Serializable]
    public class UserLogin
    {
        public string UserName { get; set; }
        public long UserId { get; set; }
    }
}