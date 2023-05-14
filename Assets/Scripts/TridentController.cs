using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TridentController : MonoBehaviour
{
    GameObject player;
    public float Dropspeed;
    private void Start()
    {
        this.player = GameObject.Find("Gura"); //新增程式
    }
    void Update()
    {
        transform.Translate(0, Dropspeed, 0); //每個影格等速往下移動
        //炸彈超出畫面後銷毀以節省硬體空間
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
        //新增衝突判定
        Vector2 p1 = transform.position;                  //炸彈的圓心座標
        Vector2 p2 = this.player.transform.position; //遊戲角色的圓心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.2f; //炸彈的圓半徑
        float r2 = 0.5f; //角色的圓半徑
        //發生衝突
        if (d < r1 + r2)
        {
            //破壞物件
            Destroy(gameObject);
            //-1生命值
            PlayerController.Health -= 1;
            Debug.Log("Health = " + PlayerController.Health);
        }
    }
}
