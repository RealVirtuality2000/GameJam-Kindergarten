using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonClick2 : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    [SerializeField] private Image img;
    [SerializeField] private Sprite resistence_inc, loot_inc;
    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    private int skill;

    private void OnEnable()
    {
        //skill_1 = GameObject.Find("Player").GetComponent<Skills>().random_skill_1;
        //skill_2 = GameObject.Find("Player").GetComponent<Skills>().random_skill_2;
        skill = GameObject.Find("Player").GetComponent<Skills>().random_skill_3;
        //switch (skill_1)
        //{
        //    case 0:
        //        GetComponent<Image>().color = Color.red;
        //        break;
        //    case 1:
        //        GetComponent<Image>().color = Color.green;
        //        break;
        //}
        //switch (skill_2)
        //{
        //    case 2:
        //        GetComponent<Image>().color = Color.blue;
        //        break;
        //    case 3:
        //        GetComponent<Image>().color = Color.yellow;
        //        break;
        //}
        switch (skill)
        {
            case 4:
                GetComponent<Image>().color = Color.cyan;
                img.sprite = resistence_inc;
                break;
            case 5:
                GetComponent<Image>().color = Color.magenta;
                img.sprite = loot_inc;
                break;
        }
    }

    public void was_clicked()
    {
        Debug.Log(gameObject.name + " clicked!");

        switch (skill)
        {
            case 4:
                GameObject.Find("Player").GetComponent<Skills>().inc_resistence();
                Debug.Log(PlayerStats.resistence);
                break;
            case 5:
                GameObject.Find("Player").GetComponent<Skills>().inc_loot();
                Debug.Log(PlayerStats.luck);
                break;
        }

        gameObject.transform.parent.gameObject.SetActive(false);
        GameStateManager.Instance.SetState(GameState.Gameplay);
    }

}
