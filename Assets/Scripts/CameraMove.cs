using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [Header("Dystans Poruszania")]
    [SerializeField] private float minX;
    [SerializeField] private float maxX;

    [Header("Szybkoœæ")]
    [SerializeField] private float speedMove;

    private Camera camera;
    private float clampX;

    private void Awake()
    {
        camera = GetComponent<Camera>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Translate(Vector3.left * speedMove * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        { 
            transform.Translate(Vector3.right * speedMove * Time.deltaTime);
        }

        clampX = Mathf.Clamp(transform.position.x, minX, maxX);

        transform.position = new Vector3(
            clampX,
            transform.position.y,
            transform.position.z
            );
    }
}
