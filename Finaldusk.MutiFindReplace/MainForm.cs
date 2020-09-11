using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finaldusk.MutiFindReplace
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridViewKeyValues_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V) // 判断是否按下ctrl+v
            {
                Paste(dataGridViewKeyValues, "", 0, false);//粘贴代码
            }
        }

        private void button_paste_Click(object sender, EventArgs e)
        {
            textBoxTarget.Text= Clipboard.GetText();
        }

        private void button_DoIt_Click(object sender, EventArgs e)
        {
            var targettext = textBoxTarget.Text;
            var dic = new Dictionary<string, string>();

            foreach (DataGridViewRow row in dataGridViewKeyValues.Rows)
            {
                var find = row.Cells[0].Value?.ToString();
                var replace = row.Cells[1].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(find) && !string.IsNullOrWhiteSpace(replace))
                {
                    dic.Add(find, replace);
                }
            }
                 
            foreach (var item in dic)
            {
                targettext = targettext.Replace(item.Key, item.Value);
            }
            textBoxTarget.Text = targettext;
        }

        private int Paste(DataGridView dgv, string pasteText, int kind, bool b_cut)
        {
            try
            {
                if (kind == 0)
                {
                    pasteText = Clipboard.GetText();
                }
                if (string.IsNullOrEmpty(pasteText))
                    return -1;
                int rowNum = 0;
                int columnNum = 0;
                for (int i = 0; i < pasteText.Length; i++)
                {
                    if (pasteText.Substring(i, 1) == "\t")
                    {
                        columnNum++;
                    }
                    if (pasteText.Substring(i, 1) == "\n")
                    {
                        rowNum++;
                    }
                }
                object[,] data;
                if (pasteText.Substring(pasteText.Length - 1, 1) == "\n")
                {
                    rowNum = rowNum - 1;
                }
                columnNum = columnNum / (rowNum + 1);
                data = new object[rowNum + 1, columnNum + 1];

                string rowStr;
                for (int i = 0; i < (rowNum + 1); i++)
                {
                    for (int colIndex = 0; colIndex < (columnNum + 1); colIndex++)
                    {
                        rowStr = null;
                        if (colIndex == columnNum && pasteText.IndexOf("\r") != -1)
                        {
                            rowStr = pasteText.Substring(0, pasteText.IndexOf("\r"));
                        }
                        if (colIndex == columnNum && pasteText.IndexOf("\r") == -1)
                        {
                            rowStr = pasteText.Substring(0);
                        }
                        if (colIndex != columnNum)
                        {
                            rowStr = pasteText.Substring(0, pasteText.IndexOf("\t"));
                            pasteText = pasteText.Substring(pasteText.IndexOf("\t") + 1);
                        }
                        if (rowStr == string.Empty)
                            rowStr = null;
                        data[i, colIndex] = rowStr;
                    }
                    pasteText = pasteText.Substring(pasteText.IndexOf("\n") + 1);
                }
                int columnindex = -1, rowindex = -1;
                int columnindextmp = -1, rowindextmp = -1;
                if (dgv.SelectedCells.Count != 0)
                {
                    columnindextmp = dgv.SelectedCells[0].ColumnIndex;
                    rowindextmp = dgv.SelectedCells[0].RowIndex;
                }
                foreach (DataGridViewCell cell in dgv.SelectedCells)
                {

                    columnindex = cell.ColumnIndex;
                    if (columnindex > columnindextmp)
                    {
                        columnindex = columnindextmp;
                    }
                    else
                        columnindextmp = columnindex;
                    rowindex = cell.RowIndex;
                    if (rowindex > rowindextmp)
                    {
                        rowindex = rowindextmp;
                        rowindextmp = rowindex;
                    }
                    else
                        rowindextmp = rowindex;
                }
                if (kind == -1)
                {
                    columnindex = 0;
                    rowindex = 0;
                }

                if (rowindex + rowNum + 1 > dgv.RowCount)
                {
                    int mm = rowNum + rowindex + 1 - dgv.RowCount;
                    for (int ii = 0; ii < mm + 1; ii++)
                    {
                        dgv.DataBindings.Clear();

                        dgv.Rows.Add();
                    }
                }

                if (columnindex + columnNum + 1 > dgv.ColumnCount)
                {
                    int mmm = columnNum + columnindex + 1 - dgv.ColumnCount;
                    for (int iii = 0; iii < mmm; iii++)
                    {
                        dgv.DataBindings.Clear();
                        DataGridViewTextBoxColumn colum = new DataGridViewTextBoxColumn();
                        dgv.Columns.Insert(columnindex + 1, colum);
                    }
                }

                for (int j = 0; j < (rowNum + 1); j++)
                {
                    for (int colIndex = 0; colIndex < (columnNum + 1); colIndex++)
                    {
                        if (colIndex + columnindex < dgv.Columns.Count)
                        {
                            if (dgv.Columns[colIndex + columnindex].CellType.Name == "DataGridViewTextBoxCell")
                            {
                                if (dgv.Rows[j + rowindex].Cells[colIndex + columnindex].ReadOnly == false)
                                {
                                    dgv.Rows[j + rowindex].Cells[colIndex + columnindex].Value = data[j, colIndex];
                                    dgv.Rows[j + rowindex].Cells[colIndex + columnindex].Selected = true;
                                }
                            }
                        }
                    }
                }
                if (b_cut)
                    Clipboard.Clear();
                return 1;
            }
            catch
            {
                return -1;
            }
        }
    }
}
