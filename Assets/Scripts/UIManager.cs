using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private SunglassMaterialManager sunglassMaterials;
    private GameObject referenceFaceRig;
    private FacePrefabManager faceRig;

    public Transform buttonParent;
    public GameObject buttonPrefab;

    // Start is called before the first frame update
    void Start()
    {
        referenceFaceRig = GameObject.FindGameObjectWithTag("FacePrefabManager");
        faceRig = referenceFaceRig.GetComponent<FacePrefabManager>();

        sunglassMaterials = GameObject.FindGameObjectWithTag("SunglassMatManager").GetComponent<SunglassMaterialManager>();

        LoadMaterials(1);
    }

    GameObject tempButtonObj;
    MaterialButton tempButton;
    sunglassMaterial[] materials;

    public void LoadMaterials(int value) // 1 - frame, 2 - lens, 3 - arms
    {
        foreach(Transform obj in buttonParent.GetComponentInChildren<Transform>())
        {
            Destroy(obj.gameObject);
        }

        


        if (value == 1)
        {
            materials = sunglassMaterials.frameMaterials;
            //for (int i = 0; i < sunglassMaterials.frameMaterials.Length; i++)
            //{
            //    tempButtonObj = Instantiate(buttonPrefab, buttonParent);
            //    tempButton = tempButtonObj.GetComponent<Button>();
            //    tempButtonRenderer = tempButtonObj.GetComponent<SpriteRenderer>();

            //    tempButton.onClick.RemoveAllListeners();
            //    tempButton.onClick.AddListener(()=>{ SetMaterial(value, i); });
            //    tempButtonRenderer.color = sunglassMaterials.frameMaterials[i].tintColour;
            //    tempButtonRenderer.sprite = sunglassMaterials.frameMaterials[i].buttonTexture;
            //}
        }
        else if (value == 2)
        {
            materials = sunglassMaterials.lensMaterials;
            //for (int i = 0; i < sunglassMaterials.lensMaterials.Length; i++)
            //{
            //    tempButtonObj = Instantiate(buttonPrefab, buttonParent);
            //    tempButton = tempButtonObj.GetComponent<Button>();
            //    tempButtonRenderer = tempButtonObj.GetComponent<SpriteRenderer>();

            //    tempButton.onClick.RemoveAllListeners();
            //    tempButton.onClick.AddListener(() => { SetMaterial(value, i); });
            //    tempButtonRenderer.color = sunglassMaterials.lensMaterials[i].tintColour;
            //    tempButtonRenderer.sprite = sunglassMaterials.lensMaterials[i].buttonTexture;
            //}

        }
        else if (value == 3)
        {
            materials = sunglassMaterials.armMaterials;
            //for (int i = 0; i < sunglassMaterials.armMaterials.Length; i++)
            //{
            //    tempButtonObj = Instantiate(buttonPrefab, buttonParent);
            //    tempButton = tempButtonObj.GetComponent<Button>();
            //    tempButtonRenderer = tempButtonObj.GetComponent<SpriteRenderer>();

            //    tempButton.onClick.RemoveAllListeners();
            //    tempButton.onClick.AddListener(() => { SetMaterial(value, i); });
            //    tempButtonRenderer.color = sunglassMaterials.armMaterials[i].tintColour;
            //    tempButtonRenderer.sprite = sunglassMaterials.armMaterials[i].buttonTexture;
            //}
        }

        for (int i = 0; i < materials.Length; i++)
        {
            tempButtonObj = Instantiate(buttonPrefab, buttonParent);
            tempButton = tempButtonObj.GetComponent<MaterialButton>();

            tempButton.SetupButton(materials[i].buttonTexture, materials[i].tintColour, value, i);

            //tempButton.onClick.AddListener(() => { SetMaterial(value, i); });
            //tempButtonRenderer.color = materials[i].tintColour;
            //tempButtonRenderer.sprite = materials[i].buttonTexture;
        }

        
    }

    public void SetMaterial(int type, int index)
    {
        Debug.Log(type + " " + index);
    }
}
