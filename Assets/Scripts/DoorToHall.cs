﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorToHall : MonoBehaviour, IActivatable
{
    [SerializeField]
    private string nameText;

    [SerializeField]
    private string descriptionText;

    private MeshRenderer meshRenderer;
    //private InventoryMenu inventoryMenu;
    private Collider collider;

    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    public string DescriptionText { get { return descriptionText; } }

    private void Start()
    {
        //inventoryMenu = FindObjectOfType<InventoryMenu>();
        meshRenderer = GetComponent<MeshRenderer>();
        collider = GetComponent<Collider>();
    }
    public void DoActivate()
    {
        SceneManager.LoadScene("SmShipHall");

        // Doing this rather than destroy because our Inventory menu still needs
        // to know about this object even though it has been collected and 
        // removed from the 3D world.
        // Also, if you wanted to add sound effects here,
        // and we destroy before the sfx are done, it will not sound correct.
        // Just like how coin worked in our 2D project!
    }
}