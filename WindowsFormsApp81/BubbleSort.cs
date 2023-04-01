using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp81
{
    public class BubbleSort : IStrategy
    {
        public int iterationCount = 0;
        public static Form1 form1;
        public int[] Algorithm(int[] mas, bool flag = true)
        {
            if (flag)
            {
                IOFile.FillContent();
                System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
                myStopwatch.Start();
                int temp;
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        this.iterationCount++;
                        IOFile.content += this.iterationCount.ToString() + " итерация: " + '\n';
                        IOFile.InputInfoAboutComparison(mas[i], mas[j]);
                        Analysis.Comparison++;
                        if (mas[i] > mas[j])
                        {
                            IOFile.InputInfoAboutTransposition(mas[i], mas[j]);
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                            Analysis.NumberOfPermutations++;

                            IOFile.FillContent();
                            form1.AddItemsListBox(mas[i], mas[j]);
                        }
                    }
                }
                myStopwatch.Stop();
                var resultTime = myStopwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                    resultTime.Hours,
                    resultTime.Minutes,
                    resultTime.Seconds,
                    resultTime.Milliseconds);
                form1.label4.Text = Convert.ToString(Analysis.Comparison);
                form1.label5.Text = Convert.ToString(Analysis.NumberOfPermutations);
                form1.label6.Text = elapsedTime;

                return mas;
            }
            else
            {
                System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
                myStopwatch.Start();
                int temp;
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        Analysis.Comparison++;
                        if (mas[i] > mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                            Analysis.NumberOfPermutations++;
                        }
                    }
                }
                myStopwatch.Stop();
                var resultTime = myStopwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                    resultTime.Hours,
                    resultTime.Minutes,
                    resultTime.Seconds,
                    resultTime.Milliseconds);
                Analysis.timeSort = resultTime.Seconds * 1000 + resultTime.Milliseconds;
                Analysis.elapsedTime = elapsedTime;
                return mas;
            }
        }
    }

}

