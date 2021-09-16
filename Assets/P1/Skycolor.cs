using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skycolor : MonoBehaviour
{
    public Gradient cycleColors;

    public Camera mainCamera;
    public Color startColor;
    public Color midColor;
    public Color endColor;
    public float fullyCycleTime = 18;
    float currentLerping = 0;


    // Start is called before the first frame update
    void Start()
    {
        Camera.main.backgroundColor = startColor;

    }

    // Update is called once per frame
    void Update()
    {

        // Method A
        //Manually Inverse the lerp the value
        //currentLerping = (1 / (fullyCycleTime / 3)) * Time.deltaTime;

        //Method B
        // Use Inverse lerp and calculate how much time has passed sice the start of the cycle
        // by multiplying it for how long a section of said cycle is
        currentLerping = Mathf.InverseLerp(0, fullyCycleTime / 3, currentLerping * Time.deltaTime);
        //Method C
        // keep track of the time and simply inverse lerp it
        

        if (currentLerping >= 0 && currentLerping < (1f/3))
        {
            Camera.main.backgroundColor = Color.Lerp(startColor, midColor, currentLerping * 3);

        }
        else if(currentLerping >= 1 && currentLerping < (2f/3))
        {
            Camera.main.backgroundColor = Color.Lerp(midColor, endColor, currentLerping - ((1f/3) * 3));
        }
        else if (currentLerping >= 2 && currentLerping < (3f/3))
        {
            Camera.main.backgroundColor = Color.Lerp(endColor, startColor, currentLerping - ((2f / 3) * 3));
        }
        else
        {

        }
    }
}
