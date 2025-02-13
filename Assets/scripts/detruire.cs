using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class separt : MonoBehaviour
{
    public string targetTag = "Target";
    public string terminusTag = "Terminus";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            Destroy(other.gameObject);
        }
        else if (other.CompareTag(terminusTag))
        {
            StartCoroutine(RestartGame());
        }
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}