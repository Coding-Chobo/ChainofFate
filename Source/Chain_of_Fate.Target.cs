using UnrealBuildTool;
using System.Collections.Generic;

public class Chain_of_FateTarget : TargetRules
{
    public Chain_of_FateTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;

        DefaultBuildSettings = BuildSettingsVersion.V6;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_7;

        ExtraModuleNames.Add("Chain_of_Fate");
    }
}