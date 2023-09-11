using Ej01.App.ViewModels;

namespace Ej01.App
{
    public partial class MainView : Form
    {
        private readonly PersonViewModel _personViewModel;
        public MainView()
        {
            InitializeComponent();
            this._personViewModel = new PersonViewModel();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            _personViewModel.SetDocumentNumber(txtDocNumber.Text);
            _personViewModel.SetFirstName(txtFirstName.Text);
            _personViewModel.SetLastName(txtLastName.Text);
            _personViewModel.SetBirthDate(fchBirthDate.Value);

            _personViewModel.Validate();
        }

        private void btnCleanFields_Click(object sender, EventArgs e)
        {
            txtDocNumber.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            fchBirthDate.Value = DateTime.Today;
        }
    }
}