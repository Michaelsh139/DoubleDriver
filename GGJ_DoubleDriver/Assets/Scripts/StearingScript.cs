using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StearingScript : MonoBehaviour {

    private float stearingRate; // On a scale of -2 to 2 when 0 is forward
    public float 
	
    void Awake()
    {
        stearingRate = 0; // Forward
    }

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("d") && stearingRate >= -2 && stearingRate < 2)
        {

        }
	}
}
