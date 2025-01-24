using UnityEngine;

public class Money : MonoBehaviour
{
    private SpriteRenderer spriteRender;
    private Animator animator;

    [HideInInspector]
    public bool active;

    private void Awake()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    public void SetOn()
    {
        active = true;
        spriteRender.color = Random.ColorHSV();
        spriteRender.enabled = true;
        animator.enabled = true;
        animator.Play(0, 0);
        SpawnMoney();
    }

    public void SetOff()
    {
        active = false;
        spriteRender.enabled = false;
        animator.enabled = false;
    }

    public void SpawnMoney()
    {
        float rndX = Random.Range(GetXPoints().x, GetXPoints().y);
        float rndY = Random.Range(GetYPoints().x, GetYPoints().y);

        transform.localPosition = new Vector3(rndX, rndY);
    }


    private Vector2 GetSpriteBound()
    {
        return new Vector2(spriteRender.bounds.size.x, spriteRender.bounds.size.y);
    }

    private Vector2 GetXPoints()
    {
        return new Vector2
        (SystemSettings.minPointX + GetSpriteBound().x / 2, SystemSettings.maxPointX - GetSpriteBound().x / 2);
    }

    private Vector2 GetYPoints()
    {
        return new Vector2
        (SystemSettings.minPointY + GetSpriteBound().y / 2, SystemSettings.maxPointY - GetSpriteBound().y / 2);
    }
}
