/*
 * FeatureServiceApi
 *
 * This describes the API clients use for accessing features
 *
 * The version of the OpenAPI document: 1.1.2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = IO.FeatureHub.SSE.Client.OpenAPIDateConverter;

namespace IO.FeatureHub.SSE.Model
{
    /// <summary>
    /// Defines StrategyAttributeDeviceName
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StrategyAttributeDeviceName
    {
        /// <summary>
        /// Enum Browser for value: browser
        /// </summary>
        [EnumMember(Value = "browser")]
        Browser = 1,

        /// <summary>
        /// Enum Mobile for value: mobile
        /// </summary>
        [EnumMember(Value = "mobile")]
        Mobile = 2,

        /// <summary>
        /// Enum Desktop for value: desktop
        /// </summary>
        [EnumMember(Value = "desktop")]
        Desktop = 3,

        /// <summary>
        /// Enum Server for value: server
        /// </summary>
        [EnumMember(Value = "server")]
        Server = 4,

        /// <summary>
        /// Enum Watch for value: watch
        /// </summary>
        [EnumMember(Value = "watch")]
        Watch = 5,

        /// <summary>
        /// Enum Embedded for value: embedded
        /// </summary>
        [EnumMember(Value = "embedded")]
        Embedded = 6

    }

}
