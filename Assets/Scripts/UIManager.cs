using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    

    public Transform buttonParent;
    public GameObject buttonPrefab;

    public TextMeshProUGUI btn_frame, btn_arms, btn_lens;
    public Color highlightedColour, normalColour;

    private SunglassMaterialManager sunglassMaterials;

    private GameObject tempButtonObj;
    private MaterialButton tempButton;
    private sunglassMaterial[] materials;

    
    void Start()
    {
        sunglassMaterials = GameObject.FindGameObjectWithTag("SunglassMatManager").GetComponent<SunglassMaterialManager>();

        LoadMaterials(1);
        SetButtonHighlight(btn_frame);
    }


    public void SetButtonHighlight(TextMeshProUGUI selectedButton)
    {
        btn_arms.color = normalColour;
        btn_frame.color = normalColour;
        btn_lens.color = normalColour;

        selectedButton.color = highlightedColour;
    }

    public void LoadMaterials(int value) // 1 - frame, 2 - lens, 3 - arms
    {
        //Clear all the buttons in the scrollview
        foreach(Transform child in buttonParent.transform)
        {
            Destroy(child.gameObject);
        }



        if (value == 1)
        {
            materials = sunglassMaterials.frameMaterials;
        }
        else if (value == 2)
        {
            materials = sunglassMaterials.lensMaterials;
        }
        else if (value == 3)
        {
            materials = sunglassMaterials.frameMaterials;
        }

        for (int i = 0; i < materials.Length; i++)
        {
            tempButtonObj = Instantiate(buttonPrefab, buttonParent);
            tempButton = tempButtonObj.GetComponent<MaterialButton>();

            tempButton.SetupButton(materials[i].buttonTexture, materials[i].tintColour, value, i);
        }

        
    }

    public void SetMaterial(int type, int index)
    {
        Debug.Log(type + " " + index);
    }
}
