using CommunityToolkit.Maui.Views;
using System.Windows.Input;

namespace PopupTextField;

public partial class LoginPopup : Popup
{
	public LoginPopup()
	{
		InitializeComponent();
        
		SubmitCmd = new Command<bool>(OnSubmit);

		BindingContext = this;
    }

	private void OnSubmit(bool isValid)
	{
		this.Close();
	}

    public ICommand SubmitCmd { get; private set; }
}