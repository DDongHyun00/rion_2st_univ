using JetBrains.Annotations;
using UnityEngine;

public class MoveScripts : MonoBehaviour
{

    public float RevSpeed;
    public float RotSpeed;
    public GameObject obj;
    
    void Start()
    {
       
    }

    void Update()
    {
        // 공전
        // RotateAround(기준으로 삼을 대상, 회전 축, 속도)
        transform.RotateAround(obj.transform.position, Vector3.up, Time.deltaTime * RevSpeed * 5.0f);

        //자전
        transform.Rotate(Vector3.up * Time.deltaTime * RotSpeed * 5.0f);
    }
}
