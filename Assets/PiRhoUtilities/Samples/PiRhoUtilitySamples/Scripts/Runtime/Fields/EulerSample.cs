﻿using UnityEngine;

namespace PiRhoSoft.Utilities
{
	[AddComponentMenu("PiRho Utilities/Euler")]
	public class EulerSample : MonoBehaviour
	{
		[SerializeField] [Euler] private Quaternion rotation;
	}
}