﻿using Synapse.Config;
using System.ComponentModel;

namespace GamemodeManager
{
    public class PluginConfig : AbstractConfigSection
    {
        [Description("Custom Gamemode Path, leave empty for default")]
        public string CustomGamemodePath { get; set; } = string.Empty;
    }
}