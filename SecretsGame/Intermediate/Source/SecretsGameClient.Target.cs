using UnrealBuildTool;

public class SecretsGameClientTarget : TargetRules
{
	public SecretsGameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SecretsGame");
	}
}
