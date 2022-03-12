using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;

public class Bildirimler : MonoBehaviour
{
    public void BildirimGonder()
    {
        AndroidNotification bildirim = new AndroidNotification();
        bildirim.Text = "Instagram Emrecds";
        bildirim.Color = Color.cyan;
        bildirim.LargeIcon = "sot";
        AndroidNotificationCenter.SendNotification(bildirim, "Default_Channel");

    }
}
