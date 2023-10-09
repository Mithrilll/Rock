using System;
using UnityEngine;

namespace Assets.Resources.Scripts.CubeLogic.CubeStates
{
	public class MetalState : CubeState
	{
		public MetalState(Sprite sprite) : base(sprite) { }

		public override void Accept(EnvironmentMaterials.Material material)
		{
			material.Visit(this);
		}
	}
}
