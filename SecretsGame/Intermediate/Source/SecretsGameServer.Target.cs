using UnrealBuildTool;

public class SecretsGameServerTarget : TargetRules
{
	public SecretsGameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SecretsGame");
	}
}
