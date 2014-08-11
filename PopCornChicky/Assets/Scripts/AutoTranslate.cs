using UnityEngine;
using System.Collections;

public class AutoTranslate : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        transform.Translate(0, - speed, 0);
    }
}
