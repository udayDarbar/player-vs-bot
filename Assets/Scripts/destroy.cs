using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject i ;
    
   

      void Start()
    {   
         i = GameObject.Find("SpwanMangare");
        
      
    }
    // Update is called once per frame
    void Update()
    {         
        if (transform.position.y < -3)
        {
            Destroy(gameObject);
          
        i.GetComponent<SpwanMAnger>().tospwan() ;
       
        }
       
    }
}
