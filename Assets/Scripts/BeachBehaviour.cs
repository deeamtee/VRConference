using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("SpaceBanana").SetActive(false);
        GameObject.Find("SplineTable").SetActive(false);
        GameObject.Find("VideoBeach").GetComponent<Renderer>().enabled = true;
    }
}
