using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab2 : MonoBehaviour
{
    public GameObject FilmReel2;
    public GameObject MyHand;
    bool inHand = false;
    Vector3 ReelPos;
    // Start is called before the first frame update
    void Start()
    {
        ReelPos = FilmReel2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            if(!inHand){
                FilmReel2.transform.SetParent(MyHand.transform);
                FilmReel2.transform.localPosition = new Vector3(0.8f, -0.85f, 2.6f);
                inHand = true;
            }
            else if(inHand){
                this.GetComponent<PlayerGrab>().enabled=false;
                FilmReel2.transform.SetParent(null);
                FilmReel2.transform.localPosition = ReelPos;
                inHand = false;
            }
           
        }
    }
}

