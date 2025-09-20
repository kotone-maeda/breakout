using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed = 4f;
    public float limit = 4f;

    //Start is called before the first frame update
    // void Start()
    // {

    // }

    //Update is called once per frame
    void Update()
    {
        var kb = Keyboard.current;
        if (kb == null) return;

        float dir = 0f;
        if (kb.leftArrowKey.isPressed || kb.aKey.isPressed)  dir -= 1f;
        if (kb.rightArrowKey.isPressed || kb.dKey.isPressed) dir += 1f;

        // 位置更新＋範囲制限
        var pos = transform.position;
        pos.x = Mathf.Clamp(pos.x + dir * speed * Time.deltaTime, -limit, limit);
        transform.position = pos;
    }
}