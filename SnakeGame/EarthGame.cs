using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SnakeGame
{
    public partial class EarthGame : Form
    {
        public EarthGame()
        {
            InitializeComponent();
        }

        private char move = 'r';
        private bool is_food = true;
        private PictureBox food;
        private Random rnd = new Random();
        private Point point_help = new Point(0, 0);

        class Snake
        {

            public Snake(EarthGame form, PictureBox picture)
            {
                Snake.size++;
                this.number = Snake.size;
                this.picture = picture;
                this.form = form;
                form.Controls.Add(picture);
            }

            public void delete_snake()
            {
                Snake.size = 1;
                this.move = ' ';

                if (this.next_snake != null)
                {
                    this.next_snake.delete_snake();
                    this.next_snake = null;
                }

                if(this.number != 1)
                    this.form.Controls.Remove(this.picture);
            }

            public void move_up()
            {
                if (this.move_check('u') == false)
                    return;

                this.form.point_help.X = this.picture.Location.X;
                this.form.point_help.Y = this.picture.Location.Y-16;

                if (this.number == 1)
                {
                    if (this.picture.Top < 0 || this.check_collision(this.form.point_help))
                    {
                        this.form.move = ' ';
                        this.gameOver();
                        return;
                    }

                    if (this.form.food.Visible && this.form.food.Location == this.form.point_help)
                    {
                        this.form.is_food = false;
                        this.form.food.Visible = false;
                        this.snake_add();
                    }
                }

                this.picture.Location = this.form.point_help;

                this.move_next();
                this.move = 'u';
            }
            public void move_right()
            {
                if (this.move_check('r') == false)
                    return ;

                this.form.point_help.X = this.picture.Location.X+16;
                this.form.point_help.Y = this.picture.Location.Y;
                if (this.number == 1)
                {
                    if (this.picture.Right > this.form.Width-16 || this.check_collision(this.form.point_help))
                    {
                        this.form.move = ' ';
                        this.gameOver();
                        return;
                    }

                    if (this.form.food.Visible && this.form.food.Location == this.form.point_help)
                    {
                        this.form.is_food = false;
                        this.form.food.Visible = false;
                        this.snake_add();
                    }
                }

                this.picture.Location = this.form.point_help;

                this.move_next();
                this.move = 'r';
            }
            public void move_down()
            {
                if (this.move_check('d') == false)
                    return ;

                this.form.point_help.X = this.picture.Location.X;
                this.form.point_help.Y = this.picture.Location.Y+16;
                if (this.number == 1)
                {
                    if (this.picture.Bottom > this.form.Height-30 || this.check_collision(this.form.point_help))
                    {
                        this.form.move = ' ';
                        this.gameOver();
                        return;
                    }

                    if (this.form.food.Visible && this.form.food.Location == this.form.point_help)
                    {
                        this.form.is_food = false;
                        this.form.food.Visible = false;
                        this.snake_add();
                    }
                }

                this.picture.Location = this.form.point_help;

                this.move_next();
                this.move = 'd';
            }
            public void move_left()
            {
                if (this.move_check('l') == false)
                    return ;

                this.form.point_help.X = this.picture.Location.X-16;
                this.form.point_help.Y = this.picture.Location.Y;
                if (this.number == 1)
                {
                    if (this.picture.Left < 0 || this.check_collision(this.form.point_help))
                    {
                        this.form.move = ' ';
                        this.gameOver();
                        return ;
                    }
                    
                    if (this.form.food.Visible && this.form.food.Location == this.form.point_help)
                    {
                        this.snake_add();
                        this.form.is_food = false;
                        this.form.food.Visible = false;
                    }
                }

                this.picture.Location = this.form.point_help;

                this.move_next();
                this.move = 'l';
            }

            private void move_next()
            {
                if (this.next_snake != null)
                    switch (this.move)
                    {
                        case 'u': this.next_snake.move_up(); break;
                        case 'r': this.next_snake.move_right(); break;
                        case 'd': this.next_snake.move_down(); break;
                        case 'l': this.next_snake.move_left(); break;
                    }
            }

            public void snake_add()
            {
                if (this.next_snake == null)
                {
                    
                    int x = 0;
                    int y = 0;

                    switch (this.move)
                    {
                        case 'u': y += 16; break;
                        case 'r': x -= 16; break;
                        case 'd': y -= 16; break;
                        case 'l': x += 16; break;
                    }
                    Point point = new Point(this.picture.Location.X+x, this.picture.Location.Y+y);

                    var picture = new PictureBox
                    {
                        Name = "Snake",
                        Size = new Size(16, 16),
                        Location = point,
                        Image = Image.FromFile("../../Resources/body_snake.jpg"),
                    };
                    Snake snake = new Snake(this.form, picture);
                    this.next_snake = snake;
                }
                else
                    this.next_snake.snake_add();
            }

            private bool move_check(char move)
            {
                if (move == 'r' && this.move == 'l')
                {
                    this.move_left();
                    return false;
                }
                else if (move == 'l' && this.move == 'r')
                {
                    this.move_right();
                    return false;
                }
                else if (move == 'u' && this.move == 'd')
                {
                    this.move_down();
                    return false;
                }
                else if (move == 'd' && this.move == 'u')
                {
                    this.move_up();
                    return false;
                }

                return true;
            }

            public bool check_collision(Point point)
            {
                if(point == this.picture.Location)
                    return true;
                else if(this.next_snake != null)
                    if(this.next_snake.check_collision(point))
                        return true;

                return false;
            }

            public void gameOver()
            {
                string text = "You Lose!!, score = ";
                text += (Snake.size - 1).ToString();
                text += "\n\nDo you want to Exit?";
                DialogResult result = MessageBox.Show(text, "lose", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                    this.form.Close();
                else
                {
                    this.delete_snake();

                    this.form.point_help.X = 0;
                    this.form.point_help.Y = 0;
                    this.form.move = ' ';
                    this.picture.Location = this.form.point_help;
                }
            }

            private char move = ' ';
            private EarthGame form;
            private PictureBox picture;
            private Snake next_snake = null;
            private int number = 0;
            static int size = 0;
        }

        private Snake snake = null;

        private void EarthGame_Load(object sender, EventArgs e)
        {
            var picture = new PictureBox
            {
                Name = "Snake",
                Size = new Size(16, 16),
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(0, 0),
                Image = Image.FromFile("../../Resources/head_snake.jpg"),
            };
            this.snake = new Snake(this, picture);

            var food = new PictureBox
            {
                Name = "Snake",
                Size = new Size(20, 20),
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(96, 96),
                Image = Image.FromFile("../../Resources/food.png"),
            };
            this.food = food;
            this.food.Visible = true;
            this.Controls.Add(food);

            timer1.Enabled = true;
        }

        private void EarthGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Up: this.move = 'u'; break;
                case Keys.Right: this.move = 'r'; break;
                case Keys.Down: this.move = 'd'; break;
                case Keys.Left: this.move = 'l'; break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.is_food == false)
            {
               // Point point = new Point(0, 0);
                int x, y;

                do
                {
                    x = (this.rnd.Next(this.Width-50)/16) * 16;
                    y = (this.rnd.Next(this.Height-50)/16) * 16;
                    this.point_help.X = x;
                    this.point_help.Y = y;
                } while (this.snake.check_collision(this.point_help));


                this.food.Location = this.point_help;
                this.is_food = true;
                this.food.Visible = true;
            }

            switch (this.move)
            {
                case 'u': this.snake.move_up(); break;
                case 'r': this.snake.move_right(); break;
                case 'd': this.snake.move_down(); break;
                case 'l': this.snake.move_left(); break;
            }
        }
    }
}
