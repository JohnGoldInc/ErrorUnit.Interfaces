using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorUnit.Interfaces
{
    /// <summary>
    /// IErrorUnitCentral Interface
    /// </summary>
    public interface IErrorUnitCentral : IInjector, ILogger, IJsonSerializer
    {
        /// <summary>
        /// Sets the injector.
        /// </summary>
        /// <value>
        /// The injector.
        /// </value>
        IInjector Injector { set; }
        /// <summary>
        /// Sets the json serializer.
        /// </summary>
        /// <value>
        /// The json serializer.
        /// </value>
        IJsonSerializer JsonSerializer {  set; }
        /// <summary>
        /// Sets the logger.
        /// </summary>
        /// <value>
        /// The logger.
        /// </value>
        ILogger Logger { set; }

        /// <summary>
        /// Adds to the Current stack.
        /// </summary>
        /// <param name="errorPrecondition">The error precondition.</param>
        /// <returns>guid id on the stack</returns>
        Guid CurrentStack_Add(aErrorPrecondition errorPrecondition);

        /// <summary>
        /// Cleans up Current stack; removing methods that have ended.
        /// </summary>
        /// <param name="end">The end.</param>
        void CleanUp(DateTime end);

        /// <summary>
        /// Ends a web call on Current Stack.
        /// </summary>
        void CurrentStack_EndWebCall();


        /// <summary>
        /// Throws the error stack.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns>JSON serialized error stack</returns>
        string ThrowErrorStack(Exception ex);
    }
}
