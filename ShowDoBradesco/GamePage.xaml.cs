namespace ShowDoBradesco;

public partial class GamePage
{

    Gerenciador gerenciador;
    public GamePage()
    {
        InitializeComponent();

        gerenciador = new Gerenciador(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05, labelNivel, labelPontuacao);
        gerenciador.ProximaQuestao();
    }

    void BtnResp01(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(1);
    }

    void BtnResp02(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(2);
    }

    void BtnResp03(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(3);
    }

    void BtnResp04(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(4);
    }

    void BtnResp05(object sender, EventArgs e)
    {
        gerenciador.VerificaCorreta(5);
    }

    void BtnCartas(object s, EventArgs e)
    {

    }

    void BtnUniversitarios(object s, EventArgs e)
    {

    }

    void BtnTiraum(object s, EventArgs e)
    {

    }
}