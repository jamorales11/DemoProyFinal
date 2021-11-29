using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CreacionPersonaje : MonoBehaviour
{
    public GameObject camaraXR;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(1, 1, 1);
        StartCoroutine(moverCamara(pos));
    }


    IEnumerator moverCamara(Vector3 pos)
    {
        yield return new WaitForSeconds(5);
        camaraXR.transform.position = pos;
    }
}
