#region usings
using System;
using System.Collections.Generic;
using System.Windows.Forms;
#endregion

namespace Answer
{

    #region Classes
    public partial class Form1 : Form
    {
        #region Constants
        /// <summary>
        ///     最高温度
        /// </summary>
        private const int MAX_TEMP = 40;

        /// <summary>
        ///     最低温度
        /// </summary>
        private const int MIN_TEMP = 0;
        #endregion

        #region Instance readonly fields
        /// <summary>
        ///     1回の操作で変更可能な温度
        /// </summary>
        private readonly List<int> _changeTempList = new List<int>();
        #endregion

        #region Instance constructors
        /// <summary>
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();

            this._changeTempList.Add(-10);
            this._changeTempList.Add(-5);
            this._changeTempList.Add(-3);
            this._changeTempList.Add(3);
            this._changeTempList.Add(5);
            this._changeTempList.Add(10);

            this.numericUpDownBeforeTemp.Maximum = Form1.MAX_TEMP;
            this.numericUpDownBeforeTemp.Minimum = Form1.MIN_TEMP;
            this.numericUpDownAfterTemp.Maximum = Form1.MAX_TEMP;
            this.numericUpDownAfterTemp.Minimum = Form1.MIN_TEMP;
        }
        #endregion

        #region Instance methods
        /// <summary>
        ///     計算ボタンクリック時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            this.treeViewAnswer.Nodes.Clear();

            // 現在の設定温度
            var beforeTemp = (int)this.numericUpDownBeforeTemp.Value;
            // 設定したい温度
            var afterTemp = (int)this.numericUpDownAfterTemp.Value;
            this.treeViewAnswer.Nodes.Add(new TreeNode { Text = $"現在の設定温度：{beforeTemp}" + "\n" });
            this.treeViewAnswer.Nodes.Add(new TreeNode { Text = $"設定したい温度：{afterTemp}" + "\n" });

            // 温度と遷移可否を格納
            var dpDc = new Dictionary<int, bool>();
            // 最低温度～最高温度に対しての、遷移可否を表す
            // 最高温度40、最低温度0なら以下のようになる
            // [0, false],[1, false],[2, false]...[現在の設定温度, true]...[39, false],[40, false]
            for (var temp = Form1.MIN_TEMP; temp <= Form1.MAX_TEMP; temp++)
            {
                dpDc[temp] = false;
            }
            // 現在の設定温度は遷移可能とする
            dpDc[beforeTemp] = true;

            // 設定したい温度の遷移可否が true になるまでループ
            // ループした回数イコール、リモコンのボタンを押した回数
            var loopCnt = 0;
            while (dpDc[afterTemp] == false)
            {
                loopCnt++;
                if (100 <= loopCnt)
                {
                    // ループが100回を超えたら設定不可能と判断する
                    this.treeViewAnswer.Nodes.Add(new TreeNode { Text = "設定不可能です。" });
                    return;
                }

                // 現在の設定温度に、変更可能な温度(_changeTempList)を加算した、変更後の設定温度の一覧
                var newTempList = new List<int>();
                // 変更可能な温度(_changeTempList)でループ
                foreach (var changeTemp in this._changeTempList)
                {
                    for (var temp = Form1.MIN_TEMP; temp <= Form1.MAX_TEMP; temp++)
                    {
                        if (dpDc[temp] == false)
                        {
                            continue;
                        }

                        var newTemp = temp + changeTemp;
                        if ((newTemp < Form1.MIN_TEMP) || (Form1.MAX_TEMP < newTemp))
                        {
                            // 変更後の設定温度が上下限に収まっていない場合は NG とする
                            continue;
                        }

                        newTempList.Add(newTemp);
                    }
                }

                var keys = new List<int>(dpDc.Keys);
                foreach (var temp in keys)
                {
                    if (newTempList.Contains(temp))
                    {
                        dpDc[temp] = true;
                    }
                    else
                    {
                        dpDc[temp] = false;
                    }
                }

                if (dpDc[afterTemp])
                {
                    // 設定したい温度に到達
                    break;
                }
            }

            this.treeViewAnswer.Nodes.Add(new TreeNode { Text = $"操作回数：{loopCnt} 回" });
        }
        #endregion
    }
    #endregion
}