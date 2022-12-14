using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScriptF : MonoBehaviour
{
    //Rayの長さ
    public float maxDistance = 50;
    public Vector2 origin;
    public float YofF;
    public RaycastHit2D hit;

    public void Update()
    {
        Vector3 ts = this.transform.position;
        origin.x = ts.x;
        origin.y = ts.y;//始点(オブジェクトの座標を反映する)
        Vector2 direction = new Vector2(0, -1); // ベクトル
        Ray ray = new Ray(origin, direction); // Rayを生成
        Debug.DrawRay(ray.origin, ray.direction * 50, Color.red, 5.0f); // 長さ３０、赤色で５秒間可視化

        hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction, maxDistance);

        if (hit.collider & hit.collider.gameObject.CompareTag("Tumeru"))//TagがTumeruならrayが当たったオブジェクトの名前を表示
        {
            Debug.Log(hit.point);
            Debug.Log(YofF);
            YofF = hit.point.y; //rayが当たった座標のY座標をYofFという名前の変数で宣言
        }
        else if (hit.collider & hit.collider.gameObject.CompareTag("Tumenai"))//TagがTumenaiならnullを表示
        {
            Debug.Log("null");
            YofF = 0f;
        }
    }
}