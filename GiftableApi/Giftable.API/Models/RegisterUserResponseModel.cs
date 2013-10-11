﻿using System.Runtime.Serialization;

namespace Giftable.API.Models
{
    [DataContract]
    public class RegisterUserResponseModel
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }
    }
}