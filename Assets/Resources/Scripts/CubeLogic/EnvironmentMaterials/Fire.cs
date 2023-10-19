using Assets.Resources.Scripts.CubeLogic.CubeStates;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials
{
	public class Fire : Material
	{
        public static event Action OnFireVisit;

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
			OnFireVisit?.Invoke();
		}


        public override void Visit(LiquidState state)
		{
			Destroy(this.gameObject, 1f);
		}
	}
}
