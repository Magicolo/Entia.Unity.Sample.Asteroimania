using UnityEngine;

public class SpriteAnimator : MonoBehaviour
{
    public float Speed = 5f;
    public SpriteRenderer Renderer;
    public Sprite[] Sprites = { };

    void OnEnable() => Renderer.enabled = true;
    void OnDisable() => Renderer.enabled = false;
    void Update()
    {
        if (Sprites.Length == 0) return;
        var index = Mathf.RoundToInt(Time.time * Speed) % Sprites.Length;
        Renderer.sprite = Sprites[index];
    }

    void Reset() => Renderer = GetComponent<SpriteRenderer>();
}
