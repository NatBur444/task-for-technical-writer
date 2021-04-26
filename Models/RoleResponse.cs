using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Employee
{
    public class RoleResponse
    {
        public RoleResponse([JsonProperty(nameof(Person))] Person person, [JsonProperty(nameof(Position))] Position position)
        {
            Person = person;
            Position = position;
        }

        [DataMember(EmitDefaultValue = false)]
        public Person Person { get; }

        [DataMember(EmitDefaultValue = false)]
        public Position Position { get; }

        public override string ToString()
        {
            return $"{Person}/{Position}";
        }
    }
}
