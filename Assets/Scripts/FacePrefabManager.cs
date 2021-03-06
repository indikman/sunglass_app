﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePrefabManager : MonoBehaviour
{

    


    void Awake()
    {
        if (PlayerPrefs.HasKey("FaceRigTransform"))
        {
            FaceRigTransform faceRigValue = JsonUtility.FromJson<FaceRigTransform>(PlayerPrefs.GetString("FaceRigTransform"));

            if (faceRigValue != null)
            {
                gameObject.transform.localPosition = faceRigValue.position;
                gameObject.transform.localEulerAngles = faceRigValue.rotation;
                gameObject.transform.localScale = faceRigValue.scale;

            }
        }
    }

    

}
