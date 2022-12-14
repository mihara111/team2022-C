using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracheck : MonoBehaviour
{
    private Camera _mainCamera;

    void Start()
    {
        // カメラオブジェクトを取得
        GameObject obj = GameObject.Find("Main Camera");
        _mainCamera = obj.GetComponent<Camera>();

        // 座標値を出力
        Debug.Log(getScreenTopLeft().x + ", " + getScreenTopLeft().y);
        Debug.Log(getScreenBottomRight().x + ", " + getScreenBottomRight().y);
    }

    private Vector3 getScreenTopLeft()
    {
        // 画面の左上を取得
        Vector3 topLeft = _mainCamera.ScreenToWorldPoint(Vector3.zero);
        // 上下反転
        topLeft.Scale(new Vector3(1f, -1f, 1f));
        return topLeft;
    }

    private Vector3 getScreenBottomRight()
    {
        // 画面の右下を取得
        Vector3 bottomRight = _mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.0f));
        // 上下反転
        bottomRight.Scale(new Vector3(1f, -1f, 1f));
        return bottomRight;
    }
}
