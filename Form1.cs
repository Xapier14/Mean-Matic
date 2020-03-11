using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MeanMatic
{
    public partial class Form1 : Form
    {
        public static QuestionGroup MainGroup = new QuestionGroup();
        public static Question LoadedQuestion = null, OldQuestionData = null;
        public static int QIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (dg_qdata.SelectedRows.Count > 0)
            {
                TB_weight.Text = dg_qdata.SelectedRows[0].Cells[0].Value.ToString();
                TB_freq.Text = dg_qdata.SelectedRows[0].Cells[1].Value.ToString();
            }
            */
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_NewQuestion.Text != String.Empty)
            {
                try
                {
                    MainGroup.AddQuestion(new Question(tb_NewQuestion.Text));
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                RefreshOverview();
                tb_NewQuestion.Text = String.Empty;
            } else
            {
                MessageBox.Show("Question name cannot be blank.", "Warning");
            }
        }
        public class QuestionGroup
        {
            private List<Question> _questions;
            public QuestionGroup()
            {
                _questions = new List<Question>();
            }
            public List<Question> GetQuestions()
            {
                return _questions;
            }
            public void AddQuestion(Question question)
            {
                foreach (Question q in _questions)
                {
                    if (q.GetQuestionName() == question.GetQuestionName())
                    {
                        throw new Exception("New Question cannot have an identical question name with an existing question.");
                    }
                }
                _questions.Add(question);
            }
            public Question GetQuestion(string QuestionName)
            {
                foreach (Question q in _questions)
                {
                    if (q.GetQuestionName() == QuestionName)
                    {
                        return q;
                    }
                }
                return null;
            }
            public void ReplaceQuestion(Question OldQuestion, Question NewQuestion)
            {
                _questions.Insert(_questions.IndexOf(OldQuestion), NewQuestion);
                _questions.Remove(OldQuestion);
            }
            public int GetTotalQuestions()
            {
                return _questions.Count;
            }
            public string[] GetQuestionNames()
            {
                string[] ret = new string[_questions.Count];
                int index = 0;
                foreach (Question q in _questions)
                {
                    ret[index] = q.GetQuestionName();
                    index++;
                }
                return ret;
            }
            public int[] GetQuestionResponses()
            {
                int[] ret = new int[_questions.Count];
                int index = 0;
                foreach (Question q in _questions)
                {
                    ret[index] = q.GetTotalResponses();
                    index++;
                }
                return ret;
            }
            public double[] GetWAMs()
            {
                double[] ret = new double[_questions.Count];
                int index = 0;
                foreach (Question q in _questions)
                {
                    ret[index] = q.GetWAM();
                    index++;
                }
                return ret;
            }
            public int[] GetWeights()
            {
                int[] ret = new int[_questions.Count];
                int index = 0;
                foreach (Question q in _questions)
                {
                    ret[index] = q.GetNumberOfWeights();
                    index++;
                }
                return ret;
            }
            public double[] GetVars()
            {
                double[] ret = new double[_questions.Count];
                int index = 0;
                foreach (Question q in _questions)
                {
                    ret[index] = q.GetVariance();
                    index++;
                }
                return ret;
            }
            public double[] GetStdDevs()
            {
                double[] ret = new double[_questions.Count];
                int index = 0;
                foreach (Question q in _questions)
                {
                    ret[index] = q.GetStandardDeviation();
                    index++;
                }
                return ret;
            }
            public void RecomputeWAMs()
            {
                foreach (Question q in _questions)
                {
                    q.ComputeWAM();
                    q.ComputeVarianceAndStandardDeviation();
                }
            }
        }
        public class Question
        {
            private List<WeightFreq> _Weights = null;
            private string _QuestionName = "";
            private double _WAM = 0, _StdDev = 0, _Var = 0;
            public Question(string QuestionName)
            {
                _QuestionName = QuestionName;
                _Weights = new List<WeightFreq>();
            }
            public int GetNumberOfWeights()
            {
                return _Weights.Count;
            }
            public void AddWeightFreq(WeightFreq weightFreq, bool Overwrite)
            {
                foreach (WeightFreq wf in _Weights)
                {
                    if (wf.GetWeight() == weightFreq.GetWeight())
                    {
                        if (Overwrite)
                        {
                            _Weights.Insert(_Weights.IndexOf(wf), weightFreq);
                            _Weights.Remove(wf);
                        } else
                        {
                            WeightFreq wfn = wf;
                            wfn.IncrementFrequency(weightFreq.GetFrequency());
                            _Weights.Insert(_Weights.IndexOf(wf), wfn);
                            _Weights.Remove(wf);
                        }
                        return;
                    }
                }
                _Weights.Add(weightFreq);
            }
            public int GetTotalWeights()
            {
                return _Weights.Count;
            }
            public int[] GetWeights()
            {
                int[] ret = new int[_Weights.Count];
                int i = 0;
                foreach(WeightFreq wf in _Weights)
                {
                    ret[i] = wf.GetWeight();
                    i++;
                }
                return ret;
            }
            public int[] GetFrequencies()
            {
                int[] ret = new int[_Weights.Count];
                int i = 0;
                foreach (WeightFreq wf in _Weights)
                {
                    ret[i] = wf.GetFrequency();
                    i++;
                }
                return ret;
            }
            public string GetQuestionName()
            {
                return _QuestionName;
            }
            public int GetTotalResponses()
            {
                if (_Weights != null)
                {
                    if (_Weights.Count > 0)
                    {
                        int TotalFreq = 0;
                        foreach (WeightFreq freq in _Weights)
                        {
                            TotalFreq += freq.GetFrequency();
                        }
                        return TotalFreq;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            public double GetWAM()
            {
                return _WAM;
            }
            public double GetVariance()
            {
                return _Var;
            }
            public double GetStandardDeviation()
            {
                return _StdDev;
            }
            public void ComputeWAM()
            {
                if (_Weights != null)
                {
                    if (_Weights.Count > 0)
                    {
                        int TotalFreq = 0;
                        int WeightCount = 0;
                        int Data = 0;
                        foreach (WeightFreq freq in _Weights)
                        {
                            WeightCount++;
                            TotalFreq += freq.GetFrequency();
                            Data += freq.GetFrequency() * freq.GetWeight();
                        }
                        _WAM = (double)Data / (double)TotalFreq;
                    } else
                    {
                        _WAM = 0;
                        return;
                    }
                } else
                {
                    _WAM = 0;
                    return;
                }
            }
            public void ComputeVarianceAndStandardDeviation()
            {
                if (_Weights != null)
                {
                    if (_Weights.Count > 0)
                    {
                        int TotalFreq = 0;
                        int WeightCount = 0;
                        double Data = 0;
                        foreach (WeightFreq freq in _Weights)
                        {
                            WeightCount++;
                            TotalFreq += freq.GetFrequency();
                            for (int i = 0; i < freq.GetFrequency(); i++)
                            {
                                Data += ((double)freq.GetWeight() - _WAM) * ((double)freq.GetWeight() - _WAM);
                            }
                        }
                        _Var = Data / (double)TotalFreq;
                        _StdDev = Math.Sqrt(_Var);
                    }
                    else
                    {
                        _StdDev = 0;
                        _Var = 0;
                        return;
                    }
                }
                else
                {
                    _StdDev = 0;
                    _Var = 0;
                    return;
                }
            }
        }
        public class WeightFreq
        {
            private int _Frequency = 0;
            private int _Weight = 0;
            public WeightFreq(int Weight)
            {
                _Weight = Weight;
            }
            public void SetFrequency(int Frequency)
            {
                _Frequency = Frequency;
            }
            public void IncrementFrequency(int IncrementBy)
            {
                _Frequency += IncrementBy;
            }
            public int GetWeight()
            {
                return _Weight;
            }
            public int GetFrequency()
            {
                return _Frequency;
            }
        }

        private void button_oRefresh_Click(object sender, EventArgs e)
        {
            if (MainGroup.GetTotalQuestions() > 0)
            {
                RefreshOverview();
                int TotalQ = MainGroup.GetTotalQuestions();
                MessageBox.Show("Refreshed " + TotalQ.ToString() + " question(s).", "Notice");
            } else
            {
                //MessageBox.Show("No Questions Stored!");
            }
        }
        private void RefreshOverview()
        {
            int TotalQ = MainGroup.GetTotalQuestions();
            string[] QNames = MainGroup.GetQuestionNames();
            int[] QResponses = MainGroup.GetQuestionResponses();
            MainGroup.RecomputeWAMs();
            double[] QWAMs = MainGroup.GetWAMs();
            double[] QVars = MainGroup.GetVars();
            double[] QStdDevs = MainGroup.GetStdDevs();
            int[] QPoints = MainGroup.GetWeights();
            dg_Overview.Rows.Clear();
            for (int i = 0; i < TotalQ; i++)
            {
                dg_Overview.Rows.Add(QNames[i], QPoints[i], QResponses[i], QWAMs[i], QVars[i], QStdDevs[i]);
            }
        }

        private void button_LoadQData_Click(object sender, EventArgs e)
        {
            if (dg_Overview.SelectedRows.Count > 0)
            {
                OldQuestionData = MainGroup.GetQuestion((string)dg_Overview.SelectedRows[0].Cells[0].Value);
                LoadedQuestion = OldQuestionData;
                label_LoadedQu.Text = "Loaded Question: " + LoadedQuestion.GetQuestionName();
                QIndex = dg_Overview.Rows.IndexOf(dg_Overview.SelectedRows[0]);
                RefreshQDataView();
            } else
            {
                MessageBox.Show("No question selected. Cannot load question data.", "Warning");
            }
        }
        private void RefreshQDataView()
        {
            if (LoadedQuestion != null && OldQuestionData != null)
            {
                dg_qdata.Rows.Clear();
                int TotalWeights = LoadedQuestion.GetTotalWeights();
                if (TotalWeights > 0)
                {
                    int[] Ww = LoadedQuestion.GetWeights();
                    int[] Wf = LoadedQuestion.GetFrequencies();
                    for (int i = 0; i < TotalWeights; i++)
                    {
                        dg_qdata.Rows.Add(Ww[i], Wf[i]);
                    }
                }
            }
            else
            {
                dg_qdata.Rows.Clear();
                //MessageBox.Show("No question loaded!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (LoadedQuestion != null && Clean(TB_freq.Text) != String.Empty && Clean(TB_weight.Text) != String.Empty)
            {
                int UserWeight = Int32.Parse(Clean(TB_weight.Text));
                int UserFreq = Int32.Parse(Clean(TB_freq.Text));
                WeightFreq UserWF = new WeightFreq(UserWeight);
                UserWF.SetFrequency(UserFreq);
                LoadedQuestion.AddWeightFreq(UserWF, false);
                RefreshQDataView();
            } else
            {
                MessageBox.Show("Invalid input data!\nEither no question data or text field has non-allowed characters.", "Error");
            }
        }
        public static string Clean(string source)
        {
            string ret = Regex.Replace(source, "[^0-9.]", "");
            if (ret == String.Empty) ret = "0";
            return ret;
        }

        private void button_SetFreq_Click(object sender, EventArgs e)
        {
            if (LoadedQuestion != null && Clean(TB_freq.Text) != String.Empty && Clean(TB_weight.Text) != String.Empty)
            {
                int UserWeight = Int32.Parse(Clean(TB_weight.Text));
                int UserFreq = Int32.Parse(Clean(TB_freq.Text));
                WeightFreq UserWF = new WeightFreq(UserWeight);
                UserWF.SetFrequency(UserFreq);
                LoadedQuestion.AddWeightFreq(UserWF, true);
                RefreshQDataView();
            }
            else
            {
                MessageBox.Show("Invalid input data!\nEither no question data or text field has non-allowed characters.", "Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mean-Matic v1.0 - Private Build\n" +
                            "Written by: Lance Crisang\n" +
                            "Do not distribute.", "About Program");
        }

        private void dg_Overview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_qdata_selChange(object sender, EventArgs e)
        {
            if (dg_qdata.SelectedRows.Count > 0 && CB_RTM.Checked)
            {
                TB_weight.Text = dg_qdata.SelectedRows[0].Cells[0].Value.ToString();
                TB_freq.Text = dg_qdata.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void label_LoadedQu_Click(object sender, EventArgs e)
        {

        }

        private void button_UnloadData_Click(object sender, EventArgs e)
        {
            if (LoadedQuestion != null && OldQuestionData != null)
            {
                OldQuestionData = null;
                LoadedQuestion = null;
                label_LoadedQu.Text = "Loaded Question: -N/A-";
                TB_freq.Text = String.Empty;
                TB_weight.Text = String.Empty;
                RefreshQDataView();
            }
            else
            {
                MessageBox.Show("No question loaded!", "Warning");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                if (LoadedQuestion != null && OldQuestionData != null)
                {
                    if (CB_RTM.Checked)
                    {
                        var wf = new WeightFreq(int.Parse(Clean(textBox1.Text)));
                        wf.SetFrequency(1);
                        LoadedQuestion.AddWeightFreq(wf, false);
                        if (CB_IncQ.Checked)
                        {
                            QIndex++;
                            if (QIndex >= dg_Overview.Rows.Count)
                            {
                                QIndex = 0;
                            }
                            LoadedQuestion = MainGroup.GetQuestion(((string)dg_Overview.Rows[QIndex].Cells[0].Value));
                            OldQuestionData = LoadedQuestion;
                            label_LoadedQu.Text = "Loaded Question: " + LoadedQuestion.GetQuestionName();
                        }
                        MainGroup.ReplaceQuestion(OldQuestionData, LoadedQuestion);
                        RefreshQDataView();
                        RefreshOverview();
                    }
                }
                else
                {
                    MessageBox.Show("No question loaded!", "Warning");
                }
                textBox1.Text = String.Empty;
            }

        }

        private void button_ExportData_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
        public string Merge(string[] lines)
        {
            string ret = "";
            foreach(string s in lines)
            {
                ret = ret + "\n" + s;
            }
            return ret;
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            int i = 0;
            string fn = saveFileDialog1.FileName;
            List<string> Metadata = new List<string>();
            List<string> QData = new List<string>();
            if (!File.Exists(saveFileDialog1.FileName))
            {
                //File
            }
            Metadata.Add("MeanMatic V1 - Data Report");
            Metadata.Add("Total Questions: " + MainGroup.GetTotalQuestions());
            Metadata.Add("");
            File.AppendAllText(fn, Merge(Metadata.ToArray()));
            string qname = "Null";
            foreach (Question q in MainGroup.GetQuestions())
            {
                int[] Weights = q.GetWeights();
                int[] Freq = q.GetFrequencies();
                qname = q.GetQuestionName();
                QData.Add("Question #" + (i + 1).ToString() + " - " + '"'.ToString() + qname + '"'.ToString());
                for (int d = 0; d < Weights.Length; d++)
                {
                    QData.Add("     '" + Weights[d].ToString() + "' = " + Freq[d].ToString());
                }
                q.ComputeWAM();
                q.ComputeVarianceAndStandardDeviation();
                QData.Add("    WAM: " + q.GetWAM().ToString());
                QData.Add("    Standard Deviation: " + q.GetStandardDeviation().ToString());
                QData.Add("    Variance: " + q.GetVariance().ToString());
                QData.Add("    Total Responses: " + q.GetTotalResponses());
                QData.Add("");
                File.AppendAllText(fn, Merge(QData.ToArray()));
                QData.Clear();
                i++;
            }
            MessageBox.Show("Operation completed.");
        }

        private void button_SaveQuestionData_Click(object sender, EventArgs e)
        {
            if (LoadedQuestion != null && OldQuestionData != null)
            {
                MainGroup.ReplaceQuestion(OldQuestionData, LoadedQuestion);
                RefreshOverview();
            }
            else
            {
                MessageBox.Show("No question loaded!", "Warning");
            }
        }
    }
}
