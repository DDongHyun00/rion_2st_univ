using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] float speed = 5f; //이동속도
    //private float gravity;
    private CharacterController controller; //캐릭터 컨트롤러
    private Vector3 mov; //방향


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        mov = Vector3.zero; //벡터 초기화
        //gravity = 9.8f; //중력값 설정
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 mov = new Vector3(h, 0, v);
        this.transform.Translate(mov * Time.deltaTime * speed);

    }
}
