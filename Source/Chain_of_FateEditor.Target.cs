using UnrealBuildTool;
using System.Collections.Generic;

public class Chain_of_FateEditorTarget : TargetRules
{
    public Chain_of_FateEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;

        DefaultBuildSettings = BuildSettingsVersion.V6;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_7;

        ExtraModuleNames.Add("Chain_of_Fate");
    }
}