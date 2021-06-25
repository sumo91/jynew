/*
 * 金庸群侠传3D重制版
 * https://github.com/jynew/jynew
 *
 * 这是本开源项目文件头，所有代码均使用MIT协议。
 * 但游戏内资源和第三方插件、dll等请仔细阅读LICENSE相关授权协议文档。
 *
 * 金庸先生老先生千古！
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Jyx2
{
    public class Jyx2InteractiveButton
    {
        static public void Show(string text, Action callback)
        {
            var btn = GetInteractiveButton();
            if(btn != null)
            {
                btn.GetComponentInChildren<Text>().text = text;
                btn.gameObject.SetActive(true);
                btn.onClick.RemoveAllListeners();
                btn.onClick.AddListener(() => { callback(); });
                btn.transform.Find("FocusImage").gameObject.SetActive(true);
            }
        }

        static public void Hide()
        {
            var btn = GetInteractiveButton();
            if(btn != null)
            {
                btn.gameObject.SetActive(false);
            }
        }

        static Button GetInteractiveButton()
        {
            var root = GameObject.Find("LevelMaster/UI");
            var btn = root.transform.Find("InteractiveButton").GetComponent<Button>();
            return btn;
        }
    }
}
