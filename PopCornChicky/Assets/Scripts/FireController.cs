using UnityEngine;
using System.Collections;

public class FireController : MonoBehaviour {

    private float scaleChange = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Usamos este metodo porque está sincronizado con las colisiones en vez del frame rate
    void FixedUpdate()
    {
        Debug.Log(Input.GetMouseButton(0) + " ~ " + Input.touchCount);
        bool pressing = Input.GetMouseButton(0) | Input.touchCount > 0;
        Vector3 newScale;
        float newXY;
        if (pressing){
            newXY = transform.localScale.x + scaleChange;
            //if (newXY > algunLimite?) newXY = elLimite;
        }
        else
        {
            newXY = transform.localScale.x - scaleChange;
            if (newXY < 0)
                newXY = 0;
        }
        newScale = new Vector3(newXY, newXY, transform.localScale.z);
        transform.localScale = newScale;
    }
}
