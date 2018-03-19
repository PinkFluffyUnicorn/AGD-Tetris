using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assets.SimpleAndroidNotifications
{
    public class NotificationsHandler : MonoBehaviour
    {
        

       public void SendNotifLivesFull()
        {
            if (PlayerPrefs.GetInt("Lives", 0) == 5 && PlayerPrefs.GetInt("NotifLives", 0) == 1)
            {
                NotificationManager.Send(TimeSpan.FromSeconds(5), "Come back and play !", "Your Lives are full now !", Color.red, NotificationIcon.Heart);
                PlayerPrefs.SetInt("NotifLives", 0);
            }
        }

        public void SendNotifDaily()
        {
            int NotifyDaily = PlayerPrefs.GetInt("NotifDaily", 0);
            if (NotifyDaily != DateTime.Now.DayOfYear && DateTime.Now.TimeOfDay.Minutes > 60 * 10) //Benachrichtigung erst nach 10 Uhr morgens ? 
            {
                NotificationManager.Send(TimeSpan.FromSeconds(5), "Come back and play !", "Get your daily Bonus !", Color.red, NotificationIcon.Bell);
                PlayerPrefs.SetInt("NotifDaily", DateTime.Now.DayOfYear);
            }
        }

        public void SendNotifHighscore()
        {
            NotificationManager.Send(TimeSpan.FromSeconds(5), "Come back and play !", "Someone beat your highscore ! ", Color.red, NotificationIcon.Star);
        }

        public void Update()
        {
            SendNotifDaily();
            SendNotifLivesFull();

        }
    }
}
