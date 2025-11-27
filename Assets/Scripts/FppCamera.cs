using UnityEngine;

public class FppCamera : MonoBehaviour
{
    public GameObject player;
    public Transform playerCamera;
    private Vector3 offset = new Vector3(0.5f,1.9f,0.5f);
    private Quaternion rotationoffset;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //save the initial relative rotation between camera and player
        rotationoffset = transform.rotation * Quaternion.Inverse(playerCamera.rotation);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.rotation = playerCamera.rotation * rotationoffset;
    }
}
