using Assets.Resources.Scripts.CubeLogic.CubeStates;
using System;
using System.Diagnostics;

namespace Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials
{
	public class Water : Material
	{

        public override void Visit(StandardState state)
		{
			//Do nothing
		}

		public override void Visit(FieryState state)
		{
			KillPlayer();			
		}

		public override void Visit(MetalState state)
		{
			// Кубик утонул
			// Do nothing
		}

		public override void Visit(LiquidState state)
		{
			// Обработать быстрое плавание кубика в воде
			// Do nothing
		}
	}
}
