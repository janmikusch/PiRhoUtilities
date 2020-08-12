using System.Collections.Generic;
using UnityEngine;

namespace PiRhoSoft.Utilities
{
    [AddComponentMenu("PiRho Utilities/TagSelector")]
    public class TagSelectorSample : MonoBehaviour
    {
        [TagSelector] [SerializeField] private string tag;

        [TagSelector] [SerializeField] private string[] tagArray;
        [TagSelector] [SerializeField] private List<string> tagList;
    }
}