using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class gru : MonoBehaviour
{
    DongGenerator airClass;
    int time = 0;
    public GameObject MV_air_original1;
    GameObject go;
    RaycastHit2D hit;

    void Start()
    {
        airClass = new DongGenerator();
    }

    void Update()
    {
        time++;
        if (time % 1000 == 0)
        {
            Debug.Log("그루토리의 공기생성");
            go = Instantiate(MV_air_original1) as GameObject;

            int px = Random.Range(-5, 8);//x좌표 랜덤 범위
            go.transform.position = new Vector3(px, 5, 0);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
            if (hit.collider != null && hit.collider.tag == "air")
            {
                GameObject.Find("GameManager").GetComponent<ScoreManager>().PlusScore(10);//ScoreManager에서 PlusScore함수 호출
                Destroy(go);
            }
        }

    }
 }
