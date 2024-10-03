using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public bool playerInRange;
    public string ItemName;

public string GetItemName()
    {
        return ItemName;
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0) && playerInRange && SelectionManager.Instance.onTarget)
        {

            Debug.Log("item added to inventory");

            Destroy(gameObject);




        }


    }



    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))
        {
            playerInRange = true;


        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;



        }
    }
}