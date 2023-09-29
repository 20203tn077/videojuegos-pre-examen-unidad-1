using UnityEngine;

public class Zigzag : MonoBehaviour
{
    [SerializeField] private float boundDistance;
    [SerializeField] private float speed;
    private float _direction = 1;
    
    void Update()
    {
        if (Mathf.Abs(transform.position.x) >= boundDistance) _direction *= -1;
        var pos = transform.position;
        pos += speed * Time.deltaTime * new Vector3(_direction, 1, 0);
        pos = new Vector3(
            Mathf.Clamp(pos.x, - boundDistance, boundDistance),
            pos.y,
            pos.z
        );
        transform.position = pos;
    }
}
