﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundry") return;
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }
        Destroy(gameObject);
        if (other.tag == "Planet" || other.tag == "Fauna") return;
        Destroy(other.gameObject);
    }
}
