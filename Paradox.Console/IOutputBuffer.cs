﻿namespace Varus.Paradox.Console
{
    public interface IOutputBuffer
    {
        /// <summary>
        /// Appends a message to the buffer.
        /// </summary>
        /// <param name="message">Message to append.</param>
        void Append(string message);

        /// <summary>
        /// Clears all the information in the buffer.
        /// </summary>
        void Clear();
    }
}
