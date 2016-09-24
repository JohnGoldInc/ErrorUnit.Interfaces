using System;
using System.Collections.Generic;

namespace ErrorUnit.Interfaces
{
    /// <summary>
    /// Standard Interface for ErrorUnit to work with your Error Logger; add <c>ErrorUnitCentral._Logger = new ErrorUnitLogger();</c> where your application start code is.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs the specified testable error json.
        /// </summary>
        /// <param name="testableErrorJson">The testable error json.</param>
        /// <param name="exception">The exception.</param>
        /// <returns>testableErrorJson</returns>
        string Log(string testableErrorJson, Exception exception);
        /// <summary>
        /// Logs the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        void Log(Exception ex);
        /// <summary>
        /// Gets the error unit json.
        /// </summary>
        /// <param name="afterdate">The after-date.</param>
        /// <returns>ErrorUnit serialized errors after date.</returns>
        IEnumerable<string> GetErrorUnitJson(DateTime afterdate);
    }
}
