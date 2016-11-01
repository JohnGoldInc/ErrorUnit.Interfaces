using System;
using System.Collections.Generic;
using System.Web;

namespace ErrorUnit.Interfaces
{
    /// <summary>
    /// Abstract class for creating an IErrorPrecondition, please inherit from this.
    /// </summary>
    /// <seealso cref="ErrorUnit.Interfaces.IErrorPrecondition" />
    [Serializable]
    public abstract class aErrorPrecondition : IErrorPrecondition
    {

        /// <summary>
        /// Gets the error unit web call identifier.
        /// </summary>
        /// <value>
        /// The error unit web call identifier.
        /// </value>
        public Guid? ErrorUnitWebCallId { get { return (Guid?)HttpContext.Current?.Items["ErrorUnitWebCallId"]; } set { } }

        /// <summary>
        /// Gets the start time of the method.
        /// </summary>
        /// <value>
        /// The start.
        /// </value>
        public DateTime Start { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public abstract TypeNameAndObjectValue[] Arguments { get; set; }
        /// <summary>
        /// Gets the full type name of the class the method that failed is in.
        /// </summary>
        /// <value>
        /// The full type name of the class.
        /// </value>
        public abstract string InvocationClassName { get; set; }
        /// <summary>
        /// Gets the time the method completes successfully.
        /// </summary>
        /// <value>
        /// The time the method completes successfully.
        /// </value>
        public DateTime? End { get; set; }
        /// <summary>
        /// Gets the invocation class.
        /// </summary>
        /// <value>
        /// The invocation class.
        /// </value>
        public abstract TypeNameAndObjectValue InvocationClassValue { get; set; }
        /// <summary>
        /// Gets the name of the method.
        /// </summary>
        /// <value>
        /// The name of the method.
        /// </value>
        public abstract string MethodName { get; set; }
    }
}
