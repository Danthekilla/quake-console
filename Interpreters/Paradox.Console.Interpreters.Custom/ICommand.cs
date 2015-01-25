﻿namespace Varus.Paradox.Console.Interpreters.Custom
{
    /// <summary>
    /// Contract for a user created command which can be registered with <see cref="CustomInterpreter"/>.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="args">Provided command arguments.</param>
        /// <returns>Result of the execution.</returns>
        CommandResult Execute(string[] args);
    }
}
