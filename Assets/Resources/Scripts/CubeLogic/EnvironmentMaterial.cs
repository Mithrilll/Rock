using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class EnvironmentMaterial : MonoBehaviour
{
    public enum MaterialType
    {   
        None,
        Fire,
        Electricity,
        Wood,
        Water,
        Metal
    }


    public virtual void Interaction(int rigidObjectMaterial)
    {
    }



}
