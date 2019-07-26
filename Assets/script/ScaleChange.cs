using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    private float NowScale = 1.0f;
    [SerializeField] private float ScaleChangeRate = 0.01f;
    [SerializeField] private KeyCode ScaleUpKey = KeyCode.UpArrow;
    [SerializeField] private KeyCode ScaleDownKey = KeyCode.DownArrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(ScaleUpKey)) {
            NowScale += ScaleChangeRate * Time.deltaTime;
        }
        if(Input.GetKey(ScaleDownKey)){
            NowScale -= ScaleChangeRate * Time.deltaTime;
        }

        NowScale = Mathf.Clamp(NowScale,0.0f,10.0f); //大きさに制限を付ける0~10

        this.transform.localScale = new Vector3(NowScale,NowScale,NowScale);
        
    }
}
