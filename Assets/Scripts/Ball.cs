using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float initialSpeed = 8f;     // m/s
    [SerializeField] float randomYawRange = 45f;  // ±度
    [SerializeField, Range(0f, 40f)] float minAngleFromAxis = 10f; 
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    //Start is called before the first frame update
    void Start()
    {
        Launch();
    }

    public void Launch()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.isKinematic = false;

        // +Z（前）基準でY軸回りにランダムで「斜め前」
        float yaw = Random.Range(-randomYawRange, randomYawRange);
        Vector3 dir = Quaternion.Euler(0f, yaw, 0f) * Vector3.forward;

        // AddForce で初速付与（質量に依らず瞬時に速度を与えたい → VelocityChange）
        rb.AddForce(dir.normalized * initialSpeed, ForceMode.VelocityChange);
    }

    //Update is called once per frame
    // void Update()
    // {
    // }
}