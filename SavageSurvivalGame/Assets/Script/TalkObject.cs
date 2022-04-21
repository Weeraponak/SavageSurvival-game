using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkObject : MonoBehaviour
{
    public float radius = 3f; 
    public Transform player;
    public Transform interactItem;
    public GameObject talkUI;
    private AudioSource audioSource;

    void Update()
    {
        audioSource = GetComponent<AudioSource>();
        float distance = Vector3.Distance(player.position, interactItem.position);
        if (distance <= radius)
        {
            Interact();
        }
        else
        {
            talkUI.SetActive(false);
        }
    }

    public virtual void Interact()
    {
        talkUI.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name.Equals("Lumberjack3"))
        {
            audioSource.Play();
            Debug.Log("PlaySound");
        } 

        if (gameObject.name.Equals("ChickenBrown (6)"))
        {
            audioSource.Play();
        }

        if (gameObject.name.Equals("NPC_Tools_Axe_004"))
        {
            audioSource.Play();           
        }

        if (gameObject.name.Equals("stone3"))
        {
            audioSource.Play();
        }

        if (gameObject.name.Equals("Sheep"))
        {
            audioSource.Play();
        }

        if (gameObject.name.Equals("Crate_Sealed_01"))
        {
            audioSource.Play();
        }

        if (gameObject.name.Equals("DuckWhite (4)"))
        {
            audioSource.Play();
        }

        if (gameObject.name.Equals("LowPoly - FirTree B (1)"))
        {
            audioSource.Play();
        }

        if (gameObject.name.Equals("Crystal_Light_Blue_01"))
        {
            audioSource.Play();
        }

        if (gameObject.name.Equals("Cactus_13 1"))
        {
            audioSource.Play();
        }

        if (gameObject.name.Equals("Banana"))
        {
            audioSource.Play();
        }

        if (gameObject.name.EndsWith("Mushroom_Tall_01"))
        {
            audioSource.Play();
        }

        if (gameObject.name.EndsWith("Well_01"))
        {
            audioSource.Play();
        }

        if (gameObject.name.EndsWith("Olive"))
        {
            audioSource.Play();
        }

        if (gameObject.name.EndsWith("Cheese"))
        {
            audioSource.Play();
        }

        if (gameObject.name.EndsWith("Watermelon (1)"))
        {
            audioSource.Play();
        }

        if (gameObject.name.EndsWith("Cherry (2)"))
        {
            audioSource.Play();
        }

        if (gameObject.name.EndsWith("Hamburger (7)"))
        {
            audioSource.Play();
        }

        if (gameObject.name.EndsWith("Pig (2)"))
        {
            audioSource.Play();
        }

        if (gameObject.name.EndsWith("CowBlW (1)"))
        {
            audioSource.Play();
        }

        if (gameObject.name.EndsWith("Tombstone_Enscribed_01"))
        {
            audioSource.Play();
        }

        if (gameObject.name.EndsWith("marker"))
        {
            audioSource.Play();
        }

        if (gameObject.name.EndsWith("Bone_Ribcage_02"))
        {
            audioSource.Play();
        }

        if (gameObject.name.EndsWith("Mountain_Volcano_01 (1)"))
        {
            audioSource.Play();
        }
    }

    //สร้างขอบเขตการชนไอเทม หรือ บริเวรที่พบไอเทม
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(interactItem.position, radius);

    }
}
