using UnrealBuildTool;

public class OBP : ModuleRules {
    public OBP(TargetInfo Target) {
		PublicDependencyModuleNames.AddRange(
			new string[] {
				"Core",
				"Engine",
				"CoreUObject"
            }
		);
	}
}