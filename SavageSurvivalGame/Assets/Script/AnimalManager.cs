using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour
{
    public GameObject[] items;


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Axe")
        {
            if (PlayerMovement.instance.isAttack == true)
            {
                Invoke("SpawnItem", 0.5f);
            }
        }
    }
    void SpawnItem()
    {
        foreach (var item in items)
        {
            item.SetActive(true);
        }
        Destroy(GetComponent<CapsuleCollider>());
        GetComponent<MeshRenderer>().enabled = false;
    }
}
