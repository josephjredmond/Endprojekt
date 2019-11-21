using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public GameObject FilmReel1;
    public GameObject MyHand;
    bool inHand = false;
    Vector3 ReelPos;
    // Start is called before the first frame update
    void Start()
    {
        ReelPos = FilmReel1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            if(!inHand){
                FilmReel1.transform.SetParent(MyHand.transform);
                FilmReel1.transform.localPosition = new Vector3(0.8f, -0.85f, 2.6f);
                inHand = true;
            }
            else if(inHand){
                this.GetComponent<PlayerGrab>().enabled=false;
                FilmReel1.transform.SetParent(null);
                FilmReel1.transform.localPosition = ReelPos;
                inHand = false;
            }
           
        }
    }
}
