using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ATMController : MonoBehaviour
{
    public TextMeshProUGUI balanceText;
    public TextMeshProUGUI cashText;
    public TMP_InputField amountInput;
    public GameObject popup;

    private int balance = 50000; // �ʱ� �ܾ�
    private int cash = 100000;   // �ʱ� ����

    private void Start()
    {
        popup.SetActive(false); // �˾��� ��Ȱ��ȭ
        UpdateUI();
    }

    public void Deposit()
    {
        int depositAmount = int.Parse(amountInput.text);
        cash -= depositAmount;
        balance += depositAmount;
        UpdateUI();
    }

    public void Withdraw()
    {
        int withdrawAmount = int.Parse(amountInput.text);
        if (balance >= withdrawAmount)
        {
            balance -= withdrawAmount;
            cash += withdrawAmount;
        }
        else
        {
            // �ܾ� ���� �� �˾��� Ȱ��ȭ
            popup.SetActive(true);
        }
        UpdateUI();
    }

    // 10000�� �Ա� ��ư
    public void Deposit10000()
    {
        int depositAmount = 10000;
        cash -= depositAmount;
        balance += depositAmount;
        UpdateUI();
    }

    // 30000�� �Ա� ��ư
    public void Deposit30000()
    {
        int depositAmount = 30000;
        cash -= depositAmount;
        balance += depositAmount;
        UpdateUI();
    }

    // 50000�� �Ա� ��ư
    public void Deposit50000()
    {
        int depositAmount = 50000;
        cash -= depositAmount;
        balance += depositAmount;
        UpdateUI();
    }

    // 10000�� ��� ��ư
    public void Withdraw10000()
    {
        int withdrawAmount = 10000;
        if (balance >= withdrawAmount)
        {
            balance -= withdrawAmount;
            cash += withdrawAmount;
        }
        else
        {
            // �ܾ� ���� �� �˾��� Ȱ��ȭ
            popup.SetActive(true);
        }
        UpdateUI();
    }

    // 30000�� ��� ��ư
    public void Withdraw30000()
    {
        int withdrawAmount = 30000;
        if (balance >= withdrawAmount)
        {
            balance -= withdrawAmount;
            cash += withdrawAmount;
        }
        else
        {
            // �ܾ� ���� �� �˾��� Ȱ��ȭ
            popup.SetActive(true);
        }
        UpdateUI();
    }

    // 50000�� ��� ��ư
    public void Withdraw50000()
    {
        int withdrawAmount = 50000;
        if (balance >= withdrawAmount)
        {
            balance -= withdrawAmount;
            cash += withdrawAmount;
        }
        else
        {
            // �ܾ� ���� �� �˾��� Ȱ��ȭ
            popup.SetActive(true);
        }
        UpdateUI();
    }

    private void UpdateUI()
    {
        balanceText.text = "Bal: " + balance.ToString() + "Won";
        cashText.text = "Cash: " + cash.ToString() + "Won";
        amountInput.text = "";
    }
}






