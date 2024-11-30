using UnrealBuildTool;

public class SecretsGameEditorTarget : TargetRules
{
	public SecretsGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SecretsGame");
	}
}
