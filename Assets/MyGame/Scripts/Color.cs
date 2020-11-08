using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color : MonoBehaviour
{
    public GameObject colorPopUp;
    public GameObject buttons;    

    private void Start()
    {
        ClosePopUp();
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
        buttons.SetActive(false);
        colorPopUp.SetActive(true);
    }

    public void ClosePopUp()
    {
        buttons.SetActive(true);
        colorPopUp.SetActive(false);
    }

    public void ChangeColor (Image selectedImage)
    {
        Camera.main.backgroundColor = selectedImage.color;
    }
}
