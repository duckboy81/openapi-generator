// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// MixedPropertiesAndAdditionalPropertiesClass
    /// </summary>
    public partial class MixedPropertiesAndAdditionalPropertiesClass : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MixedPropertiesAndAdditionalPropertiesClass" /> class.
        /// </summary>
        /// <param name="dateTime">dateTime</param>
        /// <param name="map">map</param>
        /// <param name="uuid">uuid</param>
        /// <param name="uuidWithPattern">uuidWithPattern</param>
        [JsonConstructor]
        public MixedPropertiesAndAdditionalPropertiesClass(DateTime dateTime, Dictionary<string, Animal> map, Guid uuid, Guid uuidWithPattern)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (uuidWithPattern == null)
                throw new ArgumentNullException("uuidWithPattern is a required property for MixedPropertiesAndAdditionalPropertiesClass and cannot be null.");

            if (uuid == null)
                throw new ArgumentNullException("uuid is a required property for MixedPropertiesAndAdditionalPropertiesClass and cannot be null.");

            if (dateTime == null)
                throw new ArgumentNullException("dateTime is a required property for MixedPropertiesAndAdditionalPropertiesClass and cannot be null.");

            if (map == null)
                throw new ArgumentNullException("map is a required property for MixedPropertiesAndAdditionalPropertiesClass and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            DateTime = dateTime;
            Map = map;
            Uuid = uuid;
            UuidWithPattern = uuidWithPattern;
        }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [JsonPropertyName("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or Sets Map
        /// </summary>
        [JsonPropertyName("map")]
        public Dictionary<string, Animal> Map { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Gets or Sets UuidWithPattern
        /// </summary>
        [JsonPropertyName("uuid_with_pattern")]
        public Guid UuidWithPattern { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MixedPropertiesAndAdditionalPropertiesClass {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Map: ").Append(Map).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  UuidWithPattern: ").Append(UuidWithPattern).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // UuidWithPattern (Guid) pattern
            Regex regexUuidWithPattern = new Regex(@"[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}", RegexOptions.CultureInvariant);
            if (false == regexUuidWithPattern.Match(this.UuidWithPattern).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UuidWithPattern, must match a pattern of " + regexUuidWithPattern, new [] { "UuidWithPattern" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type MixedPropertiesAndAdditionalPropertiesClass
    /// </summary>
    public class MixedPropertiesAndAdditionalPropertiesClassJsonConverter : JsonConverter<MixedPropertiesAndAdditionalPropertiesClass>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MixedPropertiesAndAdditionalPropertiesClass Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            DateTime dateTime = default;
            Dictionary<string, Animal> map = default;
            Guid uuid = default;
            Guid uuidWithPattern = default;

            while (reader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && reader.TokenType == JsonTokenType.EndArray && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName && currentDepth == reader.CurrentDepth - 1)
                {
                    string? propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "dateTime":
                            dateTime = JsonSerializer.Deserialize<DateTime>(ref reader, options);
                            break;
                        case "map":
                            map = JsonSerializer.Deserialize<Dictionary<string, Animal>>(ref reader, options);
                            break;
                        case "uuid":
                            uuid = reader.GetGuid();
                            break;
                        case "uuid_with_pattern":
                            uuidWithPattern = reader.GetGuid();
                            break;
                        default:
                            break;
                    }
                }
            }

            return new MixedPropertiesAndAdditionalPropertiesClass(dateTime, map, uuid, uuidWithPattern);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mixedPropertiesAndAdditionalPropertiesClass"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MixedPropertiesAndAdditionalPropertiesClass mixedPropertiesAndAdditionalPropertiesClass, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("dateTime");
            JsonSerializer.Serialize(writer, mixedPropertiesAndAdditionalPropertiesClass.DateTime, options);
            writer.WritePropertyName("map");
            JsonSerializer.Serialize(writer, mixedPropertiesAndAdditionalPropertiesClass.Map, options);
            writer.WriteString("uuid", mixedPropertiesAndAdditionalPropertiesClass.Uuid);
            writer.WriteString("uuid_with_pattern", mixedPropertiesAndAdditionalPropertiesClass.UuidWithPattern);

            writer.WriteEndObject();
        }
    }
}
