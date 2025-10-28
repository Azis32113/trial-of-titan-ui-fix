using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabIconSystemScript : MonoBehaviour
{
    [System.Serializable]
    public class Tab
    {
        public Button button;
        public GameObject window;
    }

    public Tab[] tabs;

    void Start()
    {
        foreach (var tab in tabs)
        {
            Tab localTab = tab;
            tab.button.onClick.AddListener(() => OnTabClicked(localTab));
        }

        if (tabs.Length > 0)
            OnTabClicked(tabs[0]);
    }

    void OnTabClicked(Tab selectedTab)
    {
        foreach (var tab in tabs)
        {
            tab.window.SetActive(false);
        }

        selectedTab.window.SetActive(true);
    }
}
