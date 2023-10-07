using Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials;
using System;
using UnityEngine;

namespace Assets.Resources.Scripts.CubeLogic.CubeStates
{
	public class LiquidState : CubeState
	{
		public LiquidState(Sprite sprite) : base(sprite) { }

		public override void Accept(EnvironmentMaterials.Material material)
		{
			material.Visit(this);
		}
	}
}