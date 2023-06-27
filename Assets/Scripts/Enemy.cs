using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{
    public float speed  = 3.0f ;
    private Rigidbody enemyrb ;
    private GameObject player ;
    // Start is called before the first frame update
    void Start()
    {
        enemyrb = GetComponent<Rigidbody>();
        player =  GameObject.Find("Capsule") ;

    }

    // Update is called once per frame
    void Update()
    {
       enemyrb.AddForce((player.transform.position - transform.position).normalized * speed );
    }
}
