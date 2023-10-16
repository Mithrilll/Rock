using Assets.Resources.Scripts.CubeLogic.CubeStates;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials
{
	public class Fire : Material
	{
		public override void Visit(StandardState state)
		{
			KillPlayer();
		}

		public override void Visit(FieryState state)
		{
			Debug.Log("Как же мне всё равно");
		}

		public override void Visit(MetalState state)
		{
			throw new NotImplementedException();
		}

		public override void Visit(LiquidState state)
		{
			Destroy(this.gameObject, 1f);
		}
	}
}
