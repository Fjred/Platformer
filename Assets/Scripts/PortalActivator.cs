using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalActivator : MonoBehaviour
{
    public GameObject portal;

    public CoinCollector coin;

    public int coinsToTeleport = 4;

    private void Start()
    {
        portal.SetActive(false);
    }
    void Update()
    {
        if(coin.coinsCount >= coinsToTeleport)
        {
            
            portal.SetActive(true);
        }
    }

}
