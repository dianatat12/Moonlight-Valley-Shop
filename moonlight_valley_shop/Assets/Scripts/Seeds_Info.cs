using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Seeds_Info : MonoBehaviour
{
    public int ItemID;
    [SerializeField] public TextMeshProUGUI PriceTxt;
    [SerializeField] public TextMeshProUGUI QuantityTxt;
    public GameObject ShopManager;

    /*
    private void Start()
    {
        PlayerPrefs.SetString("PriceTxt", PriceTxt.text);
    }*/

    void Update()
    {
        PriceTxt.text = ShopManager.GetComponent<Shop_Seeds>().shopItems[2, ItemID].ToString();
        QuantityTxt.text = ShopManager.GetComponent<Shop_Seeds>().shopItems[3, ItemID].ToString();
    }

    }
