using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    [SerializeField] private Image img;
    [SerializeField] private Sprite hp_inc, reg_inc;
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
        skill = GameObject.Find("Player").GetComponent<Skills>().random_skill_1;
        //skill_2 = GameObject.Find("Player").GetComponent<Skills>().random_skill_2;
        //skill_3 = GameObject.Find("Player").GetComponent<Skills>().random_skill_3;
        switch (skill)
        {
            case 0:
                GetComponent<Image>().color = Color.red;
                img.sprite = hp_inc;
                break;
            case 1:
                GetComponent<Image>().color = Color.green;
                img.sprite = reg_inc;
                break;
        }
        //switch (skill_2)
        //{
        //    case 2:
        //        GetComponent<Image>().color = Color.blue;
        //        break;
        //    case 3:
        //        GetComponent<Image>().color = Color.yellow;
        //        break;
        //}
        //switch (skill_3)
        //{
        //    case 4:
        //        GetComponent<Image>().color = Color.cyan;
        //        break;
        //    case 5:
        //        GetComponent<Image>().color = Color.magenta;
        //        break;
        //}
    }

    public void was_clicked()
    {
        Debug.Log(gameObject.name + " clicked!");

        switch (skill)
        {
            case 0:
                GameObject.Find("Player").GetComponent<Skills>().inc_max_lifepoints();
                Debug.Log(PlayerStats.max_lifepoints);
                break;
            case 1:
                GameObject.Find("Player").GetComponent<Skills>().inc_life_regeneration();
                Debug.Log(PlayerStats.life_regeneration);
                break;
        }

        gameObject.transform.parent.gameObject.SetActive(false);
        GameStateManager.Instance.SetState(GameState.Gameplay);
    }

}
