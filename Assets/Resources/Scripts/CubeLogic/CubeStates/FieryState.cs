using UnityEngine;

namespace Assets.Resources.Scripts.CubeLogic.CubeStates
{
	public class FieryState : CubeState
	{
		public FieryState(Sprite sprite) : base(sprite) { }

		public override void Accept(EnvironmentMaterials.Material material)
		{
			material.Visit(this);
		}
	}
}
