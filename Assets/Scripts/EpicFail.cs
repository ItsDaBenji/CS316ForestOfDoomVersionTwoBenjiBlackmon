using UnityEngine;
using UnityEngine.SceneManagement;

public class EpicFail : MonoBehaviour
{

    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("MrManager").GetComponent<GameManager>();
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") 
        {
            // write something to the Console just to make 
            // sure this function is being called
            Debug.Log("there went HexBoi");

            if (gameManager.numLivesLeft <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                gameManager.numLivesLeft--;
                // use SceneManager to load the CURRENT scene again (a reset)
                // the LoadScene function just wants a NUMBER of the scene to load
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
