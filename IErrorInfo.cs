using System;

namespace ErrorUnit.Interfaces
{
    /// <summary>
    /// Error Info
    /// </summary>
    public interface IErrorInfo
    {
        /// <summary>
        /// Gets the error unit error identifier.
        /// </summary>
        /// <value>
        /// The error unit error identifier.
        /// </value>
        Guid ErrorUnitErrorId { get; }
        /// <summary>
        /// Gets or sets the error unit web call identifier.
        /// </summary>
        /// <value>
        /// The error unit web call identifier.
        /// </value>
        Guid? ErrorUnitWebCallId { get; set; }
        /// <summary>
        /// Gets or sets the exception message.
        /// </summary>
        /// <value>
        /// The exception message.
        /// </value>
        string ExceptionMessage { get; set; }
        /// <summary>
        /// Gets or sets the type of the exception.
        /// </summary>
        /// <value>
        /// The type of the exception.
        /// </value>
        string ExceptionType { get; set; }
        /// <summary>
        /// Gets or sets the name of the host.
        /// </summary>
        /// <value>
        /// The name of the host.
        /// </value>
        string HostName { get; set; }
        /// <summary>
        /// Gets or sets the inner error information.
        /// </summary>
        /// <value>
        /// The inner error information.
        /// </value>
        IErrorInfo InnerErrorInfo { get; set; }
        /// <summary>
        /// Gets or sets the stack trace.
        /// </summary>
        /// <value>
        /// The stack trace.
        /// </value>
        string StackTrace { get; set; }
        /// <summary>
        /// Gets or sets the error thrown date time.
        /// </summary>
        /// <value>
        /// The error thrown.
        /// </value>
        DateTime ErrorThrown { get; set; }
        /// <summary>
        /// Gets or sets the name of the machine.
        /// </summary>
        /// <value>
        /// The name of the machine.
        /// </value>
        string MachineName { get; set; }
    }
}