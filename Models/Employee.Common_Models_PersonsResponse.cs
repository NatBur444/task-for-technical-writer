using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kontur.Employee
{
    public class PersonsResponse
    {
        public PersonsResponse([JsonProperty(nameof(Persons))] IReadOnlyList<Person> persons, [JsonProperty(nameof(TotalCount))] int totalCount)
        {
            Persons = persons;
            TotalCount = totalCount;
        }

        public int TotalCount { get; }

        [DataMember(EmitDefaultValue = false)]
        public IReadOnlyList<Person> Persons { get; }

        public override string ToString()
        {
            return $"{Persons.Count} persons. Total {TotalCount} persons.";
        }
    }
}
