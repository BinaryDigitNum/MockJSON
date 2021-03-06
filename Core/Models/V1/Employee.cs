namespace Core.Models
{
    // Generated by https://quicktype.io

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Employee
    {
        [JsonProperty("employee_id")]
        public string? EmployeeId { get; set; }

        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("gender")]
        public string? Gender { get; set; }

        [JsonProperty("education")]
        public Education? Education { get; set; }

        [JsonProperty("job")]
        public Job? Job { get; set; }

        [JsonProperty("previous_jobs")]
        public PreviousJob[]? PreviousJobs { get; set; }

        [JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; }
    }

    public partial class Education
    {
        [JsonProperty("university")]
        public string? University { get; set; }
    }

    public partial class Job
    {
        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("department")]
        public string? Department { get; set; }

        [JsonProperty("company")]
        public string? Company { get; set; }
    }

    public partial class PreviousJob
    {
        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("company")]
        public string? Company { get; set; }
    }

    public partial class Employee
    {
        public static Employee? FromJson(string json) => JsonConvert.DeserializeObject<Employee>(json, Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Employee self) => JsonConvert.SerializeObject(self, Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}


