// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class coopgameTarget : TargetRules
{
	public coopgameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "coopgame" ,"CoreUObject", "Engine", "InputCore", "AIModule", "GameplayTasks"  } );
	}
}
