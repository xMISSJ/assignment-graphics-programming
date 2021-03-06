﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class ShapeSettings : ScriptableObject
{

	public float planetRadius = 1;
	public NoiseLayer[] noiseLayers;

	[System.Serializable]
	public class NoiseLayer
	{
		// Toggle the visibility of a single noise layer.
		public bool enabled = true;
		// Whether or not the first layer should be used as a mask.
		public bool useFirstLayerAsMask;
		public NoiseSettings noiseSettings;
	}
}
