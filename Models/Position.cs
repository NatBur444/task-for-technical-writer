using System;
using Newtonsoft.Json;

namespace Employee
{
    public class Position
    {
        public Position(
            [JsonProperty(nameof(Person))] Guid person,
            [JsonProperty(nameof(Organization))] Guid organization,
            [JsonProperty(nameof(Title))] string title = null)
        {
            Person = person;
            Organization = organization;
            Title = title;
        }

        public Guid Person { get; }

        public Guid Organization { get; }

        public string Title { get; }

        public override string ToString()
        {
            return $"O{Organization}<->P{Person}: {Title}";
        }
    }
}
