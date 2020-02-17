using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace бандит
{
    public partial class Form2 : Form
    {
        double balance; //Текущий баланс.
        int counter_money = 0; //Текущий ставка.
        int counter_try = 0; //Счетчик попыток.
        int win_money = 0; //Выигранные деньги.
        bool IsActive = true; //Активность кнопки "Играть!"

        public Form2(string name, double money)
        {
            InitializeComponent();
            label7.Text = name;
            label4.Text = "Баланс $" + Convert.ToString(money);
            balance = money;
            button1.Enabled = false;

        }
        private void Init_Counter(decimal counter)
        {
            counter_money = Convert.ToInt32(counter);
            balance -= counter_money;
            label4.Text = "Баланс: $" + balance;
            counter_try = 5;
            label6.Text = "Осталось попыток: " + counter_try;
        }

        private void Win_Money()
        {
            if (label1.Text == "0" && label2.Text == "0" && label3.Text == "0") Upd_Win_Money(19);
            if (label1.Text == "1" && label2.Text == "1" && label3.Text == "1") Upd_Win_Money(10);
            if (label1.Text == "2" && label2.Text == "2" && label3.Text == "2") Upd_Win_Money(11);
            if (label1.Text == "3" && label2.Text == "3" && label3.Text == "3") Upd_Win_Money(12);
            if (label1.Text == "4" && label2.Text == "4" && label3.Text == "4") Upd_Win_Money(13);
            if (label1.Text == "5" && label2.Text == "5" && label3.Text == "5") Upd_Win_Money(14);
            if (label1.Text == "6" && label2.Text == "6" && label3.Text == "6") Upd_Win_Money(15);
            if (label1.Text == "7" && label2.Text == "7" && label3.Text == "7") Upd_Win_Money(16);
            if (label1.Text == "8" && label2.Text == "8" && label3.Text == "8") Upd_Win_Money(17);
            if (label1.Text == "9" && label2.Text == "9" && label3.Text == "9") Upd_Win_Money(18);
            if ((label1.Text == "0" && label2.Text == "0") || (label2.Text == "0" && label3.Text == "0") || (label1.Text == "0" && label3.Text == "0")) Upd_Win_Money(4);
            if ((label1.Text == "1" && label2.Text == "1") || (label2.Text == "1" && label3.Text == "1") || (label1.Text == "1" && label3.Text == "1")) Upd_Win_Money(1);
            if ((label1.Text == "2" && label2.Text == "2") || (label2.Text == "2" && label3.Text == "2") || (label1.Text == "2" && label3.Text == "2")) Upd_Win_Money(1);
            if ((label1.Text == "3" && label2.Text == "3") || (label2.Text == "3" && label3.Text == "3") || (label1.Text == "3" && label3.Text == "3")) Upd_Win_Money(1);
            if ((label1.Text == "4" && label2.Text == "4") || (label2.Text == "4" && label3.Text == "4") || (label1.Text == "4" && label3.Text == "4")) Upd_Win_Money(1);
            if ((label1.Text == "5" && label2.Text == "5") || (label2.Text == "5" && label3.Text == "5") || (label1.Text == "5" && label3.Text == "5")) Upd_Win_Money(2);
            if ((label1.Text == "6" && label2.Text == "6") || (label2.Text == "6" && label3.Text == "6") || (label1.Text == "6" && label3.Text == "6")) Upd_Win_Money(2);
            if ((label1.Text == "7" && label2.Text == "7") || (label2.Text == "7" && label3.Text == "7") || (label1.Text == "7" && label3.Text == "7")) Upd_Win_Money(2);
            if ((label1.Text == "8" && label2.Text == "8") || (label2.Text == "8" && label3.Text == "8") || (label1.Text == "8" && label3.Text == "8")) Upd_Win_Money(3);
            if ((label1.Text == "9" && label2.Text == "9") || (label2.Text == "9" && label3.Text == "9") || (label1.Text == "9" && label3.Text == "9")) Upd_Win_Money(3);
        }
        private void Upd_Win_Money(int number)
        {
            win_money = counter_money * number; //умножаем ставку на коэффициент получаем кол-во выигранных денег
            DialogResult result;
            if (number <= 4)
            {
                result = MessageBox.Show("Вы выиграли: $" + win_money, "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Выыодим поздравления.
            }
            else
            {
                result = MessageBox.Show("Вам фортануло: $" + win_money, "ДЖЕКПОООТ!", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Выыодим поздравления.
            }
            balance += win_money; //Прибавляем выигрыш к балансу
            label4.Text = "Баланс: $" + balance; //Выводим обновленный балансе
            button1.Enabled = false; //Блокируем кнопку "Играть!"
            button2.Enabled = true; //Открываем кнопку "Сделать ставку"
            IsActive = false;
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Делайте новую ставку!", "Новая игра", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label6.Text = "Осталось попыток: 0"; // Скидываем оставшиеся попытки.
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dvg1_Tick_1(object sender, EventArgs e)
        {
            Random random = new Random(); //Создаем экземпляр класса Random
            int dvg = random.Next(10); // Получаем случайное число от 0-9
            label1.Text = dvg.ToString(); //Выводим полученное число.

        }

        private void dvg2_Tick_1(object sender, EventArgs e)
        {
            Random random = new Random();
            int dvg = random.Next(10);
            label2.Text = dvg.ToString();

        }

        private void dvg3_Tick_1(object sender, EventArgs e)
        {
            Random random = new Random();
            int dvg = random.Next(10);
            label3.Text = dvg.ToString();

        }

        private void stop1_Tick_1(object sender, EventArgs e)
        {
            dvg1.Enabled = false; //Останавливаем таймер запускающий первый барабан.
            stop1.Enabled = false; //Останавливаем таймер останавливающий первый барабан.

        }

        private void stop2_Tick_1(object sender, EventArgs e)
        {
            dvg2.Enabled = false;
            stop2.Enabled = false;

        }

        private void stop3_Tick_1(object sender, EventArgs e)
        {
            counter_try--; //Уменьшаем число попыток.
            dvg3.Enabled = false;
            stop3.Enabled = false;
            Win_Money();
            if (IsActive)
            {
                if (counter_try != 0) //Если число попыток больше 0, то даем возможность нажать на кнопку "Играть!" еще раз, если нет, то блокируем кнопку "Играть!", и выводим информационное окно.
                {
                    label6.Text = "Осталось попыток: " + counter_try;
                    button1.Enabled = true;
                }
                else
                {
                    label6.Text = "Осталось попыток: " + counter_try;
                    MessageBox.Show("Делайте новую ставку!", "Попытки закончились...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button2.Enabled = true;
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= Convert.ToInt32(balance))
            {
                Init_Counter(numericUpDown1.Value);
                button1.Enabled = true;
                button2.Enabled = false;
            }
            else
            {
                MessageBox.Show("...прыгать выше головы?", "Зачем...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //активируем таймеры
            dvg1.Enabled = true;
            dvg2.Enabled = true;
            dvg3.Enabled = true;
            stop1.Enabled = true;
            stop2.Enabled = true;
            stop3.Enabled = true;
            IsActive = true;
            button1.Enabled = false; //Пока барабаны крутятся кнопка "Играть!"  заблокирована.

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
