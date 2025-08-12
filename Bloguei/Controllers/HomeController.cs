using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bloguei.Models;

namespace Bloguei.Controllers;

//: Controller: herda da classe Controller, ou seja, essa classe ganha todos os comportamentos básicos de um controller do ASP.NET MVC
public class HomeController : Controller
{
    // Cria um objeto chamado logger que é somente de leitura. 
    private readonly ILogger<HomeController> _logger;

    // Método construtor: cria objeto na memória
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Mensagem"] = "Divas!";
        // Criar objetos
        Categoria closet = new();
        closet.Id = 1;
        closet.Nome = "Closet dos Sonhos";

        Categoria glow = new()
        {
            Id = 2,
            Nome = "Glow Up"
        };

        Categoria corpo = new()
        {
            Id = 3,
            Nome = "Corpo & Alma"
        };

        Categoria segredos = new()
        {
            Id = 4,
            Nome = "Segredos & Crushes"
        };

        List<Postagem> postagens = [
            new(){
                Id = 1,
                Nome = "5 Looks que Vão Fazer Você Se Sentir Personagem Principal",
                CategoriaId = 1,
                Categoria = closet,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Prepare-se para transformar o seu armário em um cenário de filme teen! Separei 5 combinações de looks que são a cara de quem quer brilhar no dia a dia — seja na escola, no shopping ou até naquele rolê de última hora.",
                Texto = "Sabe aquele momento em que você abre o armário e pensa: Não tenho nada para vestir? Pois é… a verdade é que muitas vezes a gente só precisa de inspiração para dar um up nas peças que já temos. E é aqui que o nosso Closet dos Sonhos entra em ação!<br>Hoje, eu trouxe 5 ideias de looks que vão fazer você se sentir a personagem principal da sua própria história:<br><br>1. Look Coffee Date<br>Saia plissada + suéter oversized + tênis branco. Perfeito para um dia friozinho, mas ainda com aquele ar fofinho de comédia romântica.<br><br>2. Look Estrela da Escola<br>Calça jeans wide leg + camiseta gráfica + jaqueta bomber. Estiloso, confortável e perfeito para passar o dia correndo entre as aulas e o intervalo.<br><br>3. Look Shopping com as Besties<br>Vestido midi floral + sandália plataforma + bolsa baguete.Combinação que grita “dia de fotos no espelho das lojas”.<br><br>Dica bônus: Não é sobre ter um armário lotado, mas sim sobre combinar o que você tem de um jeito novo. Teste combinações diferentes, adicione acessórios e, acima de tudo, use o que faz você se sentir incrível.<br><br>E aí, qual desses looks vai ser o seu próximo favorito?"
            },

            new(){
                Id = 2,
                Nome = "7 Passos para um Glow Up que Vai Fazer Você Brilhar de Verdade",
                CategoriaId = 2,
                Categoria = glow,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Quer mudar o visual, melhorar sua autoestima e se sentir a protagonista da sua própria história? Confira um guia simples e divertido para conquistar um glow up de dentro pra fora!",
                Texto = "Glow up não é só sobre mudar o cabelo ou comprar roupas novas — é sobre se transformar de um jeito que te faça se sentir bem todos os dias. É um processo que mistura autocuidado, autoconhecimento e um toque de estilo. Aqui vão 7 passos para começar o seu agora:<br>1. Cuide da sua pele 🧴<br>A pele é seu cartão de visitas! Invista em um skincare básico: limpeza, hidratação e protetor solar todos os dias.<br>2. Mude algo no seu visual ✂️<br>Pode ser um corte de cabelo, uma cor nova de esmalte ou até trocar o estilo das sobrancelhas. Pequenos detalhes fazem diferença.<br>3. Organize sua rotina ⏰<br>Dormir bem, se alimentar melhor e beber água podem parecer simples, mas transformam sua energia e disposição.<br>4. Mexa o corpo 🏃‍♀️<br>Não precisa ser academia se você não gosta. Dance no quarto, faça alongamentos ou caminhadas ouvindo sua playlist favorita.<br>5. Experimente novas makes 💋<br>Um batom diferente ou um delineado gatinho podem elevar seu look instantaneamente.<br>6. Invista no seu estilo 👗<br>Descubra quais peças te fazem sentir poderosa e monte looks que expressem quem você é.<br>7. Trabalhe sua autoestima 💖<br>O maior glow up vem de dentro. Se elogie, comemore suas vitórias e não se compare.<br>✨ Dica final: não se cobre para mudar de um dia pro outro. Glow up é sobre evolução e autocuidado, não sobre virar outra pessoa. Seja paciente e curta cada passo!"
            },

            new(){
                Id = 3,
                Nome = "5 Hábitos Simples para Cuidar do Corpo e da Alma Todos os Dias",
                CategoriaId = 3,
                Categoria = corpo,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Cuidar de você mesma não é luxo, é necessidade! Descubra hábitos fáceis que vão te ajudar a manter corpo e mente em equilíbrio, mesmo na correria.",
                Texto = "A vida adolescente pode ser uma mistura de aulas, provas, amizades, redes sociais e mil emoções ao mesmo tempo. Por isso, cuidar do corpo e da alma é essencial para não se sentir sobrecarregada. Aqui vão 5 hábitos simples para incluir na sua rotina hoje mesmo:<br><br>1. Comece o dia se hidratando <br>Antes de mexer no celular, beba um copo de água. Parece pequeno, mas seu corpo agradece e você já começa com energia.<br><br>2. Mova-se de um jeito que te faça feliz <br>Não é sobre treinar pesado todos os dias, é sobre se mexer. Coloque sua música favorita e dance, faça yoga ou caminhada leve.<br><br>3. Respire e desconecte <br>Reserve alguns minutos para respirar fundo, meditar ou simplesmente ficar em silêncio. Sua mente precisa de pausas.<br><br>4. Alimente-se com carinho <br>Comida é combustível e também afeto. Inclua frutas, vegetais e lanchinhos saudáveis que te deixem satisfeita e feliz.<br><br>5. Pratique a gratidão <br>Antes de dormir, anote três coisas boas que aconteceram no seu dia. Isso muda seu foco e fortalece sua paz interior.<br><br> Lembre-se: cuidar de si mesma é um ato de amor próprio. Pequenos hábitos podem transformar completamente como você se sente, por dentro e por fora."
            },

            new(){
                Id = 4,
                Nome = "Como saber se seu Crush está na sua",
                CategoriaId = 4,
                Categoria = segredos,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Tá rolando aquela dúvida cruel: será que ele ou ela tá afim de você? Vem descobrir alguns sinais que podem revelar o crush secreto e te ajudar a entender melhor essa vibe!",
                Texto = "Ah, o crush... aquele mistério delicioso que deixa o coração acelerado e a mente a mil. Às vezes, a gente se pega tentando decifrar cada olhar, cada mensagem, sem saber muito bem o que está acontecendo. Então, como saber se seu crush realmente está na sua? Aqui vão alguns sinais que podem te ajudar:<br><br>1. Ele(a) procura você pra conversar<br>Se ele(a) sempre acha um jeito de puxar papo, mesmo sem motivo, é um ótimo sinal de interesse.<br><br>2. Responde rapidinho suas mensagens<br>Sabe aquele “você não fica horas esperando a resposta”? É porque ele(a) quer estar pertinho, mesmo que só pelo chat.<br><br>3. Fica meio tímido(a) perto de você<br>Às vezes o crush fica até desajeitado, né? Se perceber isso, pode ser que ele(a) esteja sentindo algo especial.<br><br>4. Presta atenção no que você fala<br>Quando a pessoa lembra dos detalhes que você contou, das suas preferências, é porque ela está realmente prestando atenção — e isso é muito importante.<br><br>5. Dá sinais de ciúmes (mesmo que de leve)<br>Se ele(a) demonstra um pouco de ciúmes quando você fala de outras pessoas, é um sinal clássico que não pode passar despercebido.<br>Mas, olha só: nada substitui uma boa conversa sincera. Se sentir que tá na hora, que tal puxar o papo e descobrir o que rola de verdade? Às vezes o crush pode estar esperando só esse empurrãozinho!<br><br>Lembre-se: o mais importante é respeitar seus sentimentos e o tempo do outro. E se não for pra ser, tudo bem também — sempre tem espaço para novas histórias e amizades incríveis."
            }


        ];

        return View(postagens);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
