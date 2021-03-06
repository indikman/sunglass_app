using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MaterialButton : MonoBehaviour
{
    public Image buttonRenderer;

    private SunglassMaterialManager matManager;

    int value, index;

    void Awake()
    {
        matManager = GameObject.FindGameObjectWithTag("SunglassMatManager").GetComponent<SunglassMaterialManager>();
    }

    public void SetupButton(Sprite sprite, Color colour, int value, int index)
    {
        buttonRenderer.color = colour;
        buttonRenderer.sprite = sprite;
        this.value = value;
        this.index = index;

        GetComponent<Button>().onClick.RemoveAllListeners();
        GetComponent<Button>().onClick.AddListener(() => {
            matManager.SetMaterial(value, index);
            });
    }

    
}
