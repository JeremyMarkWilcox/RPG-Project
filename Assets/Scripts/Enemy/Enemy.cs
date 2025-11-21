using UnityEngine;

public class Enemy : MonoBehaviour
{
   private SpriteRenderer sr;
   [SerializeField] float redColorDuration = 1f;
   public float currentTimeInGame;
   public float timeSinceHit;
   
   private void Awake()
   {
      sr = GetComponent<SpriteRenderer>();
   }

   private void Update()
   {
      ChangeColorIfNeeded();
   }

   private void ChangeColorIfNeeded()
   {
      currentTimeInGame = Time.time;
      if (currentTimeInGame > timeSinceHit + redColorDuration)
      {
         if(sr.color != Color.white)
            TurnWhite();
      }
   }

   public void TakeDamage()
   {
      sr.color = Color.red;
      timeSinceHit = currentTimeInGame;
   }
   
   public void TurnWhite()
   {
      sr.color = Color.white;
   }
}
