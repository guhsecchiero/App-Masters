using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class nextButton : MonoBehaviour, ISelectHandler
{
    public Button next;
    public bool nextScreen;
    public buttonInfo buttonInfo;
    public jsonReader jReader;

    void Start()
    {
        buttonInfo = GetComponent<buttonInfo>();
        nextScreen = false;
    }

    public void OnSelect(BaseEventData eventData)
    {
        nextScreen = true;

    }

    public void ChangeScreen()
    {
        if (nextScreen == true && jReader.id_selected == "area")
        {
            jReader.LoadAreaItems();
            next.interactable = false;
        }
        if (nextScreen == true && jReader.id_selected == "imprint")
        {
            jReader.LoadImprintItems();
            next.interactable = false;
        }
        if (nextScreen == true && jReader.id_selected == "autograph")
        {
            jReader.LoadAutographItems();
            next.interactable = false;
        }
        if (nextScreen == true && jReader.item_selected == "area-01")
        {
            jReader.LoadSizeScreen();
            next.interactable = true;
        }
        if (nextScreen == true && jReader.item_selected == "area-02")
        {
            jReader.LoadSizeScreen();
            next.interactable = true;
        }
        if (nextScreen == true && jReader.item_selected == "area-03")
        {
            jReader.LoadSizeScreen();
            next.interactable = true;
        }
        if (nextScreen == true && jReader.item_selected == "imprint-01")
        {
            jReader.LoadSizeScreen();
            next.interactable = true;
        }
        if (nextScreen == true && jReader.item_selected == "imprint-02")
        {
            jReader.LoadSizeScreen();
            next.interactable = true;
        }
        if (nextScreen == true && jReader.item_selected == "autograph-01")
        {
            jReader.LoadSizeScreen();
            next.interactable = true;
        }
        if (nextScreen == true && jReader.item_selected == "autograph-02")
        {
            jReader.LoadSizeScreen();
            next.interactable = true;
        }
        if (nextScreen == true && jReader.item_selected == "autograph-03")
        {
            jReader.LoadSizeScreen();
            next.interactable = true;
        }
        if (nextScreen == true && jReader.item_selected == "autograph-04")
        {
            jReader.LoadSizeScreen();
            next.interactable = true;
            nextScreen = true;
        }
        if(nextScreen = true && jReader.widthData != null && jReader.depthData != null)
        {
           // next.interactable = true;
            jReader.FinalScreen();           
        }

    }
}
