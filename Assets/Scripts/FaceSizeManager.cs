using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FaceSizeManager : MonoBehaviour
{

    
    public TextMeshProUGUI transformUpdator;
    public TMP_InputField multiplierInput;
    public bool isSettingsOpen = false;

    private Transform faceRigTransform;
    private float multiplier = 0.01f;

    private FaceRigTransform faceRigValue;

    void Start()
    {
        faceRigTransform = GameObject.FindGameObjectWithTag("FacePrefabManager").GetComponent<Transform>();

        faceRigValue = new FaceRigTransform();
        faceRigValue.position = new Vector3();
        faceRigValue.rotation = new Vector3();
        faceRigValue.scale = new Vector3();
    }

    public void SetPosition(string direction)
    {
        if (faceRigTransform == null)
        {
            return;
        }
            

        switch (direction)
        {
            case "x":
                faceRigTransform.localPosition += new Vector3(multiplier, 0, 0);
                break;
            case "-x":
                faceRigTransform.localPosition -= new Vector3(multiplier, 0, 0);
                break;
            case "y":
                faceRigTransform.localPosition += new Vector3(0, multiplier, 0);
                break;
            case "-y":
                faceRigTransform.localPosition -= new Vector3(0, multiplier, 0);
                break;
            case "z":
                faceRigTransform.localPosition += new Vector3(0, 0, multiplier);
                break;
            case "-z":
                faceRigTransform.localPosition -= new Vector3(0, 0, multiplier);
                break;
        }
    }

    public void SetRotation(string direction)
    {
        if (faceRigTransform == null)
        {
            return;
        }


        switch (direction)
        {
            case "x":
                faceRigTransform.localEulerAngles += new Vector3(multiplier, 0, 0);
                break;
            case "-x":
                faceRigTransform.localEulerAngles -= new Vector3(multiplier, 0, 0);
                break;
            case "y":
                faceRigTransform.localEulerAngles += new Vector3(0, multiplier, 0);
                break;
            case "-y":
                faceRigTransform.localEulerAngles -= new Vector3(0, multiplier, 0);
                break;
            case "z":
                faceRigTransform.localEulerAngles += new Vector3(0, 0, multiplier);
                break;
            case "-z":
                faceRigTransform.localEulerAngles -= new Vector3(0, 0, multiplier);
                break;
        }
    }

    public void setScale(bool ScaleUp)
    {
        if (faceRigTransform == null)
        {
            return;
        }


        if (ScaleUp)
        {
            faceRigTransform.localScale += new Vector3(multiplier, multiplier, multiplier);
        }
        else
        {
            faceRigTransform.localScale -= new Vector3(multiplier, multiplier, multiplier);
        }
    }

    public void SaveConfig()
    {
        faceRigValue.position = faceRigTransform.localPosition;
        faceRigValue.rotation = faceRigTransform.localEulerAngles;
        faceRigValue.scale = faceRigTransform.localScale;

        string value = JsonUtility.ToJson(faceRigValue);

        PlayerPrefs.SetString("FaceRigTransform", value);
    }

    void Update()
    {
        

        if (isSettingsOpen) {

            multiplier = float.Parse(multiplierInput.text) / 100f;

            if(faceRigTransform!=null)
                transformUpdator.text =
                    "Scale : " + faceRigTransform.localScale +
                    "\nPosition : " + faceRigTransform.localPosition +
                    "\nRotation : " + faceRigTransform.localEulerAngles;
        
        }
    }

}
