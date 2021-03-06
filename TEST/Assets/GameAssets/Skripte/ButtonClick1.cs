using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonClick1 : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    
    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    private int skill;


    public void was_clicked()
    {
        skill =GameObject.FindWithTag("SkillCanvas").GetComponent<Skills>().random_skill_2;
        Debug.Log(gameObject.name + " clicked!");
        Debug.Log(skill + "ausgewählt");

        switch (skill)
        {
            case 2:
                GameObject.FindWithTag("SkillCanvas").GetComponent<Skills>().inc_weapon_damage();
                Debug.Log("inc weapon damage");
                break;
            case 3:
                GameObject.FindWithTag("SkillCanvas").GetComponent<Skills>().inc_resistance();
                Debug.Log("inc resistance");
                break;
        }

        gameObject.transform.parent.gameObject.SetActive(false);
        GameStateManager.Instance.SetState(GameState.Gameplay);
    }

}
