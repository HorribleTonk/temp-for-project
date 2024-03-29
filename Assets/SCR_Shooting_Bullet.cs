﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Shooting_Bullet : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private GameObject bulletPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward; //same as --> this.transform.possition [Spwan bullet at player position]
        }
    }
}
