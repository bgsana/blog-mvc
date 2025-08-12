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

        Categoria sessao = new()
        {
            Id = 5,
            Nome = "Sessão Pipoca"
        };

        Categoria diario = new()
        {
            Id = 6,
            Nome = "Diário de um Blogueira"
        };

        Categoria trend = new()
        {
            Id = 7,
            Nome = "Trend Alert"
        };

        Categoria study = new()
        {
            Id = 8,
            Nome = "Study Glam"
        };

        List<Postagem> postagens = [
            new(){
                Id = 1,
                Nome = "5 Looks que Vão Fazer Você Se Sentir Personagem Principal",
                CategoriaId = 1,
                Categoria = closet,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Prepare-se para transformar o seu armário em um cenário de filme teen! Separei 5 combinações de looks que são a cara de quem quer brilhar no dia a dia.",
                Texto = "Sabe aquele momento em que você abre o armário e pensa: Não tenho nada para vestir? Pois é… a verdade é que muitas vezes a gente só precisa de inspiração para dar um up nas peças que já temos. E é aqui que o nosso Closet dos Sonhos entra em ação!<br>Hoje, eu trouxe 5 ideias de looks que vão fazer você se sentir a personagem principal da sua própria história:<br><br>1. Look Coffee Date<br>Saia plissada + suéter oversized + tênis branco. Perfeito para um dia friozinho, mas ainda com aquele ar fofinho de comédia romântica.<br><br>2. Look Estrela da Escola<br>Calça jeans wide leg + camiseta gráfica + jaqueta bomber. Estiloso, confortável e perfeito para passar o dia correndo entre as aulas e o intervalo.<br><br>3. Look Shopping com as Besties<br>Vestido midi floral + sandália plataforma + bolsa baguete.Combinação que grita “dia de fotos no espelho das lojas”.<br><br>Dica bônus: Não é sobre ter um armário lotado, mas sim sobre combinar o que você tem de um jeito novo. Teste combinações diferentes, adicione acessórios e, acima de tudo, use o que faz você se sentir incrível.<br><br>E aí, qual desses looks vai ser o seu próximo favorito?",
                Thumbnail = "/img/1.png",
                Foto = "/img/1.png"
            },

            new(){
                Id = 2,
                Nome = "7 Passos para um Glow Up que Vai Fazer Você Brilhar de Verdade",
                CategoriaId = 2,
                Categoria = glow,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Quer mudar o visual, melhorar sua autoestima e se sentir a protagonista da sua própria história?",
                Texto = "Glow up não é só sobre mudar o cabelo ou comprar roupas novas — é sobre se transformar de um jeito que te faça se sentir bem todos os dias. É um processo que mistura autocuidado, autoconhecimento e um toque de estilo. Aqui vão 7 passos para começar o seu agora:<br><br>1. Cuide da sua pele <br>A pele é seu cartão de visitas! Invista em um skincare básico: limpeza, hidratação e protetor solar todos os dias.<br><br>2. Mude algo no seu visual <br>Pode ser um corte de cabelo, uma cor nova de esmalte ou até trocar o estilo das sobrancelhas. Pequenos detalhes fazem diferença.<br><br>3. Organize sua rotina <br>Dormir bem, se alimentar melhor e beber água podem parecer simples, mas transformam sua energia e disposição.<br><br>4. Mexa o corpo<br>Não precisa ser academia se você não gosta. Dance no quarto, faça alongamentos ou caminhadas ouvindo sua playlist favorita.<br><br>5. Experimente novas makes <br>Um batom diferente ou um delineado gatinho podem elevar seu look instantaneamente.<br><br>6. Invista no seu estilo<br>Descubra quais peças te fazem sentir poderosa e monte looks que expressem quem você é.<br><br>7. Trabalhe sua autoestima <br>O maior glow up vem de dentro. Se elogie, comemore suas vitórias e não se compare.<br><br> Dica final: não se cobre para mudar de um dia pro outro. Glow up é sobre evolução e autocuidado, não sobre virar outra pessoa. Seja paciente e curta cada passo!",
                Thumbnail = "/img/2.png",
                Foto = "/img/2.png"
            },

            new(){
                Id = 3,
                Nome = "5 Hábitos Simples para Cuidar do Corpo e da Alma Todos os Dias",
                CategoriaId = 3,
                Categoria = corpo,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Cuidar de você mesma não é luxo, é necessidade! Descubra hábitos fáceis que vão te ajudar a manter corpo e mente em equilíbrio, mesmo na correria.",
                Texto = "A vida adolescente pode ser uma mistura de aulas, provas, amizades, redes sociais e mil emoções ao mesmo tempo. Por isso, cuidar do corpo e da alma é essencial para não se sentir sobrecarregada. Aqui vão 5 hábitos simples para incluir na sua rotina hoje mesmo:<br><br>1. Comece o dia se hidratando <br>Antes de mexer no celular, beba um copo de água. Parece pequeno, mas seu corpo agradece e você já começa com energia.<br><br>2. Mova-se de um jeito que te faça feliz <br>Não é sobre treinar pesado todos os dias, é sobre se mexer. Coloque sua música favorita e dance, faça yoga ou caminhada leve.<br><br>3. Respire e desconecte <br>Reserve alguns minutos para respirar fundo, meditar ou simplesmente ficar em silêncio. Sua mente precisa de pausas.<br><br>4. Alimente-se com carinho <br>Comida é combustível e também afeto. Inclua frutas, vegetais e lanchinhos saudáveis que te deixem satisfeita e feliz.<br><br>5. Pratique a gratidão <br>Antes de dormir, anote três coisas boas que aconteceram no seu dia. Isso muda seu foco e fortalece sua paz interior.<br><br> Lembre-se: cuidar de si mesma é um ato de amor próprio. Pequenos hábitos podem transformar completamente como você se sente, por dentro e por fora.",
                Thumbnail = "/img/3.png",
                Foto = "/img/3.png"
            },

            new(){
                Id = 4,
                Nome = "Como saber se seu Crush está na sua",
                CategoriaId = 4,
                Categoria = segredos,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Tá rolando aquela dúvida cruel: será que ele ou ela tá afim de você? Vem descobrir alguns sinais que podem revelar o crush secreto e te ajudar a entender melhor essa vibe!",
                Texto = "Querido diário,<br>Sabe aqueles dias em que a gente acorda e já sente que nada vai dar certo? Eu costumava ter muitos assim. Me comparava o tempo todo com outras pessoas, achava que nunca era boa o suficiente, bonita o suficiente, interessante o suficiente… e isso só me deixava mais insegura.<br>Mas aos poucos, percebi que a pessoa com quem eu mais deveria ser gentil… era eu mesma.<br>Comecei com coisas pequenas: me elogiar no espelho, vestir roupas que me fazem sentir bem, tirar um tempinho pra cuidar da minha pele e ouvir músicas que me deixam feliz.<br>Também aprendi a dizer não para situações e pessoas que me faziam mal. E, sabe, é libertador. Hoje, ainda tenho dias ruins, mas já não deixo que eles definam quem eu sou.<br>Se eu pudesse te dar um conselho, seria: seja paciente com você. O amor-próprio não nasce de um dia pro outro, mas cada passinho conta.<br>No final das contas, acho que aprender a gostar de mim é o maior glow up que já tive. 💖<br>Com carinho,<br>Uma blogueira que está se descobrindo",
                Thumbnail = "/img/4.png",
                Foto = "/img/4.png"
            },

            new(){
                Id = 5,
                Nome = "5 Filmes Perfeitos para Assistir com as Amigas no Fim de Semana",
                CategoriaId = 5,
                Categoria = sessao,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Chame as divas, prepara a pipoca e ajeita o travesseiro!",
                Texto = "Nada melhor do que uma noite de filmes com as amigas: risadas, fofocas, comida gostosa e muita diversão. Mas, se a dúvida é o que assistir, aqui vão 5 sugestões que vão agradar todo mundo:<br><br>1. As Patricinhas de Beverly Hills<br>Clássico dos anos 90, cheio de looks icônicos e frases memoráveis. Perfeito para dar boas risadas e se inspirar no estilo fashion queen.<br><br>2. Para Todos os Garotos que Já Amei<br>Um romance fofinho e divertido, com direito a bilhetes secretos e muito crush. É impossível não se apaixonar pela Lara Jean!<br><br>3. Meninas Malvadas<br>Dramas escolares, intrigas e frases que viraram meme eterno. Ótimo para assistir e comentar cada cena com as amigas.<br><br>4. A Barraca do Beijo<br>Mistura de romance, amizade e dilemas adolescentes. A vibe perfeita para quem gosta de histórias leves e divertidas.<br><br>5. O Diabo Veste Prada<br>Moda, humor e uma protagonista descobrindo quem ela realmente é. Inspiração pura para seguir seus sonhos.<br><br> Dica extra: prepare um combo pipoca + brigadeiro de panela, escolha a playlist para tocar nos intervalos e não esqueça das fotos pra registrar o momento!<br>No fim das contas, não importa o filme — o melhor é estar com quem faz você rir até a barriga doer.",
                Thumbnail = "/img/5.png",
                Foto = "/img/5.png"
            },

            new(){
                Id = 6,
                Nome = "Aprendendo a gostar de mim mesma!",
                CategoriaId = 6,
                Categoria = diario,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Nem sempre é fácil olhar no espelho e sorrir para quem vemos ali.",
                Texto = "Querido diário,<br>Sabe aqueles dias em que a gente acorda e já sente que nada vai dar certo? Eu costumava ter muitos assim. Me comparava o tempo todo com outras pessoas, achava que nunca era boa o suficiente, bonita o suficiente, interessante o suficiente… e isso só me deixava mais insegura.<br>Mas aos poucos, percebi que a pessoa com quem eu mais deveria ser gentil… era eu mesma.<br>Comecei com coisas pequenas: me elogiar no espelho, vestir roupas que me fazem sentir bem, tirar um tempinho pra cuidar da minha pele e ouvir músicas que me deixam feliz.<br>Também aprendi a dizer não para situações e pessoas que me faziam mal. E, sabe, é libertador. Hoje, ainda tenho dias ruins, mas já não deixo que eles definam quem eu sou.<br>Se eu pudesse te dar um conselho, seria: seja paciente com você. O amor-próprio não nasce de um dia pro outro, mas cada passinho conta.<br>No final das contas, acho que aprender a gostar de mim é o maior glow up que já tive.<br>Com carinho,<br>Uma blogueira que está se descobrindo",
                Thumbnail = "/img/6.png",
                Foto = "/img/6.png"
            },

            new(){
                Id = 7,
                Nome = "3 Trends do Momento que Você Precisa Testar Agora!",
                CategoriaId = 7,
                Categoria = trend,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Do TikTok ao Instagram, as trends não param de aparecer. Separei as três mais divertidas do momento para você entrar na onda e arrasar no feed!",
                Texto = "Se tem uma coisa que a internet sabe fazer é criar modas que viram febre em poucos dias. E, claro, quem ama estar antenada não pode perder a chance de experimentar! Aqui vão 3 trends que estão bombando:<br><br>1. Desafio do “Photo Dump de Agosto”<br>A ideia é postar um carrossel de fotos aleatórias do seu mês, misturando selfies, comidas, momentos com amigas e até fotos engraçadas. Quanto mais natural, melhor!<br><br>2. “Get Ready With Me” com Plot Twist <br>O famoso GRWM, mas com uma reviravolta no final. Você começa se arrumando para um “evento chique”, e no final aparece indo comer pastel na feira. A galera AMA!<br><br>3. Dublagem de Áudio Retrô <br>Áudios antigos (propagandas, músicas, frases de filmes) voltaram com tudo! É só escolher um engraçado, dublar e colocar seu toque pessoal.<br><br>✨ Dica extra: quando for gravar uma trend, não se preocupe em ficar perfeita. O segredo é se divertir, ser criativa e colocar sua personalidade. É isso que faz as pessoas se conectarem com você!<br>Agora me conta: qual dessas trends você vai testar primeiro?",
                Thumbnail = "/img/7.png",
                Foto = "/img/7.png"
            },

            new(){
                Id = 8,
                Nome = "Como Estudar e Continuar no Estilo: 5 Dicas para um Study Glam Perfeito",
                CategoriaId = 8,
                Categoria = study,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Estudar não precisa ser chato! Descubra como transformar seu cantinho e sua rotina de estudos em algo organizado, produtivo e super aesthetic.",
                Texto = "Estudar pode até parecer cansativo, mas quando a gente deixa tudo mais bonito e organizado, o processo fica muuuito mais gostoso. O Study Glam é exatamente isso: unir produtividade com estilo. Então pega sua caneta favorita e anota aí:<br><br>1. Crie um cantinho de estudos fofo<br>Escolha um local bem iluminado, com uma mesa organizada, canetas coloridas e alguns itens decorativos que você ama.<br><br>2. Aposte em materiais que te inspiram<br>Cadernos com capas bonitas, post-its de formatos diferentes e marcadores coloridos deixam qualquer resumo mais divertido.<br><br>3. Use planners ou bullet journal<br>Anotar suas tarefas de um jeito visual e criativo ajuda a manter a organização — e ainda dá vontade de cumprir tudo só pra riscar da lista!<br><br>4. Faça pausas estratégicas<br>Estudar sem parar não é produtivo. Use o método Pomodoro (25 min de foco + 5 min de pausa) e aproveite os intervalos para se alongar ou beber água.<br><br>5. Mantenha o clima positivo<br>Monte uma playlist instrumental ou lo-fi para acompanhar seus estudos e deixar o ambiente mais relaxante.<br><br>Dica final: não se cobre para ter tudo perfeito. O mais importante é criar um ambiente e uma rotina que funcionem para você — e, de quebra, que deem vontade de estudar só pra passar um tempo nesse espaço lindo.",
                Thumbnail = "/img/8.png",
                Foto = "/img/8.png"
            },
        ];

        return View(postagens);
    }

    public IActionResult Postagem()
    {
        return View();
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
