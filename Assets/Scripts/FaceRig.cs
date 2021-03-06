using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceRig : MonoBehaviour
{
    private Transform referenceLocalTransform;

    void Start()
    {
        referenceLocalTransform = GameObject.FindGameObjectWithTag("FacePrefabManager").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localPosition = referenceLocalTransform.localPosition;
        gameObject.transform.localEulerAngles = referenceLocalTransform.localEulerAngles;
        gameObject.transform.localScale = referenceLocalTransform.localScale;
    }
}
