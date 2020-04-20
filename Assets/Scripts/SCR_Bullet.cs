using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 8.0f;

    // Update is called once per frame
    void Update()
    {
        //Make the bullet move in forward direction.
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Time.deltaTime * bulletSpeed + .1f))
        {
            Vector3 reflectDir = Vector3.Reflect(ray.direction, hit.normal);
            float rot = 90 - Mathf.Atan2(reflectDir.z, reflectDir.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, rot, rot);
        }

    }
}