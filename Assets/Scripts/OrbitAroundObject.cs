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
        if (Input.GetKeyDown(KeyCode.X)) (transform.position, _currAxis) = GetPositionAndAxisByKey('x');
        else if (Input.GetKeyDown(KeyCode.Y)) (transform.position, _currAxis) = GetPositionAndAxisByKey('y');
        else if (Input.GetKeyDown(KeyCode.Z)) (transform.position, _currAxis) = GetPositionAndAxisByKey('z');
    }

    (Vector3 position, Vector3 axis) GetPositionAndAxisByKey(char key) => key switch
    {
        'x' => (Vector3.up * distance, Vector3.right),
        'y' => (Vector3.forward * distance, Vector3.up),
        'z' => (Vector3.right * distance, Vector3.forward)
    };
}