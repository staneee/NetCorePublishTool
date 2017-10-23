﻿using E.StringEx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECode.Forms
{
    public partial class FormRegex : Form
    {
        string RegStr { get; set; } = string.Empty;

        public MatchCollection Mcs { get; set; }


        public FormRegex()
        {
            InitializeComponent();

            BindEvent();
        }

        void BindEvent()
        {
            this.btnExec.Click += BtnExec_Click;

           
            this.dgvResult.SelectionChanged += DgvResult_SelectionChanged;

            this.dgvResult.ReadOnly = true;
            this.dgvResult.MultiSelect = false;

            this.txtSelect.ReadOnly = true;
        }

        private void DgvResult_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResult.SelectedCells.Count > 0)
            {
                var val = string.Empty;


                var temp=dgvResult.SelectedCells[0];

                foreach (DataGridViewCell item in dgvResult.SelectedCells)
                {
                    if (item.Selected)
                    {
                        txtSelect.Text= item.Value.ToString();
                        break;
                    }
                }
            }
        }

        private void BtnExec_Click(object sender, EventArgs e)
        {
            if (txtRegStrs.SelectedText.IsNull())
            {
                var strs = txtRegStrs.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                if (strs != null && strs.Length > 0)
                {
                    RegStr = strs[0];
                }
            }
            else
            {
                RegStr = txtRegStrs.SelectedText;
            }
            if (RegStr.IsNull())
                return;

            Mcs = GetResult(txtSource.Text, RegStr);
        }


        MatchCollection GetResult(string source, string regStr)
        {
            var dt = new DataTable();

            var cols = new List<DataColumn>();
            DataRow row = null;
            var count = 0;

            var mcs = Regex.Matches(source, regStr);
            if (mcs != null && mcs.Count > 0)
            {
                if (mcs[0].Groups != null && mcs[0].Groups.Count > 0)
                {
                    for (int i = 0; i < mcs[0].Groups.Count; i++)
                    {
                        cols.Add(new DataColumn(i.ToString()));
                    }
                }

                dt.Columns.AddRange(cols.ToArray());

                foreach (Match mc in mcs)
                {
                    if (mc.Groups != null && mc.Groups.Count > 0)
                    {
                        row = dt.NewRow();
                        for (int i = 0; i < mc.Groups.Count; i++)
                        {
                            row[i.ToString()] = mc.Groups[i].Value ?? string.Empty;
                        }
                        dt.Rows.Add(row);
                    }
                }

                count = mcs.Count;
            }

            lblCount.Text = $"匹配到 {count} 条数据";
            dgvResult.DataSource = dt;
            return mcs;
        }
    }

}