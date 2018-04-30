using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public bool buttonInRanged;
    private bool played = false;
    //private static float minusbat = 10;

    void OnTriggerEnter(Collider col)
    {
        buttonInRanged = true;
    }
	void OnTriggerExit(Collider col)
    {
        buttonInRanged = false;
    }

    public void OnGUI()
    {
        if(buttonInRanged == true)
        {
            GUI.Label(new Rect (Screen.width / 2 - 50, Screen.height / 2 - 55, 120, 50), "Pick up Item 'E'");
        }
    }

    void Update()
    {
        if(buttonInRanged == true)
        {
            if(Input.GetKey("e"))
            {
                if(!played)
                {
                    //PhoneLight.depleteBat(minusbat);
                    Destroy(gameObject);
                    played = true;
                }
                
            }
        }
    }
}

