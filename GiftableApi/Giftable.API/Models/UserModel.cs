using System.Runtime.Serialization;

namespace Giftable.API.Models
{
    [DataContract]
    public class UserModel
    {
        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "authCode")]
        public string AuthCode { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }
    }
}