using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalActivator : MonoBehaviour
{
    public GameObject portal;

    public CoinCollector coin;
    void Update()
    {
        if(coin.coinsCount >=4)
        {
            portal.SetActive(true);
        }
    }

}
