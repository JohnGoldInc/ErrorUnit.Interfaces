using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorUnit.Interfaces
{
    /// <summary>
    /// Type name and object value
    /// </summary>
    public class TypeNameAndObjectValue
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeNameAndObjectValue"/> class.
        /// </summary>
        /// <param name="typeName">Full Name of the type.</param>
        /// <param name="value">The object value.</param>
        public TypeNameAndObjectValue(string typeName, object value)
        {
            TypeName = typeName;
            Value = value;
        }

        /// <summary>
        /// Gets or sets the full name of the type.
        /// </summary>
        /// <value>
        /// The full name of the type.
        /// </value>
        public string TypeName { get; set; }
        /// <summary>
        /// Gets or sets the object value.
        /// </summary>
        /// <value>
        /// The object value.
        /// </value>
        public object Value { get; set; }
    }
}
