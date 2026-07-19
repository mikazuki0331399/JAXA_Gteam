using DS.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTextAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var transFormCache = transform;
        // 終点としての初期位置
        var defaultPosition = transFormCache.localPosition;
        //上に持ってくる処理
        transFormCache.localPosition = new Vector3(0, 300f);
        //アニメーション開始処理
        transFormCache.DOLocalMove(defaultPosition, 1f)
            .SetEase(Ease.Linear)
            .OnComplete(() =>
            {
                Debug.Log("GameOver!");
                // シェイクアニメーション
                transFormCache.DOShakePosition(1.5f, 100);
            });
        DOVirtual.DelayedCall(10f, () =>
        {
            // 3秒後にシーンをリロード
            SceneManager.LoadScene("TitleScene");
        });
    }
}
