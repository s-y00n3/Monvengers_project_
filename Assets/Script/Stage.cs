using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stage : MonoBehaviour {
    public Button stageBtn;
    public static int stageNum;
    public static int level;

    void Start ()
    {
        stageBtn.onClick.AddListener(ChangeScence);
    }
	
	void ChangeScence()
    {
        DontDestroyOnLoad(this);
        switch (stageBtn.tag)
        {
            case "stage1": stageNum = 1; level = 1700; break;
            case "stage2": stageNum = 2; level = 1600; break;
            case "stage3": stageNum = 3; level = 1500; break;
            case "stage4": stageNum = 4; level = 1400; break;
            case "stage5": stageNum = 5; level = 1300; break;
            case "stage6": stageNum = 6; level = 1200; break;
            case "stage7": stageNum = 7; level = 1100; break;
            case "stage8": stageNum = 8; level = 1000; break;
            case "stage9": stageNum = 9; level = 900; break;
        }
        SceneManager.LoadScene(2);
    }
}
