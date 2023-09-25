using UnityEngine;

public class AccelerationObject : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    private float _currSpeed;

    void Update()
    {
        _currSpeed += Time.deltaTime * (Input.GetKey(KeyCode.Space) ? 1 : -1);
        if (_currSpeed < 0) _currSpeed = 0;
        if (_currSpeed > maxSpeed) _currSpeed = maxSpeed;
        transform.position += Vector3.forward * _currSpeed;
    }
}