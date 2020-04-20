using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Enemy_Object : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Collision has been detected with bullet object!!!");
            DestroyGameObject();
        }

    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
