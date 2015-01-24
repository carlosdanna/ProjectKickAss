using UnityEngine;
using System.Collections;

public class SetTrailSortingLayer : MonoBehaviour
{
    public string sortingLayerName = "Foreground";		// The name of the sorting layer the particles should be set to.


    void Start()
    {
        // Set the sorting layer of the particle system.
        renderer.sortingLayerName = sortingLayerName;
    }
}
