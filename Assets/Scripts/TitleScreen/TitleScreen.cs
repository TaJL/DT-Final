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

    private void Awake()
    {
        controls = new TheInput();
        controls.TitleScreen.Up.performed += ctx => ActualiceToStartOption();
        controls.TitleScreen.Down.performed += ctx => ActualiceToExitOption();
        controls.TitleScreen.Select.performed += ctx => SelectOption();
        controls.TitleScreen.Enable();

        Cursor.lockState = CursorLockMode.Locked;
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
