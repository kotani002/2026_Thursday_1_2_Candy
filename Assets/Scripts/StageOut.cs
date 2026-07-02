using UnityEngine;
using UnityEngine.UI;

public class StageOut : MonoBehaviour
{
    // Score = 0,1,2......
    private int Score;
    // Text型(古いやり方)でテキスト表示
    public Text scoreText;
    // TextMeshProをコード上から取り扱う場合は、TextMeshProUGUI型が必要
    public TMPro.TextMeshProUGUI scoreTextTMP;

    // 4. 加算後の変数 ScoreをDebug.Logでコンソール上に出力する

    // このコードがアタッチされているオブジェクトのisTrigger(コライダー設定)が有効
    // かつ他のオブジェクトがすり抜けた時に中の処理を行うイベント関数
    void OnTriggerEnter(Collider other)
    {
        //  Score = Score + 1;
        Score += 1;
        Debug.Log($"Score:{Score}");
        
        scoreTextTMP.text = $"{Score}";

        // 変数名 otherってなに？
        // A.すり抜けた相手のコライダー情報
        //Debug.Log($"{other.name}がすり抜けました。");
        // Destroy関数
        // Destroy(破棄したいオブジェクト)
        // オブジェクトが使用しているメモリの解放(ガベージコレクション)と描画情報の破棄
        Destroy(other.gameObject);
    }
}
