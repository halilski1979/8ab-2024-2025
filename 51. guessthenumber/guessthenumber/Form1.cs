using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;  // Деактивираме бутона за отгатване, докато не се стартира играта
        }

        
        // Променливи за генерираното число и броя опити
        int compNum, cnt;


        // Събитие при натискане на бутон1 (Старт на играта)
        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();             // Създаваме генератор на случайни числа
            compNum = r.Next(1, 101);            // Генерираме число между 1 и 100
            button2.Enabled = true;              // Активираме бутона за отгатване
            button1.Enabled = false;             // Деактивираме бутона за старт, докато играта не приключи
            cnt = 0;                             // Нулираме брояча на опитите
            textBox1.Clear();                    // Изчистваме полето за въвеждане
            textBox2.Clear();                    // Изчистваме полето за подсказка
            textBox3.Clear();                    // Изчистваме полето за брояч
        }

        // Събитие при натискане на бутон2 (Опит за познаване)
        private void button2_Click(object sender, EventArgs e)
        {
            int myNum = int.Parse(textBox1.Text);   // Прочитаме числото, въведено от играча
            cnt++;                                  // Увеличаваме брояча на опитите
            textBox3.Text = cnt.ToString();         // Показваме броя на опитите
            textBox1.Focus();                       // Поставяме фокуса обратно в полето за въвеждане
            textBox1.SelectAll();                   // Избираме съдържанието за лесно презаписване

            if (myNum < compNum)
            {
                textBox2.Text = "нагоре";           // Подсказка: числото е по-голямо
            }
            if (myNum > compNum)
            {
                textBox2.Text = "надолу";           // Подсказка: числото е по-малко
            }
            if (myNum == compNum)
            {
                textBox2.Text = "позна";            // Поздравление при успешно познаване
                button2.Enabled = false;            // Деактивираме бутона за отгатване
                button1.Enabled = true;             // Активираме бутона за нова игра
            }
        }

        // Ограничаване на въвеждането в textBox1 само до цифри (и backspace)
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9') // Ако не е цифра
            {
                if (e.KeyChar != 8)                 // и не е Backspace
                {
                    e.Handled = true;              // Блокираме въвеждането
                }
            }
        }
    }
}
