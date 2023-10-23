using System;
using UnityEngine;

public class Rupee : MonoBehaviour
{
    public event Action<Rupee> OnCollected;
    public int score = 1;
    private RupeeData _data;
    private SpriteRenderer _spriteRenderer;
    private AudioClip _collectedClip;

    public RupeeData Data{
        get => _data;
        set{
            _data = value;
            score = _data.score;
            _spriteRenderer.color = _data.color;
            _collectedClip = _data.collectClip;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")){
            //Destroy(gameObject);
            OnCollected?.Invoke(this);
        }
    }


    private void Awake() {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
