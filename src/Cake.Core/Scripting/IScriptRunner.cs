﻿using System.Collections.Generic;
using Cake.Core.IO;

namespace Cake.Core.Scripting
{
    /// <summary>
    /// Represents a script runner responsible for running scripts.
    /// </summary>
    public interface IScriptRunner
    {
        /// <summary>
        /// Runs the script using the specified script host.
        /// </summary>
        /// <param name="host">The script host.</param>
        /// <param name="script">The script.</param>
        /// <param name="arguments">The arguments.</param>
        void Run(IScriptHost host, FilePath script, IDictionary<string, string> arguments);
    }
}