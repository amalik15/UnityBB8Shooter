using UnityEngine;

public class Target : MonoBehaviour
{

    public Score scoreManager;

    private void OnCollisionEnter(Collision collision)
    {
        scoreManager.AddPoint();

        Debug.Log("Collision detected");
        Destroy(gameObject);
    }
}
