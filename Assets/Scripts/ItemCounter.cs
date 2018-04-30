using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCounter : MonoBehaviour {

    public int count = 0;
    public int tcount = 0;
    private bool played = false;
    public bool playing = false;

    // Use this for initialization
    void Start()
    {

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "count")
        {
            playing = true;
        }
    }

    public void OnGUI()
    {
        if (tcount == 0)
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, 10, 200, 35), " Hurry and find all the items!");
        }
        if (tcount == 1)
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, 10, 250, 35), " " + count + " item found. Quickly find the next one!");
        }
        if (tcount == 2)
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, 10, 300, 35), " " + count + " items found. The monster is getting closer!");
        }
        if (tcount == 3)
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, 10, 200, 35), " " + count + " items found. Just one more!");
        }
        if (tcount == 4)
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, 10, 350, 35), "You have found all the items! Hurry to the house!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playing == true)
        {
            if (Input.GetKey("e"))
            {
                if (!played)
                {
                    count = count + 1;
                    Debug.Log("You picked up a ritual item. Item = " + count);
                    played = true;
                    tcount++;
                }
                played = false;
            }
        }
    }
}