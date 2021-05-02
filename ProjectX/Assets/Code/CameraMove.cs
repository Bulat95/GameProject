using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject Player;

    private Vector3 offset;


    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
