using Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials;
using System;

namespace Assets.Resources.Scripts.CubeLogic.CubeStates
{
	public class FieryState : CubeState
	{
		public override void Accept(Material material)
		{
			material.Visit(this);
		}
	}
}
