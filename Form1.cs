using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SystemProgrammingLaba3
{
    public partial class Form1 : Form
    {
        /*1.	Двухмерный массив заполнить случайными значениями в 
         * диапазоне от 20 до 40. Необходимо отсортировать методом 
         * вставки нечетные столбцы по возрастанию. Количество столбцов 
         * должно быть кратно 4.*/
        public int rows, column;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox3.Text = "";
            textBox4.Text = "";
            int N; //Число потоков
            try
            {
                N = Convert.ToInt32(textBox5.Text);
                while (N <= 0)
                {
                    N++;
                    MessageBox.Show($"Введено неверное количество потоков. Будет принято значение {N}");
                }
            }
            catch { N = 4; }

            try { rows = Convert.ToInt32(textBox1.Text); } catch { rows = 8; }

            try
            {
                column = Convert.ToInt32(textBox2.Text);
                if (column % 4 != 0)
                {
                    while (column % 4 != 0) column++;
                    MessageBox.Show($"Количество столбцов не кратно четырем, будет взято значение {column}");
                }
            }
            catch { column = 8; }
            DateTime dtNow = DateTime.Now;
            string sr = "";
            int[,] array = new int[rows, column];

            int dN = column / N;
            List<int[]> resultList = new List<int[]>();
            String st = "";

            textBox3.Text += "Init" + "\r\n";
            ParallelAndTasksClass patc = new ParallelAndTasksClass();
            patc.ParallelFunc(N, dN, column, rows, array);
            //Parallel.For(1, N + 1, new ParallelOptions { MaxDegreeOfParallelism = N }, id =>
            //{
            //    int beg; int end;
            //    beg = (id - 1) * dN;
            //    if (id == N)
            //    {
            //        end = column;
            //    }
            //    else
            //    {
            //        end = id * dN;
            //    }
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < column; j++)
            //        {
            //            array[i, j] = rnd.Next(20, 41);
            //        }
            //    }
            //});
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sr += Convert.ToString(array[i, j]) + "  ";
                }
                sr += "\r\n";
            }
            if (column > 20 || rows > 20)
            {
                string path = @"C:\Users\Sssof\source\repos\Labacsharp1.1\neItogLaba3.txt";
                SaveToFile(sr, column, rows, path);
            }
            else
            {
                textBox3.Text = sr;
            }

            textBox4.Text = "Time: " + (DateTime.Now - dtNow).ToString() + "\r\n";
            textBox4.Text += "Start" + "\r\n";

            Parallel.For(1, N + 1, new ParallelOptions { MaxDegreeOfParallelism = N }, id =>
            {
                int beg; int end;
                beg = (id - 1) * dN;
                if (id == N)
                {
                    end = column;
                }
                else
                {
                    end = id * dN;
                }
                InsertionSortColumn(array, beg, end);
            });
            textBox4.Text += "Time: " + (DateTime.Now - dtNow).ToString() + "\r\n";
            //for (int col = 1; col < column; col += 2) // Нечетные столбцы (1, 3, 5, ...)
            //{
            //    InsertionSortColumn(array, col);
            //}
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    st += Convert.ToString(array[i, j]) + "  ";
                }
                st += "\r\n";
            }
            if (column > 20 || rows > 20)
            {
                string path = @"C:\Users\Sssof\source\repos\Labacsharp1.1\itogLaba3.txt";
                SaveToFile(st, column, rows, path);
            }
            else
            {
                textBox4.Text += st;
            }


        }
        async void SaveToFile(string result, int column, int rows, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                await writer.WriteLineAsync(result);
            }
            MessageBox.Show("Содержание было записано");
        }
        public void InsertionSortColumn(int[,] array, int beg, int end)
        {
            int rows = array.GetLength(0);
            for (int col = beg; col < end; col += 2)
            {
                for (int i = 0; i < rows; i++)
                {
                    int key = array[i, col];
                    int k = i - 1;
                    while (k >= 0 && array[k, col] > key)
                    {
                        array[k + 1, col] = array[k, col];
                        k--;
                    }
                    array[k + 1, col] = key;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int N; //Число потоков
            try
            {
                N = Convert.ToInt32(textBox5.Text);
                while (N <= 0)
                {
                    N++;
                    MessageBox.Show($"Введено неверное количество потоков. Будет принято значение {N}");
                }
            }
            catch { N = 4; }

            try { rows = Convert.ToInt32(textBox1.Text); } catch { rows = 8; }

            try
            {
                column = Convert.ToInt32(textBox2.Text);
                if (column % 4 != 0)
                {
                    while (column % 4 != 0) column++;
                    MessageBox.Show($"Количество столбцов не кратно четырем, будет взято значение {column}");
                }
            }
            catch { column = 8; }
            DateTime dtNow = DateTime.Now;
            string sr = "";
            int[,] array = new int[rows, column];
            int dN = column / N;
            Task[] tasks = new Task[N];
            Task[] ts = new Task[N];
            textBox4.Text = "Init" + "\r\n";
            for (int i = 0; i < N; i++)
            {
                ts[i] = Task.Run(() =>
                {
                    int beg; int end;
                    int id = 0;
                    if (Task.CurrentId != null)
                    {
                        id = (Task.CurrentId.Value % N) + 1;
                    }
                    beg = (id - 1) * dN;
                    if (id == N)
                    {
                        end = column;
                    }
                    else
                    {
                        end = id * dN;
                    }
                    for (int k = 0; k < rows; k++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            array[k, j] = rnd.Next(20, 41);
                        }
                    }
                });
            }
            for (int i = 0; i < N; i++)
            {
                ts[i].Wait();
            }
            for (int k = 0; k < rows; k++)
            {
                for (int j = 0; j < column; j++)
                {
                    sr += Convert.ToString(array[k, j]) + " ";
                }
                sr += "\r\n";
            }
            textBox4.Text += "Time: " + (DateTime.Now - dtNow).ToString() + Environment.NewLine;
            if (column > 20 || rows > 20)
            {
                string path = @"C:\Users\Sssof\source\repos\Labacsharp1.1\neItogLaba3.txt";
                SaveToFile(sr, column, rows, path);
            }
            else
            {
                textBox3.Text += sr;
            }
            textBox4.Text += "Start" + Environment.NewLine;
            for (int i = 0; i < N; i++)
            {
                tasks[i] = new Task(() =>
                {
                    int beg; int end; int id = 0;
                    if (Task.CurrentId != null)
                    {
                        id = (Task.CurrentId.Value) % N + 1;
                    }
                    beg = (id - 1) * dN;
                    if (id == N)
                    {
                        end = column;
                    }
                    else
                    {
                        end = id * dN;
                    }
                    InsertionSortColumn(array, beg, end);
                });
            }
            for (int i = 0; i < N; i++)
            {
                tasks[i].Start();
                tasks[i].Wait();
            }
            textBox4.Text += "Time: " + (DateTime.Now - dtNow).ToString() + "\r\n";
            string st = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    st += Convert.ToString(array[i, j]) + " ";
                }
                st += "\r\n";
            }
            if (column > 20 || rows > 20)
            {
                string path = @"C:\Users\Sssof\source\repos\Labacsharp1.1\itogLaba3.txt";
                SaveToFile(st, column, rows, path);
            }
            else
            {
                textBox4.Text += st;
            }
        }
    }
}
