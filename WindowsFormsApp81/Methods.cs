using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp81
{
    public class Methods
    {
        public int iterationCount = 0;
        public static Form1 form1;
        public int[] Algorithm(int[] mass, bool flag = true)
        {
            if (flag)
            {
                IOFile.FillContent();
                int i, j, step;
                int tmp;
                System.Diagnostics.Stopwatch myStopwatch = new
                System.Diagnostics.Stopwatch();
                myStopwatch.Start();
                for (step = mass.Length / 2; step > 0; step /= 2)
                {
                    for (i = step; i < mass.Length; i++)
                    {
                        iterationCount++;

                        IOFile.content += this.iterationCount.ToString() + "итерация: " + '\n';
                        tmp = mass[i];

                        for (j = i; j >= step; j -= step)

                        {
                            IOFile.InputInfoAboutComparison(tmp, mass[j - step]);
                            Form3.Comparison++;
                            if (tmp < mass[j - step])

                            {
                                IOFile.InputInfoAboutTransposition(tmp, mass[j - step]);
                                mass[j] = mass[j - step];
                                Form3.NumberOfPermutations++;
                            }
                            else
                            {

                                break;
                            }



                        }

                        mass[j] = tmp;
                        IOFile.FillContent();

                        form1.ListBox1(mass[i], mass[j]);

                    }
                }
                myStopwatch.Stop();
                var resultTime = myStopwatch.Elapsed;
                string elapsedTime =
                String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                resultTime.Hours,
                resultTime.Minutes,
                resultTime.Seconds,
                resultTime.Milliseconds);
                form1.label5.Text =
                Convert.ToString(Form3.Comparison);
                form1.label6.Text =
                Convert.ToString(Form3.NumberOfPermutations);
                form1.label7.Text = elapsedTime;
                return mass;

            }
            else
            {
                int i, j, step;
                int tmp;
                System.Diagnostics.Stopwatch myStopwatch = new
                System.Diagnostics.Stopwatch();
                myStopwatch.Start();
                for (step = mass.Length / 2; step > 0; step /= 2)
                {
                    for (i = step; i < mass.Length; i++)
                    {
                        iterationCount++;
                        tmp = mass[i];
                        for (j = i; j >= step; j -= step)


                        {
                            Form3.Comparison++;
                            if (tmp < mass[j - step])

                            {
                                mass[j] = mass[j - step];
                                Form3.NumberOfPermutations++;
                            }
                            else
                            {

                                break;
                            }
                        }

                        mass[j] = tmp;

                    }
                }
                myStopwatch.Stop();
                var resultTime = myStopwatch.Elapsed;
                string elapsedTime =
                String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                resultTime.Hours,
                resultTime.Minutes,
                resultTime.Seconds,
                resultTime.Milliseconds);
                Form3.timeSort = resultTime.Seconds * 1000 +
                resultTime.Milliseconds;
                Form3.elapsedTime = elapsedTime;
                return mass;
            }
        }
    }
}


       
       

    }
   
}
