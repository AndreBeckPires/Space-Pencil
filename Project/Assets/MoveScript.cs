﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MoveScript : MonoBehaviour
{

    float directionX;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        directionX = CrossPlatformInputManager.GetAxis("Horizontal");
        rb.velocity = new Vector2(directionX * 60, 0);
    }
}
