using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour{

    public static int ActiveQuestNumber;
    public int InternalQuestNumber;

    void Update(){
        InternalQuestNumber = ActiveQuestNumber;      
    }

}
