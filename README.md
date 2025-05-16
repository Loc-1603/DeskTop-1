using System;
using System.Windows.Forms;

public partial class CheckingAccountForm : Form
{
    private readonly BankAccountService _accountService;
    private readonly BankAccount _account;

    public CheckingAccountForm(BankAccountService accountService, BankAccount account)
    {
        InitializeComponent();
        _accountService = accountService;
        _account = account;
        DisplayAccountInfo();
    }

    private void DisplayAccountInfo()
    {
        lblAccountId.Text = _account.AccountId.ToString();
        lblOwnerName.Text = _account.OwnerName;
        lblBalance.Text = _account.Balance.ToString("C");
    }

    private void btnDeposit_Click(object sender, EventArgs e)
    {
        var depositDialog = new DepositForm();
        if (depositDialog.ShowDialog() == DialogResult.OK)
        {
            double amount = depositDialog.Amount;
            string note = depositDialog.Note;

            try
            {
                if (_accountService.Deposit(_account.AccountId, amount, note))
                {
                    MessageBox.Show("Deposit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayAccountInfo();
                }
                else
                {
                    MessageBox.Show("Invalid deposit amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during deposit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btnDisplayTransactions_Click(object sender, EventArgs e)
    {
        try
        {
            var transactions = _accountService.GetAccountTransactions(_account.AccountId);
            var transactionForm = new TransactionsForm(transactions);
            transactionForm.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error retrieving transactions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
