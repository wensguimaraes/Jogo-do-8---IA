using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Jogo_do_8
{
    public partial class Form1 : Form
    {
        private string _cadeiaResultado = @"123456780";
        private string _cadeiaProblema = @"123450678";

        private DateTime _tStart;

        //== BUSCA LARGURA
        private Node _nodeResultBuscaLargura;
        private List<string> _listaVisitadosLargura = new List<string>();
        Form frmLarg = new Form();
        ListBox cslWndLarg = new ListBox();
        private int _contAbertosLarg = 0;

        //== BUSCA PROFUNDIDADE ITERATIVA
        private Node _nodeResultBuscaProfundidadeItera;
        private List<string> _listaVisitadosProfundidadeItera = new List<string>();
        Form frmProfItera = new Form();
        ListBox cslWndProfItera  = new ListBox();
        private int _contAbertosProfItera = 0;

        //== BUSCA LARGURA H1
        private Node _nodeResultBuscaLarguraH1;
        private List<string> _listaVisitadosLarguraH1 = new List<string>();
        Form frmLargH1 = new Form();
        ListBox cslWndLargH1 = new ListBox();
        private int _contAbertosLargH1 = 0;

        //== BUSCA PROFUNDIDADE
        private Node _nodeResultBuscaProfundidade;
        private List<string> _listaVisitadosProfundidade = new List<string>();
        Form frmProf = new Form();
        ListBox cslWndProf = new ListBox();
        private int _contAbertosProf = 0;




        private Button _buttonBase;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

            var no1 = new No(1, bt01.Location);
            var no2 = new No(2, bt02.Location);
            var no3 = new No(3, bt03.Location);
            var no4 = new No(4, bt04.Location);
            var no5 = new No(5, bt05.Location);
            var no6 = new No(6, bt06.Location);
            var no7 = new No(7, bt07.Location);
            var no8 = new No(8, bt08.Location);
            var no0 = new No(0, bt00.Location);

            bt01.Tag = no1;
            bt02.Tag = no2;
            bt03.Tag = no3;
            bt04.Tag = no4;
            bt05.Tag = no5;
            bt06.Tag = no6;
            bt07.Tag = no7;
            bt08.Tag = no8;
            bt00.Tag = no0;

            bt01.Click += bt_Click;
            bt02.Click += bt_Click;
            bt03.Click += bt_Click;
            bt04.Click += bt_Click;
            bt05.Click += bt_Click;
            bt06.Click += bt_Click;
            bt07.Click += bt_Click;
            bt08.Click += bt_Click;
            bt00.Click += bt_Click;
            
            _buttonBase = bt00;


            dgvAnimar.Rows.Add();
            dgvAnimar.Rows.Add();
            dgvAnimar.Rows.Add();


        }

        private void bt_Click(object sender, EventArgs e)
        {
            lblError.Text = @"...";
            var bt = (Button) sender;

            if (bt.Name == _buttonBase.Name) return;

            Point currentPoint = bt.Location;

            var fromNo = (No) _buttonBase.Tag;

            if (fromNo.NeighborHood.Any(x => x.X == currentPoint.X && x.Y == currentPoint.Y))
            {
                bt.Location = _buttonBase.Location;
                var currNo = (No) bt.Tag;
                currNo.ChangeNeighborHood(bt.Location);
                bt.Tag = currNo;


                _buttonBase.Location = currentPoint;
                fromNo.ChangeNeighborHood(_buttonBase.Location);
                _buttonBase.Tag = fromNo;

            }
            else
            {
                lblError.Text = @"Movimento inválido;";
            }

            bt00.Focus();
        }
        
        private void btSortear_Click(object sender, EventArgs e)
        {
            var listNewLocations = No.Sortear();
            
            foreach (var control in groupBox1.Controls)
            {
                if (control.GetType() == typeof (Button))
                {
                    ((Button) control).Location = listNewLocations[((Button)control).TabIndex];
                    ((No)((Button)control).Tag).ChangeNeighborHood(((Button)control).Location);
                }
            }


            txtCadeiaProblema.Text = No.GetString(groupBox1);



        }




        private void btRunThreads_Click(object sender, EventArgs e)
        {
            _cadeiaProblema = txtCadeiaProblema.Text;



            if (string.IsNullOrEmpty(_cadeiaProblema) || string.IsNullOrWhiteSpace(_cadeiaProblema))
                return;

            lblProfSteps.Text = @"Steps: ";
            lblLargSteps.Text = @"Steps: ";
            lblLargStepsH1.Text = @"Steps: ";
            lblProfStepsH1.Text = @"Steps: ";


            lblProfExp.Text = @"Abertos: ";
            lblLargExp.Text = @"Abertos: ";
            lblLargExpH1.Text = @"Abertos: ";
            lblProfExpH1.Text = @"Abertos: ";


            _tStart = DateTime.Now;
            timer1.Start();

            ltbCaminhoLagura.Items.Clear();
            threadBuscaEmLargura.RunWorkerAsync();

            ltbCaminhoProfundidadeIter.Items.Clear();
            threadBuscaEmProfundidade.RunWorkerAsync();

            ltbCaminhoLaguraH1.Items.Clear();
            threadBuscaEmLarguraH1.RunWorkerAsync();

            ltbCaminhoProfundidade.Items.Clear();
            threadBuscaEmProfundidadeH1.RunWorkerAsync();


            btRunThreads.Enabled = false;
        }




        #region // Busca em Largura
        private void threadBuscaEmLargura_DoWork(object sender, DoWorkEventArgs e)
        {

            _contAbertosLarg = 0;

            if (ckbAndamento.Checked)
            {
                frmLarg.Text = @"Busca por Largura.:";
                frmLarg.Size = new Size(300, 500);
                cslWndLarg.Parent = frmLarg;
                cslWndLarg.Dock = DockStyle.Fill;
                frmLarg.Show();
            }

            _nodeResultBuscaLargura = null;
            _listaVisitadosLargura.Clear();

            var nd = new Node(_cadeiaProblema, null);

            var fila = new Queue<Node>();

            fila.Enqueue(nd);

            while (fila.Any())
            {
                var currentNode = fila.Dequeue();
                if (ckbAndamento.Checked)
                {
                    cslWndLarg.Items.Add(currentNode.Cadeia);
                    cslWndLarg.Refresh();
                }
                

                if (currentNode.Cadeia == _cadeiaResultado)
                {
                    _nodeResultBuscaLargura = currentNode;
                    return;
                }
                else
                {
                    _listaVisitadosLargura.Add(currentNode.Cadeia);
                    var ndGet = new Node();
                    foreach (var filho in ndGet.GetFilhos(currentNode).Where(filho => !_listaVisitadosLargura.Contains(filho.Cadeia)))
                        fila.Enqueue(filho);
                    //foreach (var filho in Node.GetFilhos(currentNode))
                    //    if (!_listaVisitadosLargura.Contains(filho.Cadeia))
                    //        fila.Enqueue(filho);
                }

                _contAbertosLarg++;

                //==== CANCELA A THREAD
                if (threadBuscaEmLargura.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

            }

            _nodeResultBuscaLargura = null;

        }

        private void threadBuscaEmLargura_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var list = new List<string>();
            ImprimeCaminhoLargura(_nodeResultBuscaLargura, list);
            ltbCaminhoLagura.Items.Clear();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                ltbCaminhoLagura.Items.Add(list[i]);
            }

            lblLargSteps.Text = @"Steps: " + list.Count;

            lblLargExp.Text = @"Abertos: " + _contAbertosLarg;


        }

        public void ImprimeCaminhoLargura(Node nodeResult, List<string> listResult)
        {
            if (nodeResult == null)
                return;


            //listResult.Add(nodeResult.Cadeia);
            //if (nodeResult.NodePai != null)
            //    ImprimeCaminhoLargura(nodeResult.NodePai, listResult);
            while (true)
            {
                listResult.Add(nodeResult.Cadeia);
                if (nodeResult.NodePai != null)
                {
                    nodeResult = nodeResult.NodePai;
                    continue;
                }
                break;
            }


        }

        #endregion

        #region // busca em Profundidade Iterativa
        private void threadBuscaEmProfundidadeItera_DoWork(object sender, DoWorkEventArgs e)
        {
            _contAbertosProfItera = 0;

            if (ckbAndamento.Checked)
            {
                frmProfItera.Text = @"Busca por Profundidade.:";
                frmProfItera.Size = new Size(300, 500);
                cslWndProfItera.Parent = frmProfItera;
                cslWndProfItera.Dock = DockStyle.Fill;
                frmProfItera.Show();
            }

            _nodeResultBuscaProfundidadeItera = null;
            _listaVisitadosProfundidadeItera.Clear();

            var nd = new Node(_cadeiaProblema, null);

            var fila = new Stack<Node>();

            fila.Push(nd);

            while (fila.Any())
            {
                var currentNode = fila.Pop();
                if (ckbAndamento.Checked)
                {
                    cslWndProfItera.Items.Add(currentNode.Cadeia);
                    cslWndProfItera.Refresh();
                }

                

                if (currentNode.Cadeia == _cadeiaResultado)
                {
                    _nodeResultBuscaProfundidadeItera = currentNode;
                    return;
                }
                else
                {
                    _listaVisitadosProfundidadeItera.Add(currentNode.Cadeia);
                    var ndGet = new Node();
                    foreach (var filho in ndGet.GetFilhos(currentNode).Where(filho => !_listaVisitadosProfundidadeItera.Contains(filho.Cadeia)))
                        fila.Push(filho);
                    //foreach (var filho in Node.GetFilhos(currentNode))
                    //    if (!_listaVisitadosProfundidade.Contains(filho.Cadeia))
                    //        fila.Push(filho);
                }

                _contAbertosProfItera++;

                //==== CANCELA A THREAD
                if (threadBuscaEmProfundidade.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }

            _nodeResultBuscaProfundidadeItera = null;

        }

        private void threadBuscaEmProfundidadeItera_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var list = new List<string>();
            ImprimeCaminhoProfundidadeItera(_nodeResultBuscaProfundidadeItera, list);
            ltbCaminhoProfundidadeIter.Items.Clear();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                ltbCaminhoProfundidadeIter.Items.Add(list[i]);
            }

            lblProfSteps.Text = @"Steps: " + list.Count;
            lblProfExp.Text = @"Abertos: " + _contAbertosProfItera;

        }

        public void ImprimeCaminhoProfundidadeItera(Node nodeResult, List<string> listResult)
        {
            if (nodeResult == null)
                return;

            while (true)
            {
                listResult.Add(nodeResult.Cadeia);
                if (nodeResult.NodePai != null)
                {
                    nodeResult = nodeResult.NodePai;
                    continue;
                }
                break;
            }
        }

        #endregion

        #region //  BUSCA EM LARGURA COM H1

        private void threadBuscaEmLarguraH1_DoWork(object sender, DoWorkEventArgs e)
        {

            _contAbertosLargH1 = 0;

            if (ckbAndamento.Checked)
            {
                frmLargH1.Text = @"Busca por Largura.:";
                frmLargH1.Size = new Size(400, 500);
                cslWndLargH1.Parent = frmLargH1;
                cslWndLargH1.Dock = DockStyle.Fill;
                frmLargH1.Show();
            }

            _nodeResultBuscaLarguraH1 = null;
            _listaVisitadosLarguraH1.Clear();

            var nd = new Node(_cadeiaProblema, null);

            var fila = new Queue<Node>();

            fila.Enqueue(nd);

            while (fila.Any())
            {
                var currentNode = fila.Dequeue();
                if (ckbAndamento.Checked)
                {
                    cslWndLargH1.Items.Add(currentNode.Cadeia);
                    cslWndLargH1.Refresh();
                }


                if (currentNode.Cadeia == _cadeiaResultado)
                {
                    _nodeResultBuscaLarguraH1 = currentNode;
                    return;
                }
                else
                {
                    _listaVisitadosLarguraH1.Add(currentNode.Cadeia);
                    var ndGet = new Node();
                    foreach (var filho in ndGet.GetFilhos(currentNode, true).Where(filho => !_listaVisitadosLarguraH1.Contains(filho.Cadeia)).OrderBy(x=> x.H1))
                        fila.Enqueue(filho);

                }

                _contAbertosLargH1++;

                //==== CANCELA A THREAD
                if (threadBuscaEmLarguraH1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

            }

            _nodeResultBuscaLarguraH1 = null;

        }

        private void threadBuscaEmLarguraH1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var list = new List<string>();
            ImprimeCaminhoLarguraH1(_nodeResultBuscaLarguraH1, list);
            ltbCaminhoLaguraH1.Items.Clear();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                ltbCaminhoLaguraH1.Items.Add(list[i]);
            }

            lblLargStepsH1.Text = @"Steps: " + list.Count;

            lblLargExpH1.Text = @"Abertos: " + _contAbertosLargH1;


        }

        public void ImprimeCaminhoLarguraH1(Node nodeResult, List<string> listResult)
        {
            if (nodeResult == null)
                return;
            
            while (true)
            {
                listResult.Add(nodeResult.Cadeia);
                if (nodeResult.NodePai != null)
                {
                    nodeResult = nodeResult.NodePai;
                    continue;
                }
                break;
            }


        }


        #endregion

        #region // busca em Profundidade 
        private void threadBuscaEmProfundidadeH1_DoWork(object sender, DoWorkEventArgs e)
        {
            _contAbertosProf = 0;

            if (ckbAndamento.Checked)
            {
                frmProf.Text = @"Busca por Profundidade..:";
                frmProf.Size = new Size(400, 500);
                cslWndProf.Parent = frmProfItera;
                cslWndProf.Dock = DockStyle.Fill;
                frmProf.Show();
            }

            _nodeResultBuscaProfundidade = null;
            _listaVisitadosProfundidade.Clear();

            var nd = new Node(_cadeiaProblema, null);
            var nivel = 0;
            var nodeResult = RecursivoProfundidade(nd, _listaVisitadosProfundidade, nivel);


            _nodeResultBuscaProfundidade = nodeResult;

        }

        public Node RecursivoProfundidade(Node paiNode, List<string> list, int nivel)
        {
            list.Add(paiNode.Cadeia);
            _contAbertosProfItera++;
            if (paiNode.Cadeia == _cadeiaResultado)
                return paiNode;

            if (nivel >= 20)
                return null;

            var ndGet = new Node();
            var filhos = ndGet.GetFilhos(paiNode);

            if (!filhos.Any()) return null;

            nivel++;
            foreach (var filho in filhos)
            {
                if (list.All(x => x != filho.Cadeia))
                {
                    var rst = RecursivoProfundidade(filho, list, nivel);
                    if (rst != null)
                        return rst;
                }
                        
            }
            nivel--;
            return null;
        }

        private void threadBuscaEmProfundidadeH1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var list = new List<string>();
            ImprimeCaminhoProfundidadeH1(_nodeResultBuscaProfundidade, list);
            ltbCaminhoProfundidade.Items.Clear();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                ltbCaminhoProfundidade.Items.Add(list[i]);
            }

            lblProfStepsH1.Text = @"Steps: " + list.Count;
            lblProfExpH1.Text = @"Abertos: " + _contAbertosProfItera;

        }

        public void ImprimeCaminhoProfundidadeH1(Node nodeResult, List<string> listResult)
        {
            if (nodeResult == null)
                return;

            while (true)
            {
                listResult.Add(nodeResult.Cadeia);
                if (nodeResult.NodePai != null)
                {
                    nodeResult = nodeResult.NodePai;
                    continue;
                }
                break;
            }
        }

        #endregion


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = (DateTime.Now - _tStart).TotalHours.ToString("#00") + @":" + (DateTime.Now - _tStart).Minutes.ToString("00") + @":" + (DateTime.Now - _tStart).Seconds.ToString("00");

            if (threadBuscaEmLargura.IsBusy)
                lblLarg.Text = lblTime.Text;

            if (threadBuscaEmProfundidade.IsBusy)
                lblProf.Text = lblTime.Text;

            if (threadBuscaEmLarguraH1.IsBusy)
                lblLargH1.Text = lblTime.Text;

            if (threadBuscaEmProfundidadeH1.IsBusy)
                lblProfH1.Text = lblTime.Text;

            if (!threadBuscaEmLargura.IsBusy && !threadBuscaEmProfundidade.IsBusy && !threadBuscaEmLarguraH1.IsBusy && !threadBuscaEmProfundidadeH1.IsBusy)
            {
                timer1.Stop();
                btRunThreads.Enabled = true;
            }



        }

        private void btStop_Click(object sender, EventArgs e)
        {
            if (threadBuscaEmLargura.IsBusy)
                threadBuscaEmLargura.CancelAsync();  

            if (threadBuscaEmProfundidade.IsBusy)
                threadBuscaEmProfundidade.CancelAsync();

            if (threadBuscaEmLarguraH1.IsBusy)
                threadBuscaEmLarguraH1.CancelAsync();

            timer1.Stop();
            btRunThreads.Enabled = true;
            
        }

        private void txtCadeiaProblema_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCadeiaProblema.Text))
                return;


            var list = new List<int> { 0,1,2,3,4,5,6,7,8};

            if (txtCadeiaProblema.Text.Length < 9)
            {
                e.Cancel = true;
                return;
            }

            foreach (var carc in txtCadeiaProblema.Text.ToCharArray())
            {
                if (list.Any(x=> x.ToString() == carc.ToString()))
                {
                    list.Remove(Convert.ToInt32(carc.ToString()));
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }

            if (list.Any())
            {
                e.Cancel = true;
                return;
            }

        }

        private void btAnimarLarg_Click(object sender, EventArgs e)
        {
            foreach (var item in ltbCaminhoLagura.Items)
            {
                Thread.Sleep(1000);
                Animar(item.ToString());
                dgvAnimar.Refresh();
            }
            MessageBox.Show(@"Done!");
        }

        private void Animar(string cadeia)
        {

            dgvAnimar.Rows[0].Cells[0].Value = cadeia.Substring(0, 1);
            dgvAnimar.Rows[0].Cells[1].Value = cadeia.Substring(1, 1);
            dgvAnimar.Rows[0].Cells[2].Value = cadeia.Substring(2, 1);

            dgvAnimar.Rows[1].Cells[0].Value = cadeia.Substring(3, 1);
            dgvAnimar.Rows[1].Cells[1].Value = cadeia.Substring(4, 1);
            dgvAnimar.Rows[1].Cells[2].Value = cadeia.Substring(5, 1);

            dgvAnimar.Rows[2].Cells[0].Value = cadeia.Substring(6, 1);
            dgvAnimar.Rows[2].Cells[1].Value = cadeia.Substring(7, 1);
            dgvAnimar.Rows[2].Cells[2].Value = cadeia.Substring(8, 1);

            foreach (DataGridViewRow row in dgvAnimar.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() == @"0")
                    {
                        cell.Style.BackColor = Color.Blue;
                        cell.Style.ForeColor = Color.Empty;
                        dgvAnimar.CurrentCell = cell;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.Empty;
                        cell.Style.ForeColor = Color.Black;
                    }
                }
            }


        }

        private void btAnimarProfInter_Click(object sender, EventArgs e)
        {
            foreach (var item in ltbCaminhoProfundidadeIter.Items)
            {
                Thread.Sleep(1000);
                Animar(item.ToString());
                dgvAnimar.Refresh();
            }
            MessageBox.Show(@"Done!");
        }

        private void btAnimarLargH1_Click(object sender, EventArgs e)
        {
            foreach (var item in ltbCaminhoLaguraH1.Items)
            {
                Thread.Sleep(1000);
                Animar(item.ToString());
                dgvAnimar.Refresh();
            }
            MessageBox.Show(@"Done!");
        }

        private void btAnimarProf_Click(object sender, EventArgs e)
        {
            foreach (var item in ltbCaminhoProfundidade.Items)
            {
                Thread.Sleep(1000);
                Animar(item.ToString());
                dgvAnimar.Refresh();
            }
            MessageBox.Show(@"Done!");
        }
    }
}
