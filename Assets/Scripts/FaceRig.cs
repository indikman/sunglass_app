using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceRig : MonoBehaviour
{
    private GameObject referenceFaceRig;
    private FacePrefabManager faceRig;

    public Material frame, lens, arm_left, arm_right;

    

    void Start()
    {
        referenceFaceRig = GameObject.FindGameObjectWithTag("FacePrefabManager");
        faceRig = referenceFaceRig.GetComponent<FacePrefabManager>();

        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localPosition = referenceFaceRig.transform.localPosition;
        gameObject.transform.localEulerAngles = referenceFaceRig.transform.localEulerAngles;
        gameObject.transform.localScale = referenceFaceRig.transform.localScale;

        if (faceRig.isMatRefresh)
        {
            RefreshMaterials();
            faceRig.isMatRefresh = false;
            Debug.Log("Material Changed!");
        }
    }

    public void RefreshMaterials()
    {
        frame = faceRig.frameMat;
        lens = faceRig.lensMat;
        arm_left = faceRig.armMat;
        arm_right = faceRig.armMat;
    }
}
