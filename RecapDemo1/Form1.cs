namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDamaBoard();


            //for(int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        CreateButton(i,j);
            //    }
            //}
        }

        private void CreateDamaBoard()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1) + 1; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    left += 50;
                    this.Controls.Add(buttons[i, j]);
                }
                left = 0;
                top += 50;
            }
        }

        private void CreateButton(int raw, int column)
        {
            Button button = new Button();
            button.Width = 50;
            button.Height = 50;
            button.Location = new Point(raw*50, column*50);
            button.Text = "OK";
            this.Controls.Add(button);
        }
    }
}