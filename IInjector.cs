namespace ErrorUnit.Interfaces
{
    /// <summary>
    /// Standard Interface for ErrorUnit to work with IoC Dependency Injector. The Interceptor is attached to the IOC container; You will have to add the appropriate DLL and using statement for the <see cref="ErrorUnit.Interfaces.IInjector"/> you are using ( it will be named like ErrorUnit.Injector_... followed by your IOC library name).
    /// <example>
    /// Add this where you define your IOC container:  
    /// <code>
    /// ErrorUnitCentral._Injector = new ErrorUnitInjector();
    /// ErrorUnitCentral._LinkInjector(container);
    /// </code>
    /// </example>
    /// </summary>
    public interface IInjector
    {
        /// <summary>
        /// Links the injector.
        /// </summary>
        /// <typeparam name="T">The IoC container type.</typeparam>
        /// <param name="ioc">The IoC container.</param>
        /// <param name="errorUnitCentral">The ErrorUnitCentral.Instance.</param>
        /// <returns>The IoC container with ErrorUnit interception enabled.</returns>
        T LinkInjector<T>(T ioc, IErrorUnitCentral errorUnitCentral);
    }
}
