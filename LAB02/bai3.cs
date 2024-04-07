using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LAB02
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string inputFilePath = ofd.FileName;
                string outputFilePath = "output_bai3.txt";

                try
                {
                    string[] lines = File.ReadAllLines(inputFilePath);

                    using (StreamWriter writer = new StreamWriter(outputFilePath, false))
                    {
                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(' ');

                            List<decimal> operands = new List<decimal>();
                            List<char> operators = new List<char>();

                            foreach (string part in parts)
                            {
                                if (decimal.TryParse(part, out decimal operand))
                                {
                                    operands.Add(operand);
                                }
                                else if (IsOperator(part))
                                {
                                    operators.Add(part[0]);
                                }
                            }

                            if (operands.Count == operators.Count + 1)
                            {
                                decimal result = EvaluateExpression(operands, operators);

                                writer.WriteLine($"{line} = {result}");
                            }
                            else
                            {
                                MessageBox.Show("Dữ liệu đầu vào không hợp lệ!");
                            }
                        }
                    }

                    MessageBox.Show("Vui lòng kiểm tra kết quả trong 'output_bai3.txt'", "Tính toán xong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
        }

        private bool IsOperator(string value)
        {
            return value == "+" || value == "-" || value == "*" || value == "/";
        }

        private decimal EvaluateExpression(List<decimal> operands, List<char> operators)
        {
            if (operators.Contains('*') || operators.Contains('/'))
            {
                while (operators.Contains('*') || operators.Contains('/'))
                {
                    int index = operators.FindIndex(op => op == '*' || op == '/');

                    decimal operand1 = operands[index];
                    decimal operand2 = operands[index + 1];
                    char op = operators[index];

                    decimal result = 0;

                    if (op == '*')
                    {
                        result = operand1 * operand2;
                    }
                    else if (op == '/')
                    {
                        if (operand2 != 0)
                        {
                            result = operand1 / operand2;
                        }
                        else
                        {
                            MessageBox.Show("Không thể chia cho 0!");
                            return decimal.MinValue;
                        }
                    }

                    operands[index] = result;
                    operands.RemoveAt(index + 1);
                    operators.RemoveAt(index);
                }
            }

            decimal finalResult = operands[0];

            for (int i = 1; i < operands.Count; i++)
            {
                char op = operators[i - 1];
                decimal operand = operands[i];

                if (op == '+')
                {
                    finalResult += operand;
                }
                else if (op == '-')
                {
                    finalResult -= operand;
                }
            }

            return finalResult;
        }
    }
}