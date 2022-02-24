using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonClick1 : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    [SerializeField] private Image img;
    [SerializeField] private Sprite weapon_dmg_inc, ability_dmg_inc;
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
        skill = GameObject.Find("Player").GetComponent<Skills>().random_skill_2;
        //skill_3 = GameObject.Find("Player").GetComponent<Skills>().random_skill_3;
        //switch (skill_1)
        //{
        //    case 0:
        //        GetComponent<Image>().color = Color.red;
        //        break;
        //    case 1:
        //        GetComponent<Image>().color = Color.green;
        //        break;
        //}
        switch (skill)
        {
            case 2:
                GetComponent<Image>().color = Color.blue;
                img.sprite = weapon_dmg_inc;
                break;
            case 3:
                GetComponent<Image>().color = Color.yellow;
                img.sprite = ability_dmg_inc;
                break;
        }
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
                GameObject.Find("Player").GetComponent<Skills>().inc_weapon_damage();
                Debug.Log(PlayerStats.weapon_damage);
                break;
            case 1:
                GameObject.Find("Player").GetComponent<Skills>().inc_ability_damage();
                Debug.Log(PlayerStats.ability_damage);
                break;
        }

        gameObject.transform.parent.gameObject.SetActive(false);
        GameStateManager.Instance.SetState(GameState.Gameplay);
    }

}
