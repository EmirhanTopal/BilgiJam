using UnityEngine;

public class BubbleShooter : MonoBehaviour
{
    public ParticleSystem bubbleParticle; // Bubble Particle System'ini bağlamak için
    public int maxShots = 3; // Toplam atış hakkı
    private int currentShots = 0; // Kullanılan atış hakkı
    [SerializeField] private GameObject[] _gameObjects = new GameObject[3];

    private int i = 0;
    void Update()
    {
        // Space tuşuna basıldığında ve atış hakkı varsa
        if (Input.GetKeyDown(KeyCode.Space) && currentShots < maxShots)
        {
            bubbleParticle.Play(); // Bubble'ı ateşle
            currentShots++; // Atış sayısını artır
            _gameObjects[i].SetActive(false);
            i++;
        }
    }
}