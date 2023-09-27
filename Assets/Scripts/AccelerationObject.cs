using UnityEngine;

public class AccelerationObject : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    private float _currSpeed;

    void Update()
    {
        _currSpeed += Time.deltaTime * (Input.GetKey(KeyCode.Space) ? 1 : -1);
        transform.position += Vector3.forward * (_currSpeed = Mathf.Clamp(_currSpeed, 0, maxSpeed));
    }
}