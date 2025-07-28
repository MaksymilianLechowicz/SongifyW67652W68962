
using Songify.Storage;
using System.Runtime.InteropServices;
using Songify.Functionality.Dto;
using Songify.Functionality.Services;
using Songify.Storage.Entities;
namespace Songify
{
    public partial class Songify : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );
        public MusicOpener MO1 = new MusicOpener();
        private readonly UserService _userService;
        private readonly SongifyDbContext _dbContext;
        public Songify()
        {
            InitializeComponent();
            _dbContext = new SongifyDbContext();
            _userService = new UserService(_dbContext);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = rjTextBox2.Texts.Trim();
            string password = rjTextBox1.Texts.Trim();
           /* if ( username != null && password != null )
            {
                MO1.ShowDialog();
            }*/

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Uzupe³nij dane");
                return;
            }

            var loginRequest = new LoginRequest
            {
                Username = username,
                Password = password
            };

            try
            {
                User loggedUser = _userService.Login(loginRequest);
                if (loggedUser != null)
                {
                    MessageBox.Show("Zalogowano");
                    MO1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Niepoprawne dane logowania.");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"B³¹d logowania: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wyst¹pi³ b³¹d logowania {ex.Message}");
            }
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Songify_Load(object sender, EventArgs e)
        {
            LoginButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LoginButton.Width, LoginButton.Height, 30, 30));
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
