using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
    
public class PlayerCtrl : MonoBehaviour
{
    Transform playerTransform;
    Animator anim;
    Vector3 moveDir;

    [SerializeField]
    float moveSpeed = 5f;

    void Start()
    {
        playerTransform = GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     if(moveDir!=Vector3.zero)
        {
            playerTransform.rotation = Quaternion.LookRotation(moveDir);
            playerTransform.Translate(Vector3.forward);
        }
    }

    #region SEND_MESSAGE
  public  void OnMove(InputValue value)
    {
        Vector2 dir = value.Get<Vector2>();
        moveDir = new Vector3(dir.x, 0, dir.y);

        anim.SetFloat("Movement",dir.magnitude);
    }

   public void OnAttack()
    {
        anim.SetTrigger("Attack");
    }
    #endregion // SEND_MESSAGE

    #region UNITY_EVENTS
    public void OnMove(InputAction.CallbackContext ctx)
    {
        Vector2 dir =ctx.ReadValue<Vector2>();
        moveDir =new Vector3 (dir.x, 0, dir.y);

        anim.SetFloat("Movement", dir.magnitude);
    }
    public void OnAttack(InputAction.CallbackContext ctx)
    {
        if(ctx.performed)
        {
            anim.SetTrigger("Attack");
        }
    }
    #endregion // UNITY_EVENTS
}
