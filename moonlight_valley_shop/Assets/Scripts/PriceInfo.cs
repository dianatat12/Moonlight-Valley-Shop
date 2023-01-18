using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Progress;

public class PriceInfo : MonoBehaviour
{
    public int ItemID;
    [SerializeField] public TextMeshProUGUI PriceTxt;
    [SerializeField] public TextMeshProUGUI QuantityTxt;
    public GameObject ShopManager;


    void Update()
    {
        PriceTxt.text = ShopManager.GetComponent<Shop_Seeds>().shopItems[2, ItemID].ToString();
        QuantityTxt.text = ShopManager.GetComponent<Shop_Seeds>().shopItems[3, ItemID].ToString();
       
    }
 
   
}
