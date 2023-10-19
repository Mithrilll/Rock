using Assets.Resources.Scripts.CubeLogic.CubeStates;
using Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials;
using System;
using UnityEngine;

public class PoolOfWater : Water
{
    public static event Action OnWaterVisitStandartState;
    public static event Action OnWaterVisitLiquidState;

    public override void Visit(StandardState state)
	{
        //GetComponent<BoxCollider2D>().isTrigger = false;
        OnWaterVisitStandartState?.Invoke();
	}

	public override void Visit(MetalState state)
	{
        Transform Child = transform.Find("Collider");
        if (Child != null) { Child.gameObject.SetActive(false); }
        OnWaterVisitStandartState?.Invoke();
        // Кубик утонул
    }

    public override void Visit(LiquidState state)
	{
		OnWaterVisitLiquidState?.Invoke();
		// Обработать быстрое плавание кубика на поверхности воды
	}
}
