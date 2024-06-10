using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_hình_tron2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double tinhdientich(double bankinh) { return bankinh * bankinh * Math.PI; }
        double tinhchuvi(double bk) { return bk *2* Math.PI; }
        private void btnchuvi_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            double chuvi = tinhchuvi( bankinh);
            lblkq.Text = "chu vi " + Convert.ToString(chuvi);
            lblkq.Text = chuvi.ToString();
        }

        private void btndientich_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            double dientich = tinhdientich( bankinh);
            lblkq.Text = "diện tích " + Convert.ToString(dientich);
            lblkq.Text = dientich.ToString();
        }

        private void btnloai1_Click(object sender, EventArgs e)
        {

            {
                double bankinh = Convert.ToDouble(txtbankinh.Text);
                if (rdbdientich.Checked)
                {
                    double dientich = tinhdientich(bankinh);
                    string thongbao = "-Diện tích " + Convert.ToString(dientich);
                    MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (rdbchuvi.Checked)
                {
                    double chuvi = tinhchuvi(bankinh);
                    string thongbao = "-Chu vi " + Convert.ToString(chuvi);
                    MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnloai2_Click(object sender, EventArgs e)
        {
            {
                double bankinh = Convert.ToDouble(txtbankinh.Text);
                string thongbao = "";
                if (chbdientich.Checked)
                {
                    double dientich = tinhdientich(bankinh);
                    thongbao = thongbao + "-Diện tích " + Convert.ToString(dientich) + Environment.NewLine;
                }
                if (chcchuvi.Checked)
                {
                    double chuvi = tinhchuvi(bankinh);
                    thongbao = thongbao + "-Chu vi " + Convert.ToString(chuvi) + Environment.NewLine;
                }
                if (thongbao.Length > 0)
                {
                    MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    }

