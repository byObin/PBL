using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerSlider : MonoBehaviour
{
    Slider powerGauge;
    float power;
    bool filled;
    bool ismoving;
    int sliderSpeed=5;

    // Start is called before the first frame update
    void Start()
    {
        powerGauge = GetComponent<Slider>();
        powerGauge.value = 0.0f;
        filled = false;
    }

    // Update is called once per frame
    void Update()
    {
         if (filled == false && powerGauge.value < 1)
            {
                powerGauge.value += Time.deltaTime * sliderSpeed;
            }
            if (powerGauge.value == 1)
            {
                filled = true;

            }
            if (filled == true && powerGauge.value > 0)
            {
                powerGauge.value -= Time.deltaTime * sliderSpeed;
            }
            if (powerGauge.value == 0)
                filled = false;


        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space Up : " + powerGauge.value);

        }
    }
    

    
      
       
    
   
}


