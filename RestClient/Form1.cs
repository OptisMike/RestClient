namespace RestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI Event Handlers

        async public void buttonGO_Click(object sender, EventArgs e)
        {
            RestClient restClient = new RestClient();
            restClient.endPoint = textBoxRestURL.Text;

            debugOutput("-------REST Client Create");

            string strResponse = string.Empty;

            await Task.Run(() =>
            {
                strResponse = restClient.makeRequest();

                debugOutput(strResponse);
            });            
        }

        #endregion

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                textBoxResponse.Text = textBoxResponse.Text + strDebugText + Environment.NewLine;
                textBoxResponse.SelectionStart = textBoxResponse.TextLength;
                textBoxResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}