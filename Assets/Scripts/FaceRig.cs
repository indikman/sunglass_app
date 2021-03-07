using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceRig : MonoBehaviour
{
    
    public Material frame, lens, arm_left, arm_right;
    public Renderer frameRend, lensRend, armLRend, armRRend;

    private GameObject referenceFaceRig;
    private FacePrefabManager faceRig;

    void Start()
    {
        referenceFaceRig = GameObject.FindGameObjectWithTag("FacePrefabManager");
        faceRig = referenceFaceRig.GetComponent<FacePrefabManager>();

        RefreshMaterials();
    }

    
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

        if (frame != null)
        {
            frameRend.material = frame;
        }

        if (lens != null)
        {
            lensRend.material = lens;
        }

        if (arm_left != null)
        {
            armLRend.material = arm_left;
        }

        if (arm_right != null)
        {
            armRRend.material = arm_right;
        }
    }
}
