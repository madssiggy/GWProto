using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("CanvasScale")]
    public float x = 1200f;
    public float y = 700f;
    public GameObject exit;
    public Exit script;
    public GameObject Player;
    public Player PlayerScript;

    // Use this for initialization
    void Start()
    {
        exit = GameObject.Find("Exit");
        Player = GameObject.Find("player");
        NewMethod();
    }

    private void NewMethod()
    {
        script = exit.GetComponent<Exit>();
        PlayerScript = Player.GetComponent<Player>();
    }


    // Update is called once per frame
    void Update()
    {
        if (script.GetIsTouch()&&script.GetisClear()) {
            CreateText();
        }
    }
    
    void CreateText()
    {



        /// めんどくさいですが
        /// 
        /// 一行ずつ　再生すると　動きがわかります


        /// 
        /// 変数...Canvas
        ///CLass...GameObject
        /// keyword...new
        /// GameObject名...CotomCanvas
        /// 
        /// ゲームオブジェクトを作る 名前はCostomCanvas
        /// 
        /// この時点では　ただの ゲームオブジェクト
        /// 
        GameObject Canvas = new GameObject("CostomCanvas");



        ///変数 ...Canvas
        /// public関数...Addcompnent
        /// Class...Canvas
        /// 
        /// 変数　Canvas のゲームオブジェクトに
        /// Canvas をコンポネート
        /// 
        /// この時点で　Canvas のコンポネートが　一つのみ
        Canvas.AddComponent<Canvas>();


        ///using に UI が　必要
        /// 
        /// 変数...Canvas
        /// public関数...addcompnent
        /// class...Canvasscaler
        /// 
        /// 変数 Canvas のゲームオブジェクトに
        /// 
        /// CanvasScaler をコンポネート

        Canvas.AddComponent<CanvasScaler>();


        /// ここまでは　コンポネートしただけです
        ///
        ///ここからコンポネートされたものの　値など変更
        /// 
        /// class...Canvas,Canvasscaler
        /// 変数...canvas,Canvas
        /// public関数...Getcomponent
        /// 
        /// コンポネートしたCanvas を　操作するために
        /// Canvas を変数に　入れています
        /// 
        /// canvas は ゲームオブジェクとCanvas,CanvasScaler のコンポネートです
        Canvas canvas = Canvas.GetComponent<Canvas>();
        CanvasScaler canvasscaler = Canvas.GetComponent<CanvasScaler>();


        ///　上記で変数として　取得した　Canvas の中身　
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.pixelPerfect = false;
        canvas.sortingOrder = 0;

        /// 0 の場合　display１　
        canvas.targetDisplay = 0;

        ///ここまでが　コンポネートしているCanvas の中身




        /// ここからが　コンポネートしている　Canvasscaler の中身

        canvasscaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;

        canvasscaler.referenceResolution = new Vector2(x, y);

        canvasscaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;

        canvasscaler.matchWidthOrHeight = 0f;

        canvasscaler.referencePixelsPerUnit = 100f;

        ///ここまでがが　Canvas オブジェクト　
        /// GameObject 作って
        /// Canvas とCanvasScaler をコンポネート
        /// 
        /// 二つの　設定項目を　書き込む


        /// 次は　テキスト

        GameObject text = new GameObject("CostomText");

        text.transform.parent = canvas.transform;

        text.AddComponent<Text>();


        Text text変数 = text.GetComponent<Text>();



        RectTransform trans = text.GetComponent<RectTransform>();

        trans.localPosition = new Vector3(0f, 0f, 0f);

        trans.sizeDelta = new Vector2(500f, 500f);


        trans.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));

        trans.localScale = new Vector3(1f, 1f, 1f);






        text変数.text = "HelloWord";


        Font fontfont = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;

        text変数.font = fontfont;

        text変数.fontSize = 100;

        text変数.supportRichText = true;

        text変数.alignment = TextAnchor.LowerCenter;
        text変数.alignment = TextAnchor.MiddleCenter;

        text変数.color = Color.black;



        ///unity スクリプトリファレンス　より

    }
}
