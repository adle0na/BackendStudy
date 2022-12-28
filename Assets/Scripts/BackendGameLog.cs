using System.Collections.Generic;
using System.Text;
using UnityEngine;
using BackEnd;

public class BackendGameLog
{
    private static BackendGameLog _instance = null;

    public static BackendGameLog Instance {
        get {
            if (_instance == null) {
                _instance = new BackendGameLog();
            }

            return _instance;
        }
    }

    public void GameLogInsert() {
        // 게임 데이터 로직 삽입
        Param param = new Param();

        param.Add("clearStage", 1);
        param.Add("currentMoney", 100000);

        Debug.Log("게임로그 삽입을 시도합니다.");

        var bro = Backend.GameLog.InsertLog("ClearStage", param);

        if (bro.IsSuccess() == false) {
            Debug.LogError("게임로그 삽입 중 에러가 발생했습니다. : " + bro);
            return;
        }

        Debug.Log("게임로그 삽입에 성공했습니다. : " + bro);
    }
}
