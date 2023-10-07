using UnityEngine;

public abstract class CubeState
{
    /// <summary>
    /// Sprite of current state
    /// </summary>
    public Sprite cubeSprite { get; }

    public abstract void Accept(Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials.Material material);

    public CubeState(Sprite cubeSprite)
	{
		this.cubeSprite = cubeSprite;
	}
}
