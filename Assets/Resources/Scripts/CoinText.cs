﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        GetComponent<Text>().text = ShopComponent.Instance.Coin.ToString();
	}
}