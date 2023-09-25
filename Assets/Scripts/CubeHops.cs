using UnityEngine;

public class CubeHops : MonoBehaviour
{
    [SerializeField] private new Rigidbody rigidbody;
    [SerializeField] private float jumpInterval;
    [SerializeField] private float jumpForce;
    private float _timePassed;

    void Update()
    {
        _timePassed += Time.deltaTime;
        if (_timePassed > jumpInterval)
        {
            _timePassed = 0;
            rigidbody.AddForce(new Vector3(1, 1, 0) * jumpForce);
            rigidbody.AddTorque(jumpForce * 0.5f * Vector3.back);
        }
    }
}