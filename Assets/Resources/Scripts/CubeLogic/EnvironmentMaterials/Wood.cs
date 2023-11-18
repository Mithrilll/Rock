using Assets.Resources.Scripts.CubeLogic.CubeStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials
{
	public class Wood : Material
	{

		public override void Visit(StandardState state)
		{
            GetComponent<BoxCollider2D>().isTrigger = false;
        }

		public override void Visit(FieryState state)
		{
            Destroy(this.gameObject, 0.1f);
        }

		public override void Visit(MetalState state)
		{
            Destroy(this.gameObject, 0.1f);
        }

		public override void Visit(LiquidState state)
		{
            GetComponent<BoxCollider2D>().isTrigger = false;
        }
	}
}
