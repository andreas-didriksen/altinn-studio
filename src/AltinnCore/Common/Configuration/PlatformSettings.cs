using System;
using System.Collections.Generic;
using System.Text;

namespace AltinnCore.Common.Configuration
{
    /// <summary>
    /// Configuratin for platform settings
    /// </summary>
    public class PlatformSettings
    {
        /// <summary>
        /// Gets or sets the url for the API storage endpoint
        /// </summary>
        public string ApiStorageEndpoint { get; set; }

        /// <summary>
        /// Gets the url for the API storage endpoint by looking into environment variables
        /// </summary>
        public string GetApiStorageEndpoint
        {
            get
            {
                return Environment.GetEnvironmentVariable("PlatformSettings__ApiStorageEndpoint") ?? ApiStorageEndpoint;
            }
        }

        /// <summary>
        /// Gets or sets the url host for API storage
        /// </summary>
        public string ApiStorageEndpointHost { get; set; }

        /// <summary>
        /// Gets the url host for API storage by looking into environment variables
        /// </summary>
        public string GetApiStorageEndpointHost
        {
            get
            {
                return Environment.GetEnvironmentVariable("PlatformSettings__ApiStorageEndpointHost") ?? ApiStorageEndpointHost;
            }
        }

        /// <summary>
        /// Gets or sets the url for the API register endpoint
        /// </summary>
        public string ApiRegisterEndpoint { get; set; }

        /// <summary>
        /// Gets the url for the API register endpoint by looking into environment variables
        /// </summary>
        public string GetApiRegisterEndpoint
        {
            get
            {
                return Environment.GetEnvironmentVariable("PlatformSettings__ApiRegisterEndpoint") ?? ApiRegisterEndpoint;
            }
        }

        /// <summary>
        /// Gets or sets the url host for API register
        /// </summary>
        public string ApiRegisterEndpointHost { get; set; }

        /// <summary>
        /// Gets the url host for API register by looking into environment variables
        /// </summary>
        public string GetApiRegisterEndpointHost
        {
            get
            {
                return Environment.GetEnvironmentVariable("PlatformSettings__ApiRegisterEndpointHost") ?? ApiRegisterEndpointHost;
            }
        }

        /// <summary>
        /// Gets or sets the url for the API profile endpoint
        /// </summary>
        public string ApiProfileEndpoint { get; set; }

        /// <summary>
        /// Gets the url for the API profile endpoint by looking into environment variables
        /// </summary>
        public string GetApiProfileEndpoint
        {
            get
            {
                return Environment.GetEnvironmentVariable("PlatformSettings__ApiProfileEndpoint") ?? ApiProfileEndpoint;
            }
        }

        /// <summary>
        /// Gets or sets the url host for API profile
        /// </summary>
        public string ApiProfileEndpointHost { get; set; }

        /// <summary>
        /// Gets the url host for API profile by looking into environment variables
        /// </summary>
        public string GetApiProfileEndpointHost
        {
            get
            {
                return Environment.GetEnvironmentVariable("PlatformSettings__ApiProfileEndpointHost") ?? ApiProfileEndpointHost;
            }
        }
    }
}