﻿using Lib.Utils.CommandLineParser.Parser;

namespace Lib.Utils.CommandLineParser.Definitions
{
    public abstract class CommonParametersBaseCommand : CommandLineCommand
    {
        public CommandLineArgumentSwitch Verbose { get; } = new CommandLineArgumentSwitch(
            "enable spamming console output",
            new[] {"--verbose"});

        public CommandLineArgumentSwitch NoBuildCache { get; } =
            new CommandLineArgumentSwitch("forbid using Build Cache", new[] {"--nocache"});
    }
}
