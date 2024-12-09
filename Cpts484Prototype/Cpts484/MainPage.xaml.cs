namespace Cpts484;

public partial class MainPage : ContentPage
{
	string fname = string.Empty;
	string lname = string.Empty;
	string email = string.Empty;
	string phonenumber = string.Empty;


	public MainPage()
	{
		InitializeComponent();
		SetCaretaker();
	}

	private void OnCaretakerSave(object sender, EventArgs e)
	{
		this.fname = CaretakerFname.Text;
        this.lname = CaretakerLname.Text;
        this.email = CaretakerEmail.Text;
        this.fname = CaretakerPhone.Text;
    }

	private void SetCaretaker()
	{
        CaretakerFname.Text = this.fname;
        CaretakerLname.Text = this.lname;
        CaretakerEmail.Text = this.email;
        CaretakerPhone.Text = this.phonenumber;

    }

	private async void OnSwitchViews(object sender, EventArgs e)
	{
		await SwitchViews();
	}

	async Task SwitchViews()
	{
		await Shell.Current.GoToAsync(nameof(NavigationPage));
	}


}

