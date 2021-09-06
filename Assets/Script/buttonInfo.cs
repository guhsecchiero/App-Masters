using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class buttonInfo : MonoBehaviour, ISelectHandler
{

    public string id;
    public TMPro.TextMeshProUGUI tittle;
    public jsonReader jReader;
    public nextButton nextBtn;

    void Start()
    {
        nextBtn = GameObject.Find("Next").GetComponent<nextButton>();
        nextBtn.buttonInfo = GetComponent<buttonInfo>();
    }

    public void OnSelect(BaseEventData eventData)
    {
        nextBtn.next.interactable = true;
        if(id == "area")
        {
            Debug.Log(id);
            jReader.id_selected = id;
        }
        if (id == "imprint")
        {
            Debug.Log(id);
            jReader.id_selected = id;
        }
        if (id == "autograph")
        {
            Debug.Log(id);
            jReader.id_selected = id;
        }
        if (id == "area-01")
        {
            Debug.Log(id);
            jReader.item_selected = id;
        }
        if (id == "area-02")
        {
            Debug.Log(id);
            jReader.item_selected = id;
        }
        if (id == "area-03")
        {
            Debug.Log(id);
            jReader.item_selected = id;
        }
        if (id == "imprint-01")
        {
            Debug.Log(id);
            jReader.item_selected = id;
        }
        if (id == "imprint-02")
        {
            Debug.Log(id);
            jReader.item_selected = id;
        }
        if (id == "autograph-01")
        {
            Debug.Log(id);
            jReader.item_selected = id;
        }
        if (id == "autograph-02")
        {
            Debug.Log(id);
            jReader.item_selected = id;
        }
        if (id == "autograph-03")
        {
            Debug.Log(id);
            jReader.item_selected = id;
        }
        if (id == "autograph-04")
        {
            Debug.Log(id);
            jReader.item_selected = id;
        }
    }

}
