﻿namespace Portalum.Zvt.Repositories
{
    /// <summary>
    /// Interface IntermediateStatusRepository
    /// </summary>
    public interface IIntermediateStatusRepository
    {
        /// <summary>
        /// Get the status message for the given key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        (byte StatusCode, string StatusInformation) GetMessage(byte key);
    }
}
