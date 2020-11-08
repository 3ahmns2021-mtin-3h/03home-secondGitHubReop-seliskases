using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Value : MonoBehaviour
{
    public GameObject buttons;
    public GameObject valuePopUp;
    public TextMeshProUGUI text;

    private float value;

    private void Start()
    {
        buttons.SetActive(true);
        valuePopUp.SetActive(false);
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ClosePopUp();
        }
    }

    public void OpenPopUp()
    {
        foreach (Transform child in buttons.transform)
        {
            if (child.gameObject.tag != "ValueButton")
            {
                child.gameObject.SetActive(false);
            }
        }
        valuePopUp.SetActive(true);
    }

    public void ClosePopUp()
    {
        foreach (Transform child in buttons.transform)
        {
            child.gameObject.SetActive(true);
        }
        valuePopUp.SetActive(false);
    }

    public void ChangeValue (float valueChange)
    {
        OpenPopUp();
        value += valueChange;
        text.text = value.ToString();
    }
}
