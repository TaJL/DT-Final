using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using MEC;
using UnityEngine.InputSystem;

public class TitleScreen : MonoBehaviour
{
    private enum Options { Start, Exit}
    private Options optionActual = Options.Start;
    [SerializeField] private float SelectedFontSize = 150;
    [SerializeField] private TextMeshProUGUI startText;
    [SerializeField] private TextMeshProUGUI exitText;
    TheInput controls;

    [SerializeField] private TextMeshProUGUI FinaleCount;
    [SerializeField] private TextMeshProUGUI FinaleList;

    private void Awake()
    {
        controls = new TheInput();
        controls.TitleScreen.Up.performed += ctx => ActualiceToStartOption();
        controls.TitleScreen.Down.performed += ctx => ActualiceToExitOption();
        controls.TitleScreen.Select.performed += ctx => SelectOption();
        controls.TitleScreen.Enable();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        SetFinalText();
    }

    private void SetFinalText()
    {
        FinaleList.text = "";
        int finalsCount = 0;

        if (FinaleCountHandler.Instance.balance)
        {
            finalsCount++;
            FinaleList.text += "Balance";
        }

        if (FinaleCountHandler.Instance.maldad)
        {
            finalsCount++;
            if (FinaleList.text != "")
            {
                FinaleList.text += " - ";
            }
            FinaleList.text += "Maldad";
        }

        if (FinaleCountHandler.Instance.moralRota)
        {
            finalsCount++;
            if (FinaleList.text != "")
            {
                FinaleList.text += " - ";
            }
            FinaleList.text += "Moral Rota";
        }

        if (finalsCount != 0)
        {
            FinaleCount.text = "Finales: " + finalsCount.ToString() + "/3";
        }
        else
            FinaleCount.enabled = false;
    }

    private void ActualiceToStartOption()
    {
        ActualiceOption(Options.Start);
    }

    private void ActualiceToExitOption()
    {
        ActualiceOption(Options.Exit);
    }

    private void ActualiceOption(Options newOption)
    {
        optionActual = newOption;
        Timing.KillCoroutines();
        Timing.RunCoroutine(_SettingFontSizes());
    }

    IEnumerator<float> _SettingFontSizes()
    {
        TextMeshProUGUI selectedText;
        TextMeshProUGUI nonSelectedText;
        if (optionActual == Options.Start)
        {
            selectedText = startText;
            nonSelectedText = exitText;
        }
        else
        {
            selectedText = exitText;
            nonSelectedText = startText;
        }

        while (selectedText.fontSize < SelectedFontSize)
        {
            selectedText.fontSize++;
            nonSelectedText.fontSize--;
            yield return Timing.WaitForOneFrame;
        }
    }

    public void EnterGame()
    {
        SceneManager.LoadScene(1);

    }

    public void QuitGame()
    {
        Application.Quit();

    }
    private void SelectOption()
    {
        if (optionActual == Options.Start)
        {
            controls.TitleScreen.Disable();
            SceneManager.LoadScene(1);
        }
        else
        {
            Application.Quit();
        }
    }
}
