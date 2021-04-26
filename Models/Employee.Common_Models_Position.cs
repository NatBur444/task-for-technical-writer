using System;
using Newtonsoft.Json;

namespace Kontur.Employee
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

        public override int GetHashCode()
        {
            return Person.GetHashCode() * Organization.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            var other = obj as Position;
            if (other == null)
                return false;

            return Person == other.Person
                   && Organization == other.Organization
                   && Title == other.Title;
        }
    }
}
