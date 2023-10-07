using UnityEngine;

namespace Assets.Resources.Scripts.CubeLogic.CubeStates
{
	public class StandardState : CubeState
	{
		public StandardState(Sprite sprite) : base(sprite) { }

		public override void Accept(EnvironmentMaterials.Material material) { }
	}
}
