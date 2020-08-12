using System.Collections.Generic;
using UnityEngine;

namespace PiRhoSoft.Utilities
{
    [AddComponentMenu("PiRho Utilities/SceneSelector")]
    public class SceneSelectorSample : MonoBehaviour
    {
        [SceneSelector] [SerializeField] private string scene;
        [SceneSelector] [SerializeField] private string[] sceneArray;
    }
}