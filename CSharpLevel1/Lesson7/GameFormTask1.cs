using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lesson7
{

    /// <summary>
    /// Возможные операции
    /// </summary>
    enum Operation
    {
        Inc,
        Mul
    }

    public partial class GameFormTask1 : Form
    {
        private int _currentCount;
        private int _minCount;
        private int _currentValue;
        private int _hiddenValue;
        private Stack<Operation> _stack;

        public GameFormTask1()
        {
            InitializeComponent();
            _stack = new Stack<Operation>();
            _hiddenValue = new Random().Next(1, 100);
            _minCount = MinCount(_hiddenValue);
            LabelHiddenValue.Text = _hiddenValue.ToString();
        }

        /// <summary>
        /// Минимальное количество шагов
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private int MinCount(int number)
        {
            int count = 0;
            while (number != 0)
            {
                if (number % 2 != 0) number--;
                else number /= 2;
                count++;
            }
            return count;
        }

        /// <summary>
        /// Сброс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            _currentCount++;
            _currentValue = 0;
            UpdateLabel();
            CheckValue();
        }

        /// <summary>
        /// Прибавить 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnc_Click(object sender, EventArgs e)
        {
            _currentCount++;
            _currentValue++;
            _stack.Push(Operation.Inc);
            UpdateLabel();
            CheckValue();
        }

        /// <summary>
        /// Умножить на 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMul_Click(object sender, EventArgs e)
        {
            _currentCount++;
            _currentValue *= 2;
            _stack.Push(Operation.Mul);
            UpdateLabel();
            CheckValue();
        }

        /// <summary>
        /// Отменить последнее действие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (_stack.Count != 0)
            {
                if (_stack.Pop() == Operation.Inc) _currentValue--;
                else _currentValue /= 2;
                _currentCount++;
                UpdateLabel();
                CheckValue();
            }
        }

        /// <summary>
        /// Обновить поля
        /// </summary>
        public void UpdateLabel()
        {
            LabelCurrentValue.Text = _currentValue.ToString();
        }

        /// <summary>
        /// Проверить значение
        /// </summary>
        public void CheckValue()
        {
            if (_hiddenValue == _currentValue)
            {
                new CongratulationFormTask1(_currentCount, _minCount).ShowDialog();
                Close();
            }
        }

        /// <summary>
        /// Закрыть окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyFormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.MainFormTask1.Show();
        }

    }
}