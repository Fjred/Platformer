
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerTeleport : MonoBehaviour
{
    private SpriteRenderer renderer;

    public float teleportTime = 1;

    public float teleportTimeLeft;

    public string nextLevel;

    public int nextScene;

    public AudioSource teleport;

    public bool newLevel = false;
    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();

        teleportTimeLeft = teleportTime;

        if(newLevel == true)
        {
            teleport.Play();
        }
    }

    private void Update()
    {
        renderer.color = new Color(1, 1, 1, teleportTimeLeft);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Portal")) return;

        teleportTimeLeft -= Time.deltaTime;

        if (teleportTimeLeft <= 0)
        {
            

            SceneManager.LoadScene(nextScene);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        teleportTimeLeft = teleportTime;
    }
}
