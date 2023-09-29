using UnityEngine;

public class OrbitAroundObject : MonoBehaviour
{
    [SerializeField] private GameObject primary;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float distance;
    private Vector3 _currAxis = Vector3.forward;

    void Update()
    {
        transform.RotateAround(primary.transform.position, _currAxis, Time.deltaTime * 360 * rotationSpeed);
        (transform.position, _currAxis) =
            Input.GetKeyDown(KeyCode.X) ? (Vector3.up * distance, Vector3.right) :
            Input.GetKeyDown(KeyCode.Y) ? (Vector3.forward * distance, Vector3.up) :
            Input.GetKeyDown(KeyCode.Z) ? (Vector3.right * distance, Vector3.forward) :
            (transform.position, _currAxis);
    }
}