using System.Windows.Forms;

public partial class SavingAccountForm : Form
{
    public SavingAccountForm(BankAccount account)
    {
        InitializeComponent();
        DisplayAccountInfo(account);
    }

    private void DisplayAccountInfo(BankAccount account)
    {
        lblAccountId.Text = account.AccountId.ToString();
        lblOwnerName.Text = account.OwnerName;
        lblAddress.Text = account.OwnerAdress;
        lblPhone.Text = account.OwnerPhone;
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
