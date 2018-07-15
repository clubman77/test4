using UnityEngine;

public class Radar : MonoBehaviour {
    // 敵検出範囲
    public float detectionRange = 100;

    private GameObject player;
    private GameObject enemy;
    private GameObject icon;
    private float radarRadius = 0;

    // Use this for initialization
    private void Start() {
        // 各オブジェクトを取得
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        icon = GameObject.FindGameObjectWithTag("Icon");

        // レーダー半径を取得
        radarRadius = GetComponent<RectTransform>().sizeDelta.x / 2.0f - 5;

       // Debug.Log(radarRadius);
       // Debug.Log(GetComponent<RectTransform>().sizeDelta.x);
    }

    // Update is called once per frame
    private void Update() {
        // 相対位置を計算
        Vector3 pos = (enemy.transform.position - player.transform.position) * (radarRadius / detectionRange);

        //Debug.Log("vector3");
        //Debug.Log(pos);


        // カメラ角度に合わせて回転
        pos = Quaternion.Euler(0, -Camera.main.gameObject.transform.eulerAngles.y, 0) * pos;

        //Debug.Log("Euler");
        //Debug.Log(pos);

        // レーダー半径の範囲内に移動
        pos = Vector3.ClampMagnitude(pos, radarRadius);

        //Debug.Log("Area");
        //Debug.Log(pos);


        // 相対位置をレーダに反映
        icon.GetComponent<RectTransform>().anchoredPosition = new Vector2(pos.x, pos.z);

        //Debug.Log("vector2");
        //Debug.Log(pos);
    }
}