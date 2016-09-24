using ErrorUnit.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ErrorUnit.Interfaces
{
    /// <summary>
    /// Error preconditions; Used to record the conditions that lead up to an error.
    /// </summary>
    public interface IErrorPrecondition
    {
        /// <summary>
        /// Gets the full type name of the class the method that failed is in.
        /// </summary>
        /// <value>
        /// The full type name of the class.
        /// </value>
        string InvocationClassName { get; set; }
        /// <summary>
        /// Gets the invocation class.
        /// </summary>
        /// <value>
        /// The invocation class.
        /// </value>
        TypeNameAndObjectValue InvocationClassValue { get; set; }
        /// <summary>
        /// Gets the name of the method.
        /// </summary>
        /// <value>
        /// The name of the method.
        /// </value>
        string MethodName { get; set; }
        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        TypeNameAndObjectValue[] Arguments { get; set; }
        /// <summary>
        /// Gets the start time of the method.
        /// </summary>
        /// <value>
        /// The start.
        /// </value>
        DateTime Start { get; set; }
        /// <summary>
        /// Gets the time the method completes successfully.
        /// </summary>
        /// <value>
        /// The time the method completes successfully.
        /// </value>
        DateTime? End { get; set; }
        /// <summary>
        /// Gets the error unit web call identifier.
        /// </summary>
        /// <value>
        /// The error unit web call identifier.
        /// </value>
        Guid? ErrorUnitWebCallId { get; set; }
    }
}
