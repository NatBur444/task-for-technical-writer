using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Employee
{
    public class Person : PersonProps 
    {
        public Person(
            [JsonProperty(nameof(Guid))] Guid guid,
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
            : base(fullName, innFl, gender, citizenship, birthDate, birthPlace, phone, email, registrationAddress, identityCard, foreignAddress)
        {
            Guid = guid;
        }

        public Guid Guid { get; }       

        public override string ToString()
        {
            return $"{Guid}: {base.ToString()}";
        }
    }
}
