using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
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
        skill = GameObject.FindWithTag("SkillCanvas").GetComponent<Skills>().random_skill_1;
        Debug.Log(gameObject.name + " clicked!");

        switch (skill)
        {
            case 0:
                GameObject.FindWithTag("SkillCanvas").GetComponent<Skills>().inc_max_lifepoints();
                Debug.Log("inc max life");
                break;
            case 1:
                GameObject.FindWithTag("SkillCanvas").GetComponent<Skills>().inc_life_regeneration();
                Debug.Log("inc life regeneration");
                break;
        }

        gameObject.transform.parent.gameObject.SetActive(false);
        GameStateManager.Instance.SetState(GameState.Gameplay);
    }

}
