using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsBehaviour : MonoBehaviour {
    private GameObject table = null;
    private GameObject menu = null;
    private GameObject man1 = null;
    private GameObject man2 = null;
    private GameObject man3 = null;
    private GameObject zavod = null;


    public void Start()
    {
        menu = GameObject.Find("Main Menu");
        table = GameObject.Find("SplineTable");
        man1 = GameObject.Find("Man1");
        man2 = GameObject.Find("Man2");
        man3 = GameObject.Find("Man3");
        zavod = GameObject.Find("VideoZavod");

        table.GetComponent<Renderer>().enabled = false;
        man1.GetComponent<Renderer>().enabled = false;
        man2.GetComponent<Renderer>().enabled = false;
        man3.GetComponent<Renderer>().enabled = false;
        zavod.GetComponent<Renderer>().enabled = false;
    }

    public void EnvOnClick()
    {
        // show available environments in slider table
        // enable slider table with enviroments content
        table.GetComponent<MeshRenderer>().enabled = true;
        man1.GetComponent<Renderer>().enabled = true;
        man2.GetComponent<Renderer>().enabled = true;
        man3.GetComponent<Renderer>().enabled = true;
        menu.SetActive(false);

        // set content for Enviroment?? 
    }

    public void PresOnClick()
    {
        // show available prsentations in slider table
        // enable slider table with presentations content

        // set content for Presentation??
    }

    public void VideoOnClick()
    {
        // show available video in slider table
        // enable slider table with video content
        table.GetComponent<MeshRenderer>().enabled = true;
        zavod.GetComponent<Renderer>().enabled = true;
        menu.SetActive(false);

        // set content for Presentation??

    }

    public void DashboardOnClick()
    {
        // show dashboard above table
    }
}
