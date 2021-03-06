using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunglassMaterialManager : MonoBehaviour
{
    public FacePrefabManager faceRig;

    public sunglassMaterial[] frameMaterials;
    public sunglassMaterial[] lensMaterials;
    public sunglassMaterial[] armMaterials;

    public void SetMaterial(int type, int index)
    {
        Debug.Log(type + " " + index);
        faceRig.isMatRefresh = true;
    }
}


[System.Serializable]
public class sunglassMaterial
{
    public Material material;
    public Sprite buttonTexture;
    public Color32 tintColour;
}