using Assets.Resources.Scripts.CubeLogic.CubeStates;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials
{
    public class Spikes : Material
    {

        public override void Visit(StandardState state)
        {
            KillPlayer();
        }

        public override void Visit(FieryState state)
        {
            KillPlayer();
        }

        public override void Visit(MetalState state)
        {
            KillPlayer();
        }


        public override void Visit(LiquidState state)
        {
            KillPlayer();
        }
    }
}
