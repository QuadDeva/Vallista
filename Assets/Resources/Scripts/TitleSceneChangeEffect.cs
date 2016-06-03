﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace ParkJunHo
{
    public class TitleSceneChangeEffect : MonoBehaviour
    {
        private float speed = 0.02f;
        private Image logo = null;
        private Image button = null;
        private Text text = null;

        void Start()
        {
            logo = GameObject.Find("Logo").GetComponent<Image>();
            button = GameObject.Find("Button").GetComponent<Image>();
            text = GameObject.FindObjectOfType<Text>();
        }

        public void StartEffect()
        {
            StartCoroutine(EffectCoroutine());
        }

        private IEnumerator EffectCoroutine()
        {
            while(true)
            {
                Color cor = logo.color;
                cor.a -= speed * Time.smoothDeltaTime * 62.5f;
                logo.color = cor;

                cor = button.color;
                cor.a -= speed * Time.smoothDeltaTime * 62.5f;
                button.color = cor;

                cor = text.color;
                cor.a -= speed * Time.smoothDeltaTime * 62.5f;
                text.color = cor;

                if(cor.a <= 0)
                {
                    SceneChanger changer = new GameObject("Changer", new System.Type[] { typeof(SceneChanger) }).GetComponent<SceneChanger>();

                    if (PlayerPrefs.GetInt("IsPlayed", 0) != 0)
                    {
                        //PlayerPrefs.SetInt("IsPlayed", 1);
                        changer.Level = 2;
                        break;
                    }
                    else
                    {
                        changer.Level = 3;
                        break;
                    }
                }

                yield return null;
            }
        }
    }
}
