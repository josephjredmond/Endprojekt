using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug1 : MonoBehaviour
{

    public GameObject Reel;
    public GameObject MyHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Reel.transform.SetParent(MyHand.transform);
        }
    }
}
