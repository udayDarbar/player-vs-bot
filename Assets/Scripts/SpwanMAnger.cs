using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SpwanMAnger : MonoBehaviour
{
     public  GameObject  enemy ; 
     private float range = 9.0f ; 
      
    void Start()
    {   
        tospwan();
 
    }

    // Update is called once per frame
    void Update()
    { 
     
         
    }
    public void tospwan()
    {
        float spwanX = Random.Range(-range,range) ;
        float spwanZ = Random.Range(-range,range) ;
        Vector3 pos = new Vector3(spwanX,1,spwanZ); 
        Instantiate(enemy,pos,enemy.transform.rotation) ;
        
        

    }
}
