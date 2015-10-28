// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Contact information for domain registration. If 'Domain Privacy'
    /// option is not selected then the contact information will be  be made
    /// publicly available through the Whois directories as per ICANN
    /// requirements.
    /// </summary>
    public partial class Contact
    {
        /// <summary>
        /// Initializes a new instance of the Contact class.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Initializes a new instance of the Contact class.
        /// </summary>
        public Contact(Address addressMailing = default(Address), string email = default(string), string fax = default(string), string jobTitle = default(string), string nameFirst = default(string), string nameLast = default(string), string nameMiddle = default(string), string organization = default(string), string phone = default(string))
        {
            AddressMailing = addressMailing;
            Email = email;
            Fax = fax;
            JobTitle = jobTitle;
            NameFirst = nameFirst;
            NameLast = nameLast;
            NameMiddle = nameMiddle;
            Organization = organization;
            Phone = phone;
        }

        /// <summary>
        /// Mailing address
        /// </summary>
        [JsonProperty(PropertyName = "addressMailing")]
        public Address AddressMailing { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Fax number
        /// </summary>
        [JsonProperty(PropertyName = "fax")]
        public string Fax { get; set; }

        /// <summary>
        /// Job title
        /// </summary>
        [JsonProperty(PropertyName = "jobTitle")]
        public string JobTitle { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        [JsonProperty(PropertyName = "nameFirst")]
        public string NameFirst { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [JsonProperty(PropertyName = "nameLast")]
        public string NameLast { get; set; }

        /// <summary>
        /// Middle name
        /// </summary>
        [JsonProperty(PropertyName = "nameMiddle")]
        public string NameMiddle { get; set; }

        /// <summary>
        /// Organization
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public string Organization { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

    }
}
