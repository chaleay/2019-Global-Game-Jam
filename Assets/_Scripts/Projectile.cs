﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    
    public float speed;
    
    void Update() {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    
}
