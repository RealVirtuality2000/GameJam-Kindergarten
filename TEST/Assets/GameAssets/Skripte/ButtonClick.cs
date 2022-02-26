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

    public void was_clicked()
    {
        
        Debug.Log(gameObject.name + " clicked!");

        switch (skill)
        {
            case 0:
                GameObject.FindWithTag("SkillCanvas").GetComponent<Skills>().inc_max_lifepoints();
                Debug.Log("inc weapon damage");
                break;
            case 1:
                GameObject.FindWithTag("SkillCanvas").GetComponent<Skills>().inc_life_regeneration();
                Debug.Log("inc resistance");
                break;
        }

        gameObject.transform.parent.gameObject.SetActive(false);
        GameStateManager.Instance.SetState(GameState.Gameplay);
    }

}
