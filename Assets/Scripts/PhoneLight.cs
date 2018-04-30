using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PhoneLight : MonoBehaviour
{

    public float lightDrain = 0.1F;
    private static float batteryLife = 100;
    public float maxbatteryLife = 100;
    public Image currentBatteryLife;
    public Text Batratio;

    public Light Plight;
    private static float minusbat = 1;

    // Use this for initialization
    void Start()
    {
        Plight = GetComponent<Light>();
        Plight.enabled = false;
    }

    /*public static void depleteBat(float amount)
    {
        batteryLife = Mathf.Clamp(batteryLife - minusbat, 0, 100);
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Plight.enabled == true && batteryLife >= 0)
        {
            batteryLife -= Time.deltaTime * lightDrain;
            float ratio = batteryLife / maxbatteryLife;
            currentBatteryLife.rectTransform.localScale = new Vector3(ratio, 1, 1);
            Batratio.text = batteryLife.ToString("0.00") + '%';
        }

        if (batteryLife <= 0)
        {
            batteryLife = 0;
            Plight.enabled = false;
            //batteryLife += Time.deltaTime * lightDrain;
            float ratio = batteryLife / maxbatteryLife;
            currentBatteryLife.rectTransform.localScale = new Vector3(ratio, 1, 1);
            Batratio.text = batteryLife.ToString("0.00") + '%';
        }

        

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Plight.enabled == true)
            {
                Plight.enabled = false;
                Debug.Log("light is now false");
                RenderSettings.fogDensity = 0.8F;

            }
            else if (Plight.enabled == false)
            {
                Plight.enabled = true;
                Debug.Log("light is now true");
                RenderSettings.fogDensity = 0.04F;

            }

        }
    }
}
