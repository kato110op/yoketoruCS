using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;

namespace yoketoruCS
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        //�񋓎q(enum)
        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear,
        }

        State nextState = State.Title;
        State currentState = State.None;

        int score;
        int timer;
        int hightScore = 100;
        int StartTimer => 200;
        const int CStartTimer = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeState();
            UpdateState();
        }

        void ChangeState()
        {
            if (nextState == State.None) return;

            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    labelTitle.Visible = true;
                    buttonStart.Visible = true;
                    labelGameover.Visible = false;
                    buttonTitle.Visible = false;
                    labelClear.Visible = false;
                    labelHighScore.Visible = true;
                    tempPlayer.Visible = false;
                    tempObstacle.Visible = false;
                    tempItem.Visible = false;
                    labelCopyright.Visible = true;
                    break;

                case State.Game:
                    labelTitle.Visible = false;
                    buttonStart.Visible = false;
                    labelHighScore.Visible = false;
                    labelCopyright.Visible = false;
                    break;

                case State.Gameover:
                    labelGameover.Visible = true;
                    buttonTitle.Visible = true;
                    labelHighScore.Visible = true;
                    break;

                case State.Clear:
                    labelClear.Visible = true;
                    buttonTitle.Visible = true;
                    labelHighScore.Visible = true;
                    break;
            }
        }
        void UpdateState()
        {
            switch (currentState)
            {
                case State.Game:
                    UpdateGame();
                    break;
            }
        }

        void UpdateGame()
        {
            if (GetAsyncKeyState((int)Keys.O) < 0)
            {
                nextState = State.Gameover;
            }
            if (GetAsyncKeyState((int)Keys.C) < 0)
            {
                nextState = State.Clear;

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void buttonTitle_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}