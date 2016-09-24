using Newtonsoft.Json;
using System;

namespace ErrorUnit.Interfaces
{
    /// <summary>
    /// Interface for ErrorUnit to uniformly act on JSON Serializers
    /// </summary>
    public interface IJsonSerializer
    {
        /// <summary>
        /// Serializes the specified object.
        /// </summary>
        /// <typeparam name="T">The type to serialize</typeparam>
        /// <param name="obj">The object.</param>
        /// <returns>serialized JSON string</returns>
        string Serialize<T>(T obj);
        /// <summary>
        /// Deserializes the specified json.
        /// </summary>
        /// <typeparam name="T">The type to deserialize too.</typeparam>
        /// <param name="json">The json.</param>
        /// <returns>the deserialized object</returns>
        T Deserialize<T>(string json);

        /// <summary>
        /// Gets or sets the serializer settings.
        /// </summary>
        /// <value>
        /// The serializer settings.
        /// </value>
        JsonSerializerSettings serializerSettings { get; set; }
    }
}
