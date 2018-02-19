using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainBehaviour : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("SpaceBanana").SetActive(false);
        GameObject.Find("SplineTable").SetActive(false);
        GameObject.Find("VideoMountain").GetComponent<Renderer>().enabled = true;
    }
}
