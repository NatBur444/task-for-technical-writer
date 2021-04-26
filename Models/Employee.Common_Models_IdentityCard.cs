using System;
using Newtonsoft.Json;

namespace Kontur.Employee
{
    public class IdentityCard
    {
        public IdentityCard(
            [JsonProperty(nameof(DocumentType))] string documentType = null,
            [JsonProperty(nameof(Series))] string series = null,
            [JsonProperty(nameof(Number))] string number = null,
            [JsonProperty(nameof(Issuer))] string issuer = null,
            [JsonProperty(nameof(IssuanceDate))] [JsonConverter(typeof(ShortDateConverter))] DateTime? issuanceDate = null,
            [JsonProperty(nameof(IssuerCode))] string issuerCode = null)
        {
            DocumentType = documentType;
            Series = series;
            Number = number;
            Issuer = issuer;
            IssuanceDate = issuanceDate;
            IssuerCode = issuerCode;
        }

        public string DocumentType { get; }

        public string Series { get; }

        public string Number { get; }

        public string Issuer { get; }

        [JsonConverter(typeof(ShortDateConverter))]
        public DateTime? IssuanceDate { get; }

        public string IssuerCode { get; }

        public override string ToString()
        {
            return $"{DocumentType}, {Series} {Number}, {IssuanceDate}, {Issuer}";
        }
    }
}