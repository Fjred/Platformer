
using UnityEngine;
using TMPro;
public class CoinCollector : MonoBehaviour
{
    // collide with coin
    // increase score
    // show TMPro UI score

    public TMP_Text coinsText;

    public float coinsCount = 0;

    void Update()
    {
        coinsText.text = coinsCount.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coinsCount += 1;

            Destroy(collision.gameObject);

        }
    }
}
