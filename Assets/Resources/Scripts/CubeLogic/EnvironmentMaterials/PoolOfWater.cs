using Assets.Resources.Scripts.CubeLogic.CubeStates;
using Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials;

public class PoolOfWater : Water
{
	public override void Visit(StandardState state)
	{
		//Медленное плавание на поверхности воды
	}

	public override void Visit(MetalState state)
	{
		// Кубик утонул
	}

	public override void Visit(LiquidState state)
	{
		// Обработать быстрое плавание кубика на поверхности воды
	}
}
