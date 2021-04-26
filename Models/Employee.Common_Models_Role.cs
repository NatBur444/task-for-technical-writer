using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Kontur.Employee
{
    public class Role
    {
        public Role(
            [JsonProperty(nameof(Organization))] Guid organization,
            [JsonProperty(nameof(Type))] [JsonConverter(typeof(StringEnumConverter))] RoleType type,
            [JsonProperty(nameof(Person))] Guid person,
            [JsonProperty(nameof(PositionOrganization))] Guid positionOrganization)
        {
            Person = person;
            PositionOrganization = positionOrganization;
            Organization = organization;
            Type = type;
        }

        public Guid Organization { get; }

        [JsonConverter(typeof(StringEnumConverter))]
        public RoleType Type { get; }

        public Guid Person { get; }

        public Guid PositionOrganization { get; }

        public override string ToString()
        {
            return $"{Type}({Organization}): {Person}({PositionOrganization})";
        }
    }
}
