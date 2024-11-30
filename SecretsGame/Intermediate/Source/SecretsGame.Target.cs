using UnrealBuildTool;

public class SecretsGameTarget : TargetRules
{
	public SecretsGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SecretsGame");
	}
}
