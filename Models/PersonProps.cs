using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Employee
{
    public class PersonProps
    {
        public PersonProps(
            [JsonProperty(nameof(FullName))] FullName fullName, 
            [JsonProperty(nameof(InnFl))] string innFl = null,
            [JsonProperty(nameof(Gender))] [JsonConverter(typeof(StringEnumConverter))] Gender? gender = null,
            [JsonProperty(nameof(Citizenship))] string citizenship = null,
            [JsonProperty(nameof(BirthDate))] [JsonConverter(typeof(ShortDateConverter))] DateTime? birthDate = null,
            [JsonProperty(nameof(BirthPlace))] string birthPlace = null,
            [JsonProperty(nameof(Phone))] string phone = null,
            [JsonProperty(nameof(Email))] string email = null,
            [JsonProperty(nameof(RegistrationAddress))] ExtendedAddress registrationAddress = null,
            [JsonProperty(nameof(IdentityCard))] IdentityCard identityCard = null,
            [JsonProperty(nameof(ForeignAddress))] string foreignAddress = null)
        {
            if (fullName == null)
                throw new ArgumentNullException(nameof(fullName));

            FullName = fullName;
            InnFl = innFl;
            BirthDate = birthDate;
            Gender = gender;
            Citizenship = citizenship;
            BirthPlace = birthPlace;
            Phone = phone;
            Email = email;
            RegistrationAddress = registrationAddress;
            IdentityCard = identityCard;
            ForeignAddress = foreignAddress;
        }

        [DataMember(EmitDefaultValue = false)]
        public FullName FullName { get; }
        
        public string InnFl { get; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Gender? Gender { get; }

        public string Citizenship { get; }

        [JsonConverter(typeof(ShortDateConverter))]
        public DateTime? BirthDate { get; }
        
        public string BirthPlace { get; }

        public string Phone { get; }

        public string Email { get; }
   
        public ExtendedAddress RegistrationAddress { get; }
        
        public IdentityCard IdentityCard { get; }

        public string ForeignAddress { get; }

    }
}
