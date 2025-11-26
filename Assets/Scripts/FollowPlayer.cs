using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
  /*  public float CameraRotationX = 19.3f;
    public float CameraRotationY = 0;
    public float CameraRotationZ = 0; */
    private Vector3 offset = new Vector3(0, 5.72f, -7);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
       transform.position = player.transform.position + offset;
     //   transform.rotation = transform.rotation(CameraRotationX, CameraRotationY, CameraRotationZ);
    }
   
}
