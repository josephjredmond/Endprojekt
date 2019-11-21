using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    public Material NoLooking;
    public Material Looking;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = NoLooking;
    }

    public void Watching(){
        GetComponent<Renderer>().material = Looking;
    }

    public void NoWatching(){
        GetComponent<Renderer>().material = NoLooking;
    }

}
