using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManufactoryBehaviour : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("SpaceBanana").SetActive(false);
        GameObject.Find("SplineTable").SetActive(false);
        GameObject.Find("VideoManufactory").GetComponent<Renderer>().enabled = true;
    }
}
