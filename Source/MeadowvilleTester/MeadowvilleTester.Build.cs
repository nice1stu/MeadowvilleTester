// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MeadowvilleTester : ModuleRules
{
	public MeadowvilleTester(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"NavigationSystem",
			"AIModule",
			"Niagara",
			"EnhancedInput"
		});
    }
}
