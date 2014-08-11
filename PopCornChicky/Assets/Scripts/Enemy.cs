using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Eventos disparados por las colisiones
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag.Equals("Fire"))
        {
            anim.SetTrigger("PopIt");
        }
    }

    void OnTriggerExit(Collider other)
    {
        //Nada por ahora
    }
}
