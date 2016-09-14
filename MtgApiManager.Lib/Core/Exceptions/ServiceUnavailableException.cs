﻿// <copyright file="ServiceUnavailableException.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace MtgApiManager.Lib.Core.Exceptions
{
    using System.Runtime.Serialization;

    /// <summary>
    /// An exception representing that the service is unavailable.
    /// </summary>
    [DataContract]
    public class ServiceUnavailableException : MtgException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUnavailableException"/> class.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public ServiceUnavailableException(string message)
            : base(message)
        {
        }
    }
}