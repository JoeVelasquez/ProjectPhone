/*using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PhoneLight : MonoBehaviour
{

    public float lightDrain = 0.1F;
    public float batteryLife = 100;
    public float maxbatteryLife = 100;
    public Image currentBatteryLife;
    public Text Batratio;

    Light light;
    // Use this for initialization
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (light.enabled == true && batteryLife >= 0)
        {
            batteryLife -= Time.deltaTime * lightDrain;
            float ratio = batteryLife / maxbatteryLife;
            currentBatteryLife.rectTransform.localScale = new Vector3(ratio, 1, 1);
            Batratio.text = batteryLife.ToString() + '%';
        }
        if (light.enabled == false && batteryLife >= 0)
        {
            batteryLife += Time.deltaTime * lightDrain;
            float ratio = batteryLife / maxbatteryLife;
            currentBatteryLife.rectTransform.localScale = new Vector3(ratio, 1, 1);
            Batratio.text = batteryLife.ToString() + '%';
            if (batteryLife >= 100)
            {
                batteryLife = 100;
            }
        }
        if (batteryLife <= 0)
        {
            batteryLife = 0;
            light.enabled = false;
            batteryLife += Time.deltaTime * lightDrain;
            float ratio = batteryLife / maxbatteryLife;
            currentBatteryLife.rectTransform.localScale = new Vector3(ratio, 1, 1);
            Batratio.text = batteryLife.ToString() + '%';
        }



        if (Input.GetKeyDown(KeyCode.F))
        {
            if (light.enabled == true)
            {
                light.enabled = false;
                Debug.Log("light is now false");

            }
            else if (light.enabled == false)
            {
                light.enabled = true;
                Debug.Log("light is now true");

            }

        }
    }
}
*/

