﻿using UnityEngine;
using System.Collections;

public class PlaceTrapScript : MonoBehaviour {
    public GameObject bearTrap;
    public GameObject player;

    private bool onCooldown;

    private float cooldownCounter;
    public float cooldownTime = 5;
	// Use this for initialization
	void Start () {
        onCooldown = false;
        cooldownCounter = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (!onCooldown)
            {
                Instantiate(bearTrap, player.transform.position + (player.transform.forward * 2), transform.rotation);
                onCooldown = true;
            }
        }

        if (onCooldown)
        {
            cooldownCounter += Time.deltaTime;
            if (cooldownCounter >= cooldownTime)
            {
                cooldownCounter = 0;
                onCooldown = false;
            }
        }
    }

}
