using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class jsonReader : MonoBehaviour
{
    public TextAsset jsonCollectionFile;
    public TextAsset jsonAreaFile;
    public TextAsset jsonAutographFile;
    public TextAsset jsonImprintFile;

    public GameObject button;
    public GameObject[] Canvas;
    public GameObject returnButton;

    public buttonInfo[] buttonInfo;
    public GameObject[] buttons;
    public Button[] _button;
    public string id_selected;
    public string item_selected;

    public TMPro.TextMeshProUGUI tittle;
    public TMPro.TextMeshProUGUI idFim;

    public TMP_InputField width;
    public TMP_InputField depth;
    public string widthData;
    public string depthData;


    string[] id;

    void Awake()
    {
        widthData = null;
        depthData = null;

        Collections collectionInJson = JsonUtility.FromJson<Collections>(jsonCollectionFile.text);
        foreach (Collection collection in collectionInJson.collections)
        {
            Debug.Log("Collection encontrado com id: " + collection.id + " E tittle: " + collection.title);
        }

        Areas areasInJson = JsonUtility.FromJson<Areas>(jsonAreaFile.text);
        foreach (Area area in areasInJson.items)
        {
            Debug.Log("Itens da Area encontrado com id: " + area.id + " E Title: " + area.title);
        }

        Autographs autographsInJson = JsonUtility.FromJson<Autographs>(jsonAutographFile.text);
        foreach (Autograph autograph in autographsInJson.items)
        {
            Debug.Log("Itens da Autograph encontrado com id: " + autograph.id + " E Title: " + autograph.title);
        }

        Imprints imprintsInJson = JsonUtility.FromJson<Imprints>(jsonImprintFile.text);
        foreach (Imprint imprint in imprintsInJson.items)
        {
            Debug.Log("Itens da Imprint encontrado com id: " + imprint.id + " E Title: " + imprint.title);
        }
    }
    void Start()
    {
        LoadCollectionSreen();
        Debug.Log(buttonInfo[0].id);
    }

    public void LoadCollectionSreen()
    {
        returnButton.SetActive(false);
        Collections collectionInJson = JsonUtility.FromJson<Collections>(jsonCollectionFile.text);
        buttons = new GameObject[collectionInJson.collections.Length];
        buttonInfo = new buttonInfo[collectionInJson.collections.Length];
        _button = new Button[collectionInJson.collections.Length];
        for (int i = 0; i < collectionInJson.collections.Length; i++)
        {
            var newButton = Instantiate(button) as GameObject;
            newButton.transform.SetParent(Canvas[0].GetComponent<Transform>(), false);
            buttons[i] = newButton;
            _button[i] = buttons[i].GetComponent<UnityEngine.UI.Button>();
            buttonInfo[i] = buttons[i].GetComponent<buttonInfo>();
            buttonInfo[i].tittle.text = collectionInJson.collections[i].title;
            buttonInfo[i].id = collectionInJson.collections[i].id;
            string[] splitArray = buttonInfo[i].tittle.text.Split(char.Parse(" "));
            buttonInfo[i].tittle.text = splitArray[0];
            Debug.Log(buttonInfo[i].id);
            buttonInfo[i].jReader = GetComponent<jsonReader>();
        }
    }

    public void LoadAreaItems()
    {
        returnButton.SetActive(true);
        Canvas[0].SetActive(false);
        Canvas[1].SetActive(true);
        Areas areasInJson = JsonUtility.FromJson<Areas>(jsonAreaFile.text);
        buttons = new GameObject[areasInJson.items.Length];
        buttonInfo = new buttonInfo[areasInJson.items.Length];
        _button = new Button[areasInJson.items.Length];
        for (int i = 0; i < areasInJson.items.Length; i++)
        {            
            var newButton = Instantiate(button) as GameObject;
            newButton.transform.SetParent(Canvas[1].GetComponent<Transform>(), false);
            buttons[i] = newButton;
            _button[i] = buttons[i].GetComponent<UnityEngine.UI.Button>();
            buttonInfo[i] = buttons[i].GetComponent<buttonInfo>();
            buttonInfo[i].tittle.text = areasInJson.items[i].title;
            buttonInfo[i].id = areasInJson.items[i].id;
            buttonInfo[i].jReader = GetComponent<jsonReader>();
        }
    }

    public void LoadAutographItems()
    {
        returnButton.SetActive(true);
        Canvas[0].SetActive(false);
        Canvas[2].SetActive(true);
        Autographs autographsInJson = JsonUtility.FromJson<Autographs>(jsonAutographFile.text);
        buttons = new GameObject[autographsInJson.items.Length];
        buttonInfo = new buttonInfo[autographsInJson.items.Length];
        _button = new Button[autographsInJson.items.Length];
        for (int i = 0; i < autographsInJson.items.Length; i++)
        {
            var newButton = Instantiate(button) as GameObject;
            newButton.transform.SetParent(Canvas[2].GetComponent<Transform>(), false);
            buttons[i] = newButton;
            _button[i] = buttons[i].GetComponent<UnityEngine.UI.Button>();
            buttonInfo[i] = buttons[i].GetComponent<buttonInfo>();
            buttonInfo[i].tittle.text = autographsInJson.items[i].title;
            buttonInfo[i].id = autographsInJson.items[i].id;
            buttonInfo[i].jReader = GetComponent<jsonReader>();
        }
    }

    public void LoadImprintItems()
    {
        returnButton.SetActive(true);
        Canvas[0].SetActive(false);
        Canvas[3].SetActive(true);
        Imprints imprintsInJson = JsonUtility.FromJson<Imprints>(jsonImprintFile.text);
        buttons = new GameObject[imprintsInJson.items.Length];
        buttonInfo = new buttonInfo[imprintsInJson.items.Length];
        _button = new Button[imprintsInJson.items.Length];
        for (int i = 0; i < imprintsInJson.items.Length; i++)
        {
            var newButton = Instantiate(button) as GameObject;
            newButton.transform.SetParent(Canvas[3].GetComponent<Transform>(), false);
            buttons[i] = newButton;
            _button[i] = buttons[i].GetComponent<UnityEngine.UI.Button>();
            buttonInfo[i] = buttons[i].GetComponent<buttonInfo>();
            buttonInfo[i].tittle.text = imprintsInJson.items[i].title;
            buttonInfo[i].id = imprintsInJson.items[i].id;
            buttonInfo[i].jReader = GetComponent<jsonReader>();
        }
    }

    public void LoadSizeScreen()
    {
        returnButton.SetActive(true);
        Canvas[1].SetActive(false);
        Canvas[2].SetActive(false);
        Canvas[3].SetActive(false);
        Canvas[4].SetActive(true);
    }

    public void FinalScreen()
    {
        Canvas[4].SetActive(false);
        Canvas[5].SetActive(true);
        tittle.text = id_selected;
        idFim.text = item_selected;

    }

    public void ReadStringInput()
    {
        widthData = width.text;
        Debug.Log(width);
        Debug.Log(widthData);
    }
    public void ReadStringInputDepth()
    {
        depthData = depth.text;
        Debug.Log(depth);
        Debug.Log(depthData);
    }
   
    public void ReturnButton()
    {
        if(Canvas[1].activeInHierarchy == true)
        {
            returnButton.SetActive(false);
            Canvas[1].SetActive(false);
            Canvas[0].SetActive(true);
        }
        if (Canvas[2].activeInHierarchy == true)
        {
            returnButton.SetActive(false);
            Canvas[2].SetActive(false);
            Canvas[0].SetActive(true);
        }
        if (Canvas[3].activeInHierarchy == true)
        {
            returnButton.SetActive(false);
            Canvas[3].SetActive(false);
            Canvas[0].SetActive(true);
        }
        if (Canvas[4].activeInHierarchy == true)
        {
            Canvas[4].SetActive(false);
            Canvas[3].SetActive(true);
        }
    }

}
