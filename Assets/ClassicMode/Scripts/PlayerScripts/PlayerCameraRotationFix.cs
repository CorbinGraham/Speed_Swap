using UnityEngine;
public class PlayerCameraRotationFix : MonoBehaviour
{
    public Transform Player;
    private float zLocation;
    private Vector3 offset;
    private float y;

    void Start()
    {
        zLocation = -15.0f;

        Camera cam;
        cam = Camera.main;
        
        y = Screen.height / 25;
        offset = new Vector3(10,y,10);
        offset = cam.ScreenToWorldPoint(offset);
        y = offset.y;
    }
    void Update()
    {
        if (Player != null)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, Player.gameObject.transform.position.y - y, zLocation);
        }
    }

    public void setZLocation(float a) {zLocation = a;}

    public float getZLocation() { return zLocation; }
}
