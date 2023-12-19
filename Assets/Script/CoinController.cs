using UnityEngine;

public class CoinController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Перевірка, чи торкається інший об'єкт (в даному випадку, огр)
        if (other.CompareTag("Ogre"))
        {
            // Запуск функції для зникнення монети
            CollectCoin();
        }
    }

    private void CollectCoin()
    {
        // Здійсніть будь-які дії, які повинні відбутися при зборі монети
        // Наприклад, приховання або знищення об'єкта
        gameObject.SetActive(false);
        // або
        // Destroy(gameObject);
    }
}
