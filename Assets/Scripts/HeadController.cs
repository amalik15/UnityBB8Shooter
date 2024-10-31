using UnityEngine;

public class HeadController : MonoBehaviour
{
    public Transform target;
    public float HeadSpeed = 0.125f;

    public Vector3 location;

    void LateUpdate()
    {
        Vector3 postion = target.position + location;
        transform.position = postion;
    }

}
