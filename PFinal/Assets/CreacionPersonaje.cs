using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.XR;

using UnityEngine.XR.Interaction.Toolkit;


public class CreacionPersonaje : MonoBehaviour
{
    public GameObject camaraXR;
    public XRController controller = null;

    public GameObject control;
    // Start is called before the first frame update
    void Start()
    {
        control = GameObject.FindGameObjectWithTag("GameController");
        controller = control.GetComponent<XRController>();
    }

    

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(1, 1, 1);
        //if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool menubutton))
        //  Debug.Log("MAGK");
        GameObject ball = GameObject.FindGameObjectWithTag("ball");
        pos = ball.GetComponent<Transform>().position;
        StartCoroutine(moverCamara(pos));

        
    }


    IEnumerator moverCamara(Vector3 pos)
    {
        yield return new WaitForSeconds(5);
        Debug.Log("GO");
        camaraXR.transform.position = pos;
    }
}

