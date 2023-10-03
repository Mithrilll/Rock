using Assets.Resources.Scripts.CubeLogic.CubeStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials
{
	public class Water : Material
	{
		public override void Visit(StandardState state)
		{
			// Обработать медленное плавание кубика в воде
			throw new NotImplementedException();
		}

		public override void Visit(FieryState state)
		{
			// Сообщить о том, что кубик потух
		}

		public override void Visit(MetalState state)
		{
			// Кубик утонул
			throw new NotImplementedException();
		}

		public override void Visit(LiquidState state)
		{
			// Обработать быстрое плавание кубика в воде
			throw new NotImplementedException();
		}
	}
}
