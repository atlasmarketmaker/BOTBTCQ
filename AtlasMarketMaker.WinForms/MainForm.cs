using Newtonsoft.Json;
using RestSharp;
using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtlasMarketMaker.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            var thread = new System.Threading.Thread(dadosPublicos);
            thread.Start();

            var threadA = new System.Threading.Thread(run);
            threadA.Start();


            var aviso = "ATENÇÃO!" + Environment.NewLine + Environment.NewLine;
            aviso += "Siga os passos abaixo para melhor usabilidade!" + Environment.NewLine + Environment.NewLine;
            aviso += "1. Crie uma conta nova na exchange da ATLAS!" + Environment.NewLine;
            aviso += "2. Deposite BTC na sua conta nova!" + Environment.NewLine;
            aviso += "3. Espere os BTC cairem na sua conta, e depois gere as chaves de api no menu conta!" + Environment.NewLine;
            aviso += "4. Você pode dar start no seu robo!" + Environment.NewLine + Environment.NewLine;

            aviso += "* Não nos responsabilizamos por perdas ou ganhos!" + Environment.NewLine + Environment.NewLine;

            aviso += "Obrigado!" + Environment.NewLine;

            MessageBox.Show(aviso, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Show();
        }


        private void dadosPublicos()
        {
            while (true)
            {
                try
                {
                    var client = new RestClient("https://quantum.atlasquantum.com/api/volume");
                    client.Timeout = -1;
                    var request = new RestRequest(Method.GET);
                    IRestResponse response = client.Execute(request);
                    var jsonAsString = response.Content;

                    Newtonsoft.Json.Linq.JContainer json = (Newtonsoft.Json.Linq.JContainer)JsonConvert.DeserializeObject(jsonAsString);

                    this.Text = "Cotação atual BTCQ: " + json[0]["last"].ToString() + " BTC - " + DateTime.Now.ToString();

                    lblLast.Text = json[0]["last"].ToString() + " BTC";
                    lbl24btc.Text = json[0]["baseVolume"].ToString() + " BTC";
                    lbl24btcq.Text = json[0]["quoteVolume"].ToString() + " BTCQ";
                    lblmaior.Text = json[0]["high24hr"].ToString() + " BTC";
                    lblmenor.Text = json[0]["low24hr"].ToString() + " BTC";

                    lblUpdate.Text = "Última atualização: " + DateTime.Now.ToString();
                }
                catch
                {

                }

                Thread.Sleep(3000);
            }
        }

        void log(string value)
        {
            Thread.Sleep(100);
            this.Show();
            this.Refresh();
            try
            {
                var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                var w = new System.IO.StreamWriter(path + "\\" + DateTime.Now.ToString("ddMMyyyy") + ".txt", true);
                w.WriteLine("[" + DateTime.Now.ToString() + "] - " + value);
                w.Close();
                w.Dispose();
            }
            catch
            {

            }
            listBox1.Items.Add("[" + DateTime.Now.ToString() + "] - " + value);


            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
            this.Show();
            this.Refresh();
        }


        static bool isRunning = false;
        public void run()
        {
            while (true)
            {
                try
                {
                    if (isRunning)
                    {
                        var client = new RestClient("https://quantum.atlasquantum.com/api/oauth/token");
                        client.Timeout = -1;
                        var request = new RestRequest(Method.POST);
                        request.AddHeader("Content-Type", "text/plain");
                        request.AddParameter("text/plain", "{\r\n\t\"grant_type\":\"client_credentials\",\r\n\t\"api_key\":\"" + txtID.Text + "\",\r\n\t\"api_secret\":\"" + txtSECRET.Text + "\"\r\n}", ParameterType.RequestBody);
                        IRestResponse response = client.Execute(request);
                        var tokenAsString = response.Content;
                        log(tokenAsString);

                        Newtonsoft.Json.Linq.JContainer jsonToken = (Newtonsoft.Json.Linq.JContainer)JsonConvert.DeserializeObject(tokenAsString);


                        //Balanco BTC
                        client = new RestClient("https://quantum.atlasquantum.com/api/balance/BTC");
                        client.Timeout = -1;
                        request = new RestRequest(Method.POST);
                        request.AddHeader("Authorization", "Bearer " + jsonToken["access_token"]);
                        request.AddHeader("Content-Type", "text/plain");
                        response = client.Execute(request);
                        tokenAsString = response.Content;
                        log(tokenAsString);

                        Newtonsoft.Json.Linq.JContainer jsonBalanceBTC = (Newtonsoft.Json.Linq.JContainer)JsonConvert.DeserializeObject(tokenAsString);

                        label7.Text = jsonBalanceBTC["available"].ToString() + " BTC";


                        //Balanco BTCQ
                        client = new RestClient("https://quantum.atlasquantum.com/api/balance/BTCQ");
                        client.Timeout = -1;
                        request = new RestRequest(Method.POST);
                        request.AddHeader("Authorization", "Bearer " + jsonToken["access_token"]);
                        request.AddHeader("Content-Type", "text/plain");
                        response = client.Execute(request);
                        tokenAsString = response.Content;
                        log(tokenAsString);

                        Newtonsoft.Json.Linq.JContainer jsonBalanceBTCQ = (Newtonsoft.Json.Linq.JContainer)JsonConvert.DeserializeObject(tokenAsString);
                        label8.Text = jsonBalanceBTCQ["available"].ToString() + " BTCQ";


                        //Order BTCQ
                        client = new RestClient("https://quantum.atlasquantum.com/api/orders/BTC-BTCQ");
                        client.Timeout = -1;
                        request = new RestRequest(Method.POST);
                        request.AddHeader("Authorization", "Bearer " + jsonToken["access_token"]);
                        request.AddHeader("Content-Type", "text/plain");
                        response = client.Execute(request);
                        tokenAsString = response.Content;
                        log(tokenAsString);

                        Newtonsoft.Json.Linq.JContainer jsonOrder = (Newtonsoft.Json.Linq.JContainer)JsonConvert.DeserializeObject(tokenAsString);

                        bool isSell = false;
                        foreach (var item in jsonOrder["result"])
                        {
                            if (item["type"].ToString().Trim().ToUpper() == "SELL")
                                if (item["status"].ToString().Trim().ToUpper() == "OPEN")
                                {
                                    isSell = true;
                                }
                        }


                        if (!isSell)
                        {

                            log("#### Nova operação! ####");
                            //Vamos criar uma ordem e comprar
                            client = new RestClient("https://quantum.atlasquantum.com/api/orderbook/BTC-BTCQ");
                            client.Timeout = -1;
                            request = new RestRequest(Method.GET);
                            response = client.Execute(request);
                            var jsonAsString = response.Content;

                            Newtonsoft.Json.Linq.JContainer orderBook = (Newtonsoft.Json.Linq.JContainer)JsonConvert.DeserializeObject(jsonAsString);

                            double acumulado = 0;
                            double lastRate = 0;
                            foreach (var item in orderBook["result"]["Ask"])
                            {
                                acumulado += double.Parse(item["Rate"].ToString(), NumberStyles.Float) * double.Parse(item["Quantity"].ToString(), NumberStyles.Float);
                                if (acumulado > double.Parse(txtBTC.Text, NumberStyles.Float))
                                {
                                    if (lastRate == 0)
                                        lastRate = double.Parse(item["Rate"].ToString(), NumberStyles.Float);

                                    double total = Math.Round(double.Parse(txtBTC.Text, NumberStyles.Float) / lastRate, 8);
                                    log("Vamos comprar " + total + " BTCQ por " + lastRate + " BTC...");


                                    client = new RestClient("https://quantum.atlasquantum.com/api/buy");
                                    client.Timeout = -1;
                                    request = new RestRequest(Method.POST);
                                    request.AddHeader("Authorization", "Bearer " + jsonToken["access_token"]);
                                    request.AddHeader("Content-Type", "text/plain");
                                    request.AddParameter("text/plain", "{\r\n\t\"symbol\":\"BTC-BTCQ\",\r\n\t\"quantity\":" + total.ToString().Replace(",", ".") + ",\r\n\t\"price\":" + lastRate.ToString().Replace(",", ".") + ",\r\n\t\"type\":\"LIMIT\"\r\n}", ParameterType.RequestBody);
                                    response = client.Execute(request);
                                    var jsonAsStringBuy = response.Content;

                                    log(jsonAsStringBuy);

                                    client = new RestClient("https://quantum.atlasquantum.com/api/balance/BTCQ");
                                    client.Timeout = -1;
                                    request = new RestRequest(Method.POST);
                                    request.AddHeader("Authorization", "Bearer " + jsonToken["access_token"]);
                                    request.AddHeader("Content-Type", "text/plain");
                                    response = client.Execute(request);
                                    tokenAsString = response.Content;
                                    log(tokenAsString);

                                    jsonBalanceBTCQ = (Newtonsoft.Json.Linq.JContainer)JsonConvert.DeserializeObject(tokenAsString);
                                    label8.Text = jsonBalanceBTCQ["available"].ToString() + " BTCQ";


                                    double fee = double.Parse(txtFEE.Text, NumberStyles.Float) * 2;
                                    double profit = double.Parse(txtProfit.Text, NumberStyles.FLoat);
                                    double valueSell = Math.Round(lastRate + ((lastRate * (fee + profit)) / 100), 8);
                                    log("Vamos vender por " + valueSell + "...");
                                    client = new RestClient("https://quantum.atlasquantum.com/api/sell");
                                    client.Timeout = -1;
                                    request = new RestRequest(Method.POST);
                                    request.AddHeader("Authorization", "Bearer " + jsonToken["access_token"]);
                                    request.AddHeader("Content-Type", "text/plain");
                                    request.AddParameter("text/plain", "{\r\n\t\"symbol\":\"BTC-BTCQ\",\r\n\t\"quantity\":" + jsonBalanceBTCQ["available"].ToString().Replace(",", ".") + ",\r\n\t\"price\":" + lastRate.ToString().Replace(",", ".") + ",\r\n\t\"type\":\"LIMIT\"\r\n}", ParameterType.RequestBody);
                                    response = client.Execute(request);
                                    var jsonAsStringSell = response.Content;

                                    log(jsonAsStringSell);
                                    break;

                                }

                            }


                        }
                        else
                        {
                            log("Você já possui ordem de vendas, o robo esta esperando executar...");
                        }
                    }
                }
                catch
                {

                }

                Thread.Sleep(3500);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var client = new RestClient("https://quantum.atlasquantum.com/api/oauth/token");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "text/plain");
                request.AddParameter("text/plain", "{\r\n\t\"grant_type\":\"client_credentials\",\r\n\t\"api_key\":\"" + txtID.Text + "\",\r\n\t\"api_secret\":\"" + txtSECRET.Text + "\"\r\n}", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                var tokenAsString = response.Content;
                log(tokenAsString);

                var jsonToken = (Newtonsoft.Json.Linq.JContainer)JsonConvert.DeserializeObject(tokenAsString);


                //Balanco BTC
                client = new RestClient("https://quantum.atlasquantum.com/api/balance/BTC");
                client.Timeout = -1;
                request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", "Bearer " + jsonToken["access_token"]);
                request.AddHeader("Content-Type", "text/plain");
                response = client.Execute(request);
                tokenAsString = response.Content;
                log(tokenAsString);

                var jsonBalanceBTC = (Newtonsoft.Json.Linq.JContainer)JsonConvert.DeserializeObject(tokenAsString);

                label7.Text = jsonBalanceBTC["available"].ToString() + " BTC";


                if (double.Parse(txtBTC.Text, NumberStyles.Float) > double.Parse(jsonBalanceBTC["available"].ToString(), NumberStyles.Float))
                {
                    MessageBox.Show("Seu SALDO de BITCOIN é inferior ao total que você colocou no campo (Maximo de BTC usado na sua wallet) verifique!");
                    return;
                }

                try
                {
                    double.Parse(txtFEE.Text);
                }
                catch
                {
                    MessageBox.Show("Campo fee errado! Por favor verifique!");
                    return;
                }

                try
                {
                    double.Parse(txtProfit.Text);
                }
                catch
                {
                    MessageBox.Show("Campo profit errado! Por favor verifique!");
                    return;
                }

                if (txtID.Text == "" || txtSECRET.Text == "")
                {
                    MessageBox.Show("Você deve preencher o campo ID e SECRET!");
                    return;
                }

                button2.Enabled = true;
                button1.Enabled = false;
                isRunning = true;
                label10.Text = "Status: INICIADO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                log(ex.Message + ex.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Enabled = false;
                button1.Enabled = true;
                isRunning = false;
                label10.Text = "Status: PARADO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                log(ex.Message + ex.StackTrace);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/robobtcq/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/atlasmarketmaker/");
        }
    }
}
