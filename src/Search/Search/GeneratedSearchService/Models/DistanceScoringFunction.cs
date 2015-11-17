// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Defines a function that boosts scores based on distance from a
    /// geographic location.
    /// </summary>
    [JsonObject("distance")]
    public partial class DistanceScoringFunction : ScoringFunction
    {
        /// <summary>
        /// Initializes a new instance of the DistanceScoringFunction class.
        /// </summary>
        public DistanceScoringFunction() { }

        /// <summary>
        /// Initializes a new instance of the DistanceScoringFunction class.
        /// </summary>
        public DistanceScoringFunction(DistanceScoringParameters distance)
        {
            Distance = distance;
        }

        /// <summary>
        /// Gets parameter values for the distance scoring function.
        /// </summary>
        [JsonProperty(PropertyName = "distance")]
        public DistanceScoringParameters Distance { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (Distance == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Distance");
            }
            if (this.Distance != null)
            {
                this.Distance.Validate();
            }
        }
    }
}
