﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenPathWay : MonoBehaviour
{
    public Animator anim;
    public GameObject gate;
    public GameObject panel;
    
    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Daruma")
        {
            anim.SetBool("isOpen", true);
            panel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Daruma")
        {
            anim.SetBool("isOpen", false);
            //panel.SetActive(false);
        }
    }
}
