using Assets.Resources.Scripts.CubeLogic.CubeStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials
{
	public class Metal : Material
	{
		public override void Visit(StandardState state)
		{
            GetComponent<BoxCollider2D>().isTrigger = false;
        }

		public override void Visit(FieryState state)
		{
            GetComponent<BoxCollider2D>().isTrigger = false;
        }

		public override void Visit(MetalState state)
		{
            GetComponent<BoxCollider2D>().isTrigger = false;
        }

		public override void Visit(LiquidState state)
		{
            GetComponent<BoxCollider2D>().isTrigger = false;
        }
	}
}
