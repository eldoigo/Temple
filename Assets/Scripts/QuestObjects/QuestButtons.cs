using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestButtons : MonoBehaviour{

    public GameObject ThePlayer;
    public GameObject NoticeCam;
    public GameObject QuestPanel;
    public GameObject KeyQuestBox;
    public GameObject RedKey;
    public GameObject GreenKey;
    public GameObject BlueKey;
    public GameObject KeysUI;
    public GameObject UIQuest;
    public GameObject KeyQuestTrigger;
    public GameObject InteractionCharacter;
    public GameObject QuestNotification01;
    public GameObject scroll;
    public GameObject BoardScroll;


    public void AcceptButton (){

        NoticeCam.SetActive(false);
        QuestPanel.SetActive(false);
        UIQuest.SetActive(false);
        StartCoroutine(KeyQuestUI ());
    }

    IEnumerator KeyQuestUI() {
        KeyQuestBox.GetComponent<Text>().text = "The Magical Three Keys";
        RedKey.GetComponent<Text>().text = "The Elven Red Key";
        GreenKey.GetComponent<Text>().text = "The Mythic Green Key";
        BlueKey.GetComponent<Text>().text = "The Forbidden Blue Key";
        yield return new WaitForSeconds(0.5f);
        KeyQuestBox.SetActive(true);
        yield return new WaitForSeconds(1);
        RedKey.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        GreenKey.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        BlueKey.SetActive(true);
        yield return new WaitForSeconds(8);
        QuestPanel.SetActive(false);
        RedKey.SetActive(false);
        GreenKey.SetActive(false);
        BlueKey.SetActive(false);
        KeysUI.SetActive(true);
        KeyQuestTrigger.SetActive(false);
        InteractionCharacter.SetActive(false);
        QuestNotification01.SetActive(false);
        scroll.SetActive(false);
        BoardScroll.SetActive(false);
        ThePlayer.SetActive(true);
    }

    public void DeclineButton(){
        NoticeCam.SetActive(false);
        QuestPanel.SetActive(false);
        UIQuest.SetActive(false);
        ThePlayer.SetActive(true);
    }


}
