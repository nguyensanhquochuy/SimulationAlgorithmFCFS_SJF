
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Guna.UI2.WinForms;

namespace MophongFCFS_SJF
{
    public partial class FormFCFS : Form
    {
        private TienTrinh[] _dsTT = new TienTrinh[100]; // khời tạo 1 danh sách tiến trình
        private int _sumWaitTime = 0, _sumTurnaroundTime = 0;
        private int n = 0;
        int[] khoangcach = new int[100];
        float[] sophantram = new float[100];

        public FormFCFS()
        {
            InitializeComponent();
            cboType.SelectedIndex = 0;
        }
        private string CreateID()
        {
            if (dgvInput.RowCount == 0)
                return "P1";
            string oldID = dgvInput.Rows[dgvInput.RowCount - 1].Cells[0].Value.ToString();
            oldID = oldID.Substring(1);
            return "P" + (Convert.ToInt32(oldID) + 1);
        }
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0)
            {
                lblArrivalTime.Visible = nudArrivalTime.Visible = false;
                colInputArrivalTime.Visible = false;
                colOutputArrivalTime.Visible = colOutputCompletionTime.Visible = false;
            }
            else
            {
                lblArrivalTime.Visible = nudArrivalTime.Visible = true;
                colInputArrivalTime.Visible = true;
                colOutputArrivalTime.Visible = colOutputCompletionTime.Visible = true;
            }
        }
        private void dgvInput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInput.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvInput.SelectedRows[0];
                txtProcess.Text = row.Cells[0].Value.ToString();
                nudBurstTime.Value = Convert.ToInt32(row.Cells[2].Value);
                if (cboType.SelectedIndex == 1)
                    nudArrivalTime.Value = Convert.ToInt32(row.Cells[1].Value);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

                txtProcess.Text = CreateID();
                DataGridViewRow row = new DataGridViewRow();
                if (cboType.SelectedIndex == 0)
                    row.CreateCells(dgvInput, new object[] { txtProcess.Text, 0, nudBurstTime.Value });
                else
                    row.CreateCells(dgvInput, new object[] { txtProcess.Text, nudArrivalTime.Value, nudBurstTime.Value });
                dgvInput.Rows.Add(row);
                 txtProcess.Text = CreateID();
            
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInput.RowCount; i++)
                if (txtProcess.Text == dgvInput.Rows[i].Cells[0].Value.ToString())
                {
                    if (cboType.SelectedIndex == 0)
                        dgvInput.Rows[i].Cells[2].Value = Convert.ToInt32(nudBurstTime.Value);
                    else
                    {
                        dgvInput.Rows[i].Cells[1].Value = Convert.ToInt32(nudArrivalTime.Value);
                        dgvInput.Rows[i].Cells[2].Value = Convert.ToInt32(nudBurstTime.Value);
                    }
                }
            txtProcess.Text = CreateID();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvInput.Rows.Clear();
            txtProcess.Text = CreateID();
        }
        private void InputDataGridViewToArray()
        {
            n = dgvInput.RowCount;
            
            _dsTT = new TienTrinh[n];
            for (int i = 0; i < n; i++)
            {
                int arrivalTime = (cboType.SelectedIndex == 0) ? 0 : Convert.ToInt32(dgvInput.Rows[i].Cells[1].Value);
                _dsTT[i] = new TienTrinh(
                    i+1, // ID
                    arrivalTime, // Arrival time
                    Convert.ToInt32(dgvInput.Rows[i].Cells[2].Value)  // Burst Time
                );
            }
        }
        private void PrintArrayToOutput()
        {
            dgvOutput.Rows.Clear();
            for (int i = 0; i < n; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvOutput, new object[] { "P"+_dsTT[i].ID, _dsTT[i].ArrivalTime, _dsTT[i].BurstTime, _dsTT[i].WaitTime, _dsTT[i].TurnaroundTime, _dsTT[i].FinishTime });
                dgvOutput.Rows.Add(row);
            }
        }

    
        public void TinhToan_FCFS_SJF_NoArrivalTime()
        {
            SapXepTT_ID();
            _sumWaitTime = 0; _sumTurnaroundTime = 0;
            _dsTT[0].WaitTime = 0;
            for (int i = 1; i < n; i++)
            {
                _dsTT[i].WaitTime = _dsTT[i - 1].WaitTime + _dsTT[i - 1].BurstTime;
            }
            for (int i = 0; i < n; i++)
            {
                _dsTT[i].TurnaroundTime = _dsTT[i].WaitTime + _dsTT[i].BurstTime;
                _sumWaitTime += _dsTT[i].WaitTime;
                _sumTurnaroundTime += _dsTT[i].TurnaroundTime;
            }
        }
        public void DieuPhoiFCFS() // Điều phối tiến trình theo giải thuật FCFS
        {
            _sumWaitTime = 0; _sumTurnaroundTime = 0;
            SapXepTT_ArrivalTime();  // Sắp xếp tiến trình theo thời gian đến

            // Tính thời gian kết thúc và thời gian chờ của tiến trình đầu tiên
            _dsTT[0].FinishTime = _dsTT[0].ArrivalTime + _dsTT[0].BurstTime;
            _dsTT[0].WaitTime = 0;

            // Tính thời gian kết thúc và thời gian chờ của các tiến trình còn lại 
            for (int i = 1; i < n; i++)
            {
                // Nếu thời gian đến của tiến trình này lớn hơn thời gian kết thúc của tiến trình trước đó 
                // thì thời gian kết thúc của tiến trình này = thời gian đến của tiến trình + thời gian CPU Burst của tiến trình
                if (_dsTT[i].ArrivalTime > _dsTT[i - 1].FinishTime)
                {
                    _dsTT[i].FinishTime = _dsTT[i].ArrivalTime + _dsTT[i].BurstTime;
                }
                // Ngược lại
                // thì thời gian kết thúc của tiến trình = thời gian kết thúc của tiến trình trước + thời gian CPU Burst của tiến trình
                else
                {
                    _dsTT[i].FinishTime = _dsTT[i - 1].FinishTime + _dsTT[i].BurstTime;
                }
                // Tính thời gian chờ của tiến trình = thời gian kết thúc của tiến trình trước - thời gian đến của tiến trình
                _dsTT[i].WaitTime = _dsTT[i - 1].FinishTime - _dsTT[i].ArrivalTime;

                // Phép trừ có thể có số âm do thời gian đến của tiến trình lớn hơn thời gian kết thúc
                // của tiến trình trước nên đặt lại thời gian chờ = 0 
                if (_dsTT[i].WaitTime < 0)
                {
                    _dsTT[i].WaitTime = 0;
                }
            }

            // Tính thời gian hoàn thành của các tiến trình (= thời gian kết thúc - thời gian đến của tiến trình đó)
            for (int i = 0; i < n; i++)
            {
                _dsTT[i].TurnaroundTime = _dsTT[i].FinishTime - _dsTT[i].ArrivalTime;
                _sumWaitTime += _dsTT[i].WaitTime;  // Tính tổng thời gian chờ của các tiến trình
                _sumTurnaroundTime += _dsTT[i].TurnaroundTime;  // Tính tổng thời gian hoàn thành của các tiến trình
            }
        }

        public void AverageTime()
        {       
            lblAverageWaiting.Text = "Thời gian chờ trung bình: " + Math.Round((_sumWaitTime * 1.0 / n),2).ToString() +" ms";
            lblAverageTurnAround.Text = "Thời gian hoàn thành trung bình: " + Math.Round((_sumTurnaroundTime * 1.0 / n),2).ToString()+" ms";
        }

        public void GanntChar_NonArrivalTime()
        {
            
            khoangcach[0] = _dsTT[0].TurnaroundTime;
            for (int i = 1; i < n; i++)
            {
                khoangcach[i] = _dsTT[i].TurnaroundTime - _dsTT[i-1].TurnaroundTime;
            }
            int sumkhoangcach = _dsTT[n - 1].TurnaroundTime;
            for(int i = 0; i < n; i++)
            {
                sophantram[i] = (float) khoangcach[i] / sumkhoangcach; 
            }

            Label[] lb = new Label[n];

            float w = sophantram[0] * lblGanntChar.Size.Width;   
            Random rand = new Random();
            lb[0] = new Label()
            {
                Text = "P" + _dsTT[0].ID,
                Location = new Point(lblGanntChar.Location.X, lblGanntChar.Location.Y),
                Size = new Size((int)(w), lblGanntChar.Size.Height),
                BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            grbAnswer.Controls.Add(lb[0]);
            lb[0].BringToFront();
            lb[0].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            for (int i = 1; i < n; i++)
            {
                w = (sophantram[i] * lblGanntChar.Size.Width);

                lb[i] = new Label();

                lb[i].Location = new Point(lb[i - 1].Location.X + lb[i - 1].Size.Width, lblGanntChar.Location.Y);
                lb[i].Text = "P"+_dsTT[i].ID;
                lb[i].Size = new Size((int)(w), lblGanntChar.Size.Height); 

                lb[i].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                lb[i].TextAlign = ContentAlignment.MiddleCenter;
                grbAnswer.Controls.Add(lb[i]);
                lb[i].BringToFront();
                lb[i].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }






            ////  VE moc thoi gian ket thuc tren Gannt Char
            w = sophantram[0] * lblGanntChar.Size.Width;
            
            Label[] lblTime = new Label[n + 1];

            lblTime[0] = new Label()
            {
                Text = _dsTT[0].ArrivalTime.ToString(),
                Location = new Point(lblGanntChar.Location.X -10, lblGanntChar.Location.Y + 40),
                Size = new Size((int)(w), 20),
                BackColor = Color.OldLace,
                TextAlign = ContentAlignment.MiddleLeft
            };
            grbAnswer.Controls.Add(lblTime[0]);
            lblTime[0].BringToFront();
            lblTime[0].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            for (int i = 1; i < n ; i++)
            {
                w = sophantram[i] * lblGanntChar.Size.Width;
                lblTime[i] = new Label();
                lblTime[i].Location = new Point(lb[i-1].Location.X + lb[i-1].Size.Width-10, lblGanntChar.Location.Y + 40);
                lblTime[i].Text = _dsTT[i-1].TurnaroundTime.ToString();
                lblTime[i].Size = new Size((int)(w), 20);

                lblTime[i].BackColor = Color.OldLace;
                lblTime[i].TextAlign = ContentAlignment.MiddleLeft;
                grbAnswer.Controls.Add(lblTime[i]);
                lblTime[i].BringToFront();
                lblTime[i].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            lblTime[n] = new Label();
            lblTime[n].Location = new Point(lb[n - 1].Location.X + lb[n - 1].Size.Width -10, lblGanntChar.Location.Y + 40);
            lblTime[n].Text = _dsTT[n - 1].TurnaroundTime.ToString();
            lblTime[n].Size = new Size(30, 20);

            lblTime[n].BackColor = Color.OldLace;
            lblTime[n].TextAlign = ContentAlignment.MiddleCenter;
            grbAnswer.Controls.Add(lblTime[n]);
            lblTime[n].BringToFront();
            lblTime[n].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public void Ve(int w)
        {
            for (int a = 0; a <= (int)(float)(w / 5.555); a++)
            {
                lblKhung.Text += ' ';
            }
        }



        public void GanntChar_ArrivalTime()
        {
            int count = 0,k;
            if (_dsTT[0].ArrivalTime > 0) count++;
            for (int i = 1; i < n; i++)
            {
                if (_dsTT[i].ArrivalTime > _dsTT[i - 1].FinishTime)
                {
                    count++;
                }
            }

            if (_dsTT[0].ArrivalTime > 0)
            {
                khoangcach[0] = _dsTT[0].ArrivalTime;
                khoangcach[1] = _dsTT[0].FinishTime - _dsTT[0].ArrivalTime;
                k = 2;
            }
            else
            {
                khoangcach[0] = _dsTT[0].FinishTime;
                k = 1;
            }

            int j = 1;
            for (int i=k; i < n + count; i++)
            {
                if (_dsTT[j].ArrivalTime > _dsTT[j - 1].FinishTime)
                {
                    khoangcach[i] = _dsTT[j].ArrivalTime - _dsTT[j - 1].FinishTime;
                    i++;
                    khoangcach[i] = _dsTT[j].FinishTime - _dsTT[j].ArrivalTime;
                }
                else
                {
                    khoangcach[i] = _dsTT[j].FinishTime - _dsTT[j - 1].FinishTime;
                }
                j++;
            }
            int sumkhoangcach = _dsTT[n - 1].FinishTime;
            for (int i = 0; i < n+count; i++)
            {
                sophantram[i] = (float)khoangcach[i] / sumkhoangcach;
            }



            Label[] lb = new Label[n+count];

            float w = sophantram[0] * lblGanntChar.Size.Width;

            Random rand = new Random();
            if (_dsTT[0].ArrivalTime > 0)
            {
  
                lb[0] = new Label()
                {
                    Text = "",
                    Location = new Point(lblGanntChar.Location.X, lblGanntChar.Location.Y),
                    Size = new Size((int)(w), lblGanntChar.Size.Height),
                    BackColor = Color.AliceBlue
                };
                grbAnswer.Controls.Add(lb[0]);
                lb[0].BringToFront();
                lb[0].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                w = sophantram[1] * lblGanntChar.Size.Width;

                lb[1] = new Label()
                {
                    Text = "P" + _dsTT[0].ID,
                    Location = new Point(lb[0].Location.X + lb[0].Size.Width, lblGanntChar.Location.Y),
                    Size = new Size((int)(w), lblGanntChar.Size.Height),
                    BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)),
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                k = 2;

                grbAnswer.Controls.Add(lb[1]);
                lb[1].BringToFront();
                lb[1].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else
            {

                lb[0] = new Label()
                {
                    Text = "P" + _dsTT[0].ID,
                    Location = new Point(lblGanntChar.Location.X, lblGanntChar.Location.Y),
                    Size = new Size((int)(w), lblGanntChar.Size.Height),
                    BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)),
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                grbAnswer.Controls.Add(lb[0]);
                lb[0].BringToFront();
                lb[0].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                k = 1;
    
            }

            j = 1;
            for (int i = k; i < n + count; i++)
            {
                w = (sophantram[i] * lblGanntChar.Size.Width);
                if (_dsTT[j].ArrivalTime > _dsTT[j - 1].FinishTime)
                {



                    lb[i] = new Label();
                    lb[i].Location = new Point(lb[i - 1].Location.X + lb[i - 1].Size.Width, lblGanntChar.Location.Y);
                    lb[i].Text = "";
                    lb[i].Size = new Size((int)(w), lblGanntChar.Size.Height);
                    lb[i].BackColor = Color.AliceBlue;
                    grbAnswer.Controls.Add(lb[i]);
                    lb[i].BringToFront();
                    lb[i].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    i++;
                    w = (sophantram[i] * lblGanntChar.Size.Width);


                    lb[i] = new Label();
                    lb[i].Location = new Point(lb[i - 1].Location.X + lb[i - 1].Size.Width, lblGanntChar.Location.Y);
                    lb[i].Text = "P" + _dsTT[j].ID;
                    lb[i].Size = new Size((int)(w), lblGanntChar.Size.Height);
                    lb[i].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    lb[i].TextAlign = ContentAlignment.MiddleCenter;
                    grbAnswer.Controls.Add(lb[i]);
                    lb[i].BringToFront();
                    lb[i].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {


                    lb[i] = new Label();
                    lb[i].Location = new Point(lb[i - 1].Location.X + lb[i - 1].Size.Width, lblGanntChar.Location.Y);
                    lb[i].Text = "P" + _dsTT[j].ID;
                    lb[i].Size = new Size((int)(w), lblGanntChar.Size.Height);
                    lb[i].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    lb[i].TextAlign = ContentAlignment.MiddleCenter;
                    grbAnswer.Controls.Add(lb[i]);
                    lb[i].BringToFront();
                    lb[i].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                j++;
            }



            w = sophantram[0] * lblGanntChar.Size.Width;
            
            Label[] lblTime = new Label[n + count+1];

            if (_dsTT[0].ArrivalTime > 0)
            {
                lblTime[0] = new Label()
                {
                    Text = "0",
                    Location = new Point(lblGanntChar.Location.X-10, lblGanntChar.Location.Y + 40),
                    Size = new Size((int)(w), 20),
                    BackColor = Color.OldLace,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                grbAnswer.Controls.Add(lblTime[0]);
                lblTime[0].BringToFront();
                lblTime[0].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                w = sophantram[1] * lblGanntChar.Size.Width;
                lblTime[1] = new Label()
                {
                    Text = _dsTT[0].ArrivalTime.ToString(),
                    Location = new Point(lb[0].Location.X + lb[0].Size.Width - 10, lblGanntChar.Location.Y + 40),
                    Size = new Size((int)(w), 20),
                    BackColor = Color.OldLace,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                grbAnswer.Controls.Add(lblTime[1]);
                lblTime[1].BringToFront();
                lblTime[1].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                w = sophantram[2] * lblGanntChar.Size.Width;


                lblTime[2] = new Label()
                {
                    Text = _dsTT[0].FinishTime.ToString(),
                    Location = new Point(lb[1].Location.X + lb[1].Size.Width - 10 , lblGanntChar.Location.Y + 40),
                    Size = new Size((int)(w), 20),
                    BackColor = Color.OldLace,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                grbAnswer.Controls.Add(lblTime[2]);
                lblTime[2].BringToFront();
                lblTime[2].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                k =3;


            }
            else
            {
               
                lblTime[0] = new Label()
                {
                    Text = _dsTT[0].ArrivalTime.ToString(),
                    Location = new Point(lblGanntChar.Location.X-10, lblGanntChar.Location.Y + 40),
                    Size = new Size((int)(w), 20),
                    BackColor = Color.OldLace,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                grbAnswer.Controls.Add(lblTime[0]);
                lblTime[0].BringToFront();
                lblTime[0].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                w = sophantram[1] * lblGanntChar.Size.Width;

                lblTime[1] = new Label()
                {
                    Text = _dsTT[0].FinishTime.ToString(),
                    Location = new Point(lb[0].Location.X + lb[0].Size.Width -10 , lblGanntChar.Location.Y + 40),
                    Size = new Size((int)(w), 20),
                    BackColor = Color.OldLace,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                grbAnswer.Controls.Add(lblTime[1]);
                lblTime[1].BringToFront();
                lblTime[1].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                k = 2;

            }

            j = 1;
            for (int i = k; i < n + count; i++)
            {
                w = (sophantram[i] * lblGanntChar.Size.Width);
                if (_dsTT[j].ArrivalTime > _dsTT[j - 1].FinishTime)
                {
                    
                    lblTime[i] = new Label();
                    lblTime[i].Location = new Point(lb[i - 1].Location.X + lb[i - 1].Size.Width - 10 , lblGanntChar.Location.Y + 40);
                    lblTime[i].Text = _dsTT[j].ArrivalTime.ToString();
                    lblTime[i].Size = new Size((int)(w), 20);

                    lblTime[i].BackColor = Color.OldLace;
                    lblTime[i].TextAlign = ContentAlignment.MiddleLeft;
                    grbAnswer.Controls.Add(lblTime[i]);
                    lblTime[i].BringToFront();
                    lblTime[i].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    i++;
                    w = (sophantram[i] * lblGanntChar.Size.Width);

                    lblTime[i] = new Label();
                    lblTime[i].Location = new Point(lb[i - 1].Location.X + lb[i - 1].Size.Width - 10 , lblGanntChar.Location.Y + 40);
                    lblTime[i].Text = _dsTT[j].FinishTime.ToString();
                    lblTime[i].Size = new Size((int)(w), 20);

                    lblTime[i].BackColor = Color.OldLace;
                    lblTime[i].TextAlign = ContentAlignment.MiddleLeft;
                    grbAnswer.Controls.Add(lblTime[i]);
                    lblTime[i].BringToFront();
                    lblTime[i].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    lblTime[i] = new Label();
                    lblTime[i].Location = new Point(lb[i - 1].Location.X + lb[i - 1].Size.Width - 10  , lblGanntChar.Location.Y + 40);
                    lblTime[i].Text = _dsTT[j].FinishTime.ToString();
                    lblTime[i].Size = new Size((int)(w), 20);

                    lblTime[i].BackColor = Color.OldLace;
                    lblTime[i].TextAlign = ContentAlignment.MiddleLeft;
                    grbAnswer.Controls.Add(lblTime[i]);
                    lblTime[i].BringToFront();
                    lblTime[i].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            
                j++;
            }

                lblTime[n] = new Label();
                lblTime[n].Location = new Point(lb[n +count- 1].Location.X + lb[n+count - 1].Size.Width -10, lblGanntChar.Location.Y + 40);
                lblTime[n].Text = _dsTT[n-1].FinishTime.ToString();
                lblTime[n].Size = new Size(30, 20);

                lblTime[n].BackColor = Color.OldLace;
                lblTime[n].TextAlign = ContentAlignment.MiddleLeft;
                grbAnswer.Controls.Add(lblTime[n]);
                lblTime[n].BringToFront();
                lblTime[n].Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

























        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            InputDataGridViewToArray();
            if (cboType.SelectedIndex == 0)
            {
                TinhToan_FCFS_SJF_NoArrivalTime();
                GanntChar_NonArrivalTime();
            }
            else if (cboType.SelectedIndex == 1)
            {
                DieuPhoiFCFS();
                GanntChar_ArrivalTime();
                

            }
            
            PrintArrayToOutput();
            AverageTime();
        }
        public void SapXepTT_ArrivalTime()    // Phương thức sắp xếp tăng dần các tiến trình theo thời gian đến 
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (_dsTT[i].ArrivalTime > _dsTT[j].ArrivalTime)
                    {
                        TienTrinh temp = new TienTrinh();
                        temp = _dsTT[i];
                        _dsTT[i] = _dsTT[j];
                        _dsTT[j] = temp;
                    }
                }
            }
        }

        private void lblAverageWaiting_Click(object sender, EventArgs e)
        {

        }

        private void lblGanntChar_Click(object sender, EventArgs e)
        {

        }

        public void SapXepTT_ID()          // Phương thức sắp xếp tăng dần các tiến trình theo ID 
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (_dsTT[i].ID > _dsTT[j].ID)
                    {
                        TienTrinh temp = new TienTrinh();
                        temp = _dsTT[i];
                        _dsTT[i] = _dsTT[j];
                        _dsTT[j] = temp;
                    }
                }
            }
        }
    }
}
