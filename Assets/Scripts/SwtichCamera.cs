using UnityEngine;
using UnityEngine.UI;

public class SwtichCamera : MonoBehaviour
{
    public Camera cameraA;
    public Camera cameraB;
    public KeyCode toggle = KeyCode.V;
    void Start()
    {
        SetActiveCamera(isBActive: false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(toggle))
        {
            bool isBActive = cameraB.enabled;
            SetActiveCamera(!isBActive);
        }
    }
    void SetActiveCamera(bool isBActive)
    {
        cameraA.enabled = !isBActive;
        cameraB.enabled = isBActive;

        var listenerA = cameraA.GetComponent<AudioListener>();
        var listenerB = cameraB.GetComponent<AudioListener>();

        if(listenerA)
            listenerA.enabled = !isBActive;
        if (listenerB)
            listenerB.enabled = isBActive;
    }
}
