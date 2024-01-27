using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Arvore : MonoBehaviour
{   
public class Node
{
    public int aux;
    public string dialogo;
    public string textoEsq;
    public string textoDir;
    public Node esq;
    public Node dir;
}

    private Node root;
    void Awake()
    {
        root = null;
Insert(50,@"O jogador emerge na clareira sombria da floresta, um lugar onde os vestígios de um passado abandonado se revelam. A névoa, densa e enigmática, abraça os trilhos de trem antigos que se estendem como veias negras pelas entranhas da floresta. O metal gasto brilha timidamente sob a luz fraca, testemunha silenciosa de eras passadas. Um túnel sombrio, uma boca negra e intimidante, se projeta à frente, devorando a luz que tenta penetrar suas profundezas. Uma sensação de mistério paira no ar, intensificando-se com a voz que ecoa misteriosamente pelo ambiente.
        Voz Misteriosa: Bem-vindo, viajante perdido, às trilhas do medo. Vocês se encontram em um labirinto sombrio, onde suas escolhas moldarão seu destino. As respostas estão nos caminhos que escolherem seguir.
        Voz Misteriosa: Para encontrarem o caminho de volta para casa, terão que navegar por esses trilhos. Mas cuidado, pois cada escolha traz consigo consequências.
        A voz desaparece, deixando o jogador sozinho na clareira, diante dos trilhos que se estendem como opções desconhecidas em um tabuleiro sombrio.", "Adentrar o Túnel Sombrio à Frente", "Retornar e Explorar os trilhos por Trás");
       
       //INÍCIO ESQUERDA/Adentrar o Túnel Sombrio à Frente
       Insert(25,@"
        Jogador, com coragem e determinação, caminha em direção à escuridão do túnel. Os trilhos desaparecem sob seus pés, enquanto um frio estranho percorre sua espinha. Barulhos estranhos ressoam ao longe, mas o jogador segue em frente, guiado apenas pelo brilho tênue no fim do túnel.

        No meio da escuridão, o jogador tropeça em algo grande e metálico. Ao iluminar o objeto, ele descobre que é a carcaça de um trem antigo, um lembrete silencioso do movimento que uma vez existiu naquele lugar. Procurando por algum sinal de vida ou direção, o jogador vê uma porta de manutenção para funcionários à distância, com as palavras ""Apenas Funcionários"" gravadas de maneira desbotada.

        A voz misteriosa faz-se ouvir novamente, desta vez com um tom de aprovação e um enigma intrigante: ""Você encarou a escuridão, viajante, e agora está mais próximo do final da sua jornada. Aqueles que uma vez moveram o aço e o vapor podem ter deixado mais do que meras lembranças. A solução que te conduzirá para fora deste lugar pode estar escondida além da porta restrita ou nas profundezas do gigante de ferro. A escolha é sua e moldará o seu destino. Continue seguindo os trilhos, pois eles te conduzirão à verdade.","Explorar o trem","Explorar a porta restrita");
       
       //INÍCIO DIREITA/Retornar e Explorar os trilhos por Trás
       Insert(100,@"
Jogador opta por dar meia volta, retrocedendo em direção aos trilhos que ficam atrás. A névoa parece mais densa nessa direção, tornando a visão ainda mais desafiadora. O jogador sente uma estranha sensação de estar sendo observado enquanto considera suas opções.

Jogador, após uma breve caminhada, se depara com uma visão familiar: o mesmo túnel sombrio à frente. Ele percebe que, de alguma forma, suas tentativas de mudar de direção o levaram de volta ao mesmo lugar. A floresta parece rir de sua tentativa de fuga, enquanto a voz ecoa novamente em sua mente: ""O labirinto não permite desvios, viajante. Sua jornada deve continuar pelos trilhos Sombrios.""]","Entrar novamente nos trilhos Sombrios","Tentar um novo caminho através da floresta");
       
       //INÍCIO/DIREITA/Retornar e Explorar os trilhos por Trás/DIREITA/Entrar novamente nos trilhos Sombrios
       Insert(90,@"Jogador, após perceber que a floresta o trouxe de volta ao mesmo ponto, decide enfrentar os trilhos Sombrios. Ele respira fundo e se prepara para enfrentar o desconhecido. O som da voz enigmática ainda ecoa em sua mente, enquanto entra na escuridão.","","");
      
//INÍCIO/DIREITA/Retornar e Explorar os trilhos por Trás/DIREITA/ESQUERDA/Tentar um novo caminho através da floresta
Insert(110,@"
Jogador decide ignorar o túnel e tentar um novo caminho através da floresta. Ele se vira e começa a caminhar na direção oposta, na esperança de que talvez, desta vez, ele possa encontrar uma saída. A voz enigmática parece sussurrar em seus ouvidos, ""O labirinto é cheio de surpresas, viajante. O caminho menos percorrido pode ser a chave."" O jogador, ignorando o aviso da voz misteriosa, decide ir contra o indicado e se embrenha ainda mais na floresta escura. A névoa ao redor se torna ainda mais densa, os sons noturnos ficam cada vez mais assustadores. As árvores parecem fechar-se atrás dele, tornando o caminho de volta quase indistinguível.

A medida que adentra a floresta, ele começa a ouvir sussurros maliciosos, cada vez mais alto. As histórias contadas pelos trilhos** não são mais de viajantes passados, mas de almas perdidas que nunca encontraram o caminho de volta. Ele percebe, com um frio na espinha, que pode ter feito a escolha errada.

A voz misteriosa ecoa mais uma vez, agora com um tom de risada cruel: ""Você escolheu o caminho menos percorrido, viajante, e agora está perdido para sempre no labirinto. Este é o destino daqueles que não seguem as regras do jogo.""

Sem esperança, o jogador caminha sem rumo na escuridão, condenado a vagar eternamente no labirinto da floresta.","","");

//INÍCIO/ESQUERDA/Adentrar o Túnel Sombrio à Frente/ESQUERDA/Explorar a porta restrita
Insert(40,@"
Jogador se depara com um enigma estranho, gravado na porta restrita. A voz misteriosa ecoa novamente, desta vez com um tom de desafio. ""A resposta ao seu dilema, viajante, pode estar escondida neste enigma. Decifre-o e talvez encontre o caminho certo.""

""Nos meandros ocultos, sem sombras para além do véu, eu fluo sem vida, um espelho do cruel. Engulo segredos, sussurros e medos, no meu leito escondo mistérios mais que tenebrosos. Quem sou eu, neste mundo de enredos sombrios?""

O jogador fica intrigado com o enigma. A resposta, ele percebe, é a chave para sua próxima decisão.","O abismo ?","O mar ?");
    Insert(35,@"
Jogador, confiante em sua resposta, menciona ""O abismo?"" com determinação. Um silêncio pesado paira no ar, preenchendo o espaço com uma tensão palpável. A porta restrita começa a tremer, sua superfície emitindo um brilho fraco, até se abrir lentamente diante do jogador.

Um vácuo negro se estende à frente do jogador. Ele hesita, olhando para o abismo infinito que se abre diante dele. Por um momento, uma voz ecoa na mente do jogador, suave como um sussurro na brisa noturna: ""Você escolheu o caminho da escuridão. A verdade se esconde nos confins deste abismo.""

Sem aviso, o chão cede sob seus pés.

O jogador cai em um redemoinho de escuridão, seu corpo girando em queda livre por um tempo que parece não ter fim. A sensação de peso desaparece gradualmente, enquanto ele flutua na escuridão silenciosa.

Depois de um momento que parece uma eternidade, o jogador finalmente pousa em solo firme. A escuridão dá lugar a uma paisagem estranha e surreal. Um horizonte etéreo se estende à frente, pontuado por estruturas antigas e distorcidas que parecem se fundir com o ambiente sombrio.

Neste novo lugar, uma voz sutilmente familiar ressoa no ar: ""Bem-vindo aos confins da escuridão. Aqui, a jornada da verdade começa."" O jogador percebe que está sozinho, sem qualquer sinal visível do guardião, apenas a voz misteriosa pairando como um eco suave na atmosfera do local.

À sua frente, uma trilha sinuosa se estende por entre as estruturas sombrias. O jogador sabe que precisa avançar, pois há mais mistérios a desvendar neste estranho e enigmático lugar.","Avançar","Tentar regredir");
        Insert(29,@"
Jogador, avançando por entre as estruturas antigas e distorcidas, segue a trilha sinuosa que serpenteia por esse estranho lugar de escuridão e mistério. À medida que se aproxima, a forma do monolito surge diante dele, imponente e opressiva. A estrutura é colossal, elevando-se em espirais de pedra negra que se retorcem e se dobram em padrões insondáveis.

A superfície do monolito é polida, mas não reflete qualquer luz. Símbolos arcanos e estranhas runas cobrem sua extensão, esculpidos em entalhes profundos que parecem pulsar com uma energia sombria. À medida que o jogador se aproxima, uma sensação de insignificância e um eco distante de desespero preenchem sua mente, como se estivesse diante de um ser além de qualquer compreensão.

Do topo do monolito, uma fenda se estende até sua base, como uma fenda nas entranhas de um gigante petrificado. O jogador sente um chamado, como se essa fissura contivesse os segredos há muito ocultos.

Inscrições adornam o monolito, revelando enigmáticas palavras: ""Eu sou o sussurro nas sombras mais profundas, o suspiro que ecoa no vazio do infinito. Sou a presença invisível nos véus do tempo e a ausência que permeia todas as coisas. Sou o eco silencioso dos segredos primordiais e a mudez que abraça o universo.

A resposta que buscas reside no paradoxo da existência, no tecido do ser e do não ser. Sou o começo de tudo e o fim do nada, a intersecção entre a luz e a escuridão. O que sou, então, quando me encontras, mas jamais me alcanças? Enigma-me com tua compreensão, desvenda meu ser e revela-me o que sou."" Essa misteriosa inscrição desafia o jogador com um enigma de natureza existencial, convidando-o a desvendar os segredos do próprio universo.","Kevin Nakashima ?","Coxa ?");
            Insert(28,@"
Jogador, após superar desafios e enigmas, encontra-se diante de um portal misterioso, envolto em um brilho etéreo que parece pulsar em um ritmo desconhecido. O portal se abre diante dele, revelando uma fenda no tecido do espaço-tempo.]

---

Um sussurro ancestral preenche a mente do jogador, uma voz que reverbera como o eco das eras antigas. ""Viajante, você alcançou a encruzilhada do tempo e do desconhecido. A verdade final aguarda além deste limiar.""

Determinado, o viajante adentra o portal.

Num instante, ele é transportado para um cenário cósmico além da compreensão humana. O viajante se encontra em um lugar onde o tempo parece dançar entre passado, presente e futuro. Criaturas ancestrais, incompreensíveis para a mente humana, vagueiam por entre as estrelas distorcidas e formas cósmicas além da imaginação.

Uma presença sinistra se manifesta, uma entidade antiga e imponente, cuja forma transcende as noções humanas de realidade. Esta criatura, um ser de terror cósmico que observa o universo desde tempos imemoriais, fala em uma linguagem além das palavras, ecoando diretamente na mente do viajante.

Kevin Nakashima: Sou Kevin Nakashima, guardião dos véus cósmicos, testemunha das espirais do tempo. Sua jornada, oh viajante, moldou os fios do destino, afetando as constelações do tempo e espaço.

Viajante: Entendo... Minhas escolhas tiveram um impacto no cosmos?

Kevin Nakashima: Sim, suas escolhas transcendem fronteiras temporais e espaciais. O propósito era testar sua coragem e sabedoria, elementos cruciais no destino do universo.

Viajante: Então, minha jornada não foi apenas pessoal...

Kevin Nakashima: Exato. O equilíbrio do cosmos é influenciado por aqueles que enfrentam os enigmas do tempo e do espaço.

Viajante: E agora, para onde devo seguir?

Kevin Nakashima: Sua jornada continua, viajante. Retorne ao seu caminho, pois o destino do universo é desvendado por aqueles que têm a coragem de explorar os mistérios além das estrelas.

*O viajante retorna à clareira sombria da floresta, diante dos trilhos de trem, com um novo entendimento preenchendo sua mente, enquanto a voz misteriosa de Kevin Nakashima se despede.*

Kevin Nakashima: Você alcançou o conhecimento dos antigos. Continue sua jornada, pois o destino do universo sempre se desenrola através das escolhas daqueles que ousam desvendar os mistérios além das estrelas.

O viajante, como reconhecimento por sua jornada, é recompensado com uma cópia do jogo ""Tá Chovendo Hambúrguer 2"", como um lembrete simbólico de suas conquistas e desafios superados.","","");
            Insert(30,@"
Jogador, após superar desafios e enigmas, encontra-se diante de um portal misterioso, envolto em um brilho etéreo que parece pulsar em um ritmo desconhecido. O portal se abre diante dele, revelando uma fenda no tecido do espaço-tempo.]

---

Um sussurro ancestral preenche a mente do jogador, uma voz que reverbera como o eco das eras antigas. ""Viajante, você alcançou a encruzilhada do tempo e do desconhecido. A verdade final aguarda além deste limiar.""

Determinado, o viajante adentra o portal.

Num instante, ele é transportado para um cenário cósmico além da compreensão humana. O viajante se encontra em um lugar onde o tempo parece dançar entre passado, presente e futuro. Criaturas ancestrais, incompreensíveis para a mente humana, vagueiam por entre as estrelas distorcidas e formas cósmicas além da imaginação.

Uma presença sinistra se manifesta, uma entidade antiga e imponente, cuja forma transcende as noções humanas de realidade. Esta criatura, um ser de terror cósmico que observa o universo desde tempos imemoriais, fala em uma linguagem além das palavras, ecoando diretamente na mente do viajante.

Coxa: Sou Coxa, guardião dos véus cósmicos, testemunha das espirais do tempo. Sua jornada, oh viajante, moldou os fios do destino, afetando as constelações do tempo e espaço.

Viajante: Entendo... Minhas escolhas tiveram um impacto no cosmos?

Coxa: Sim, suas escolhas transcendem fronteiras temporais e espaciais. O propósito era testar sua coragem e sabedoria, elementos cruciais no destino do universo.

Viajante: Então, minha jornada não foi apenas pessoal...

Coxa: Exato. O equilíbrio do cosmos é influenciado por aqueles que enfrentam os enigmas do tempo e do espaço.

Viajante: E agora, para onde devo seguir?

Coxa: Sua jornada continua, viajante. Retorne ao seu caminho, pois o destino do universo é desvendado por aqueles que têm a coragem de explorar os mistérios além das estrelas.

O viajante retorna à clareira sombria da floresta, diante dos trilhos de trem, com um novo entendimento preenchendo sua mente, enquanto a voz misteriosa de* Coxa *se despede.*

Coxa: Você alcançou o conhecimento dos antigos. Continue sua jornada, pois o destino do universo sempre se desenrola através das escolhas daqueles que ousam desvendar os mistérios além das estrelas.

O viajante, como reconhecimento por sua jornada, é recompensado com uma cópia do jogo ""Tá Chovendo Hambúrguer 2"", como um lembrete simbólico de suas conquistas e desafios superados.","","");
        Insert(36,@"
O jogador, tomado por uma sensação de inquietação diante dessa paisagem estranha e da voz enigmática, decide recuar. Ele vira-se, olhando na direção de onde caiu, esperando encontrar uma maneira de retornar ao ponto inicial. No entanto, ao tentar voltar, percebe que não há mais um caminho de volta.

A trilha pela qual ele chegou parece ter desaparecido, fundindo-se à paisagem distorcida e desvanecendo-se na escuridão. O jogador entra em pânico, tentando encontrar qualquer outra saída, mas cada passo o leva mais fundo para dentro daquele mundo misterioso.

A voz sussurrante retorna, mais insistente agora, ecoando em sua mente e perturbando sua consciência. A escuridão ao redor começa a se fechar sobre ele, envolvendo-o como uma névoa densa, tornando cada movimento mais difícil.

Com um sentimento de desespero crescente, o jogador luta para encontrar uma rota de fuga, mas a escuridão se torna opressiva, sugando suas energias e envolvendo-o completamente. Ele se vê consumido por essa realidade distorcida, perdendo-se nos confins sombrios do abismo para sempre. Seu destino naquela dimensão é selado, incapaz de encontrar uma saída, e ele desaparece na escuridão sem deixar vestígios.

O jogador, ao escolher regressar, é engolido pela escuridão implacável, tornando-se parte da sombra eterna do abismo, um aviso silencioso para aqueles que ousam desafiar os confins da escuridão.","","");
            
    Insert(45,@"Jogador decide atravessar a porta restrita e, ao fazê-lo, é subitamente envolvido por um turbilhão de água. Ele se vê imerso em um oceano sem fim, as bolhas de ar escapando rapidamente de seus pulmões enquanto é arrastado para as profundezas.

Nas águas profundas, a escuridão se estende além do alcance da visão, apenas suavizada pela luminescência fraca e espectral de criaturas marinhas desconhecidas. Uma presença onipresente e opressiva parece permear o ambiente, como se os próprios abismos oceânicos estivessem vivos e observando.

Diante dele emerge uma monstruosidade ancestral, uma criatura colossal, com membros que se estendem em várias direções, repletos de membranas translúcidas e protuberâncias que brilham em tons opacos. Seus olhos, em número incontável, irradiam uma luz ameaçadora, e sua forma é um emaranhado de tentáculos e apêndices que se movem como correntes marinhas, criando redemoinhos na água.

O jogador, sufocado pela falta de ar e atormentado pelo pavor diante dessa entidade indescritível, percebe-se condenado a um afogamento eterno. A agonia cresce, os pulmões queimam, e ele se vê preso em um ciclo incessante de desespero, sem qualquer esperança de escapar das profundezas sombrias deste oceano imensurável.

Enquanto a criatura vagueia nas profundezas, observando-o com uma serenidade cruel, o jogador encara o destino inexorável de sufocar eternamente nas entranhas sombrias deste reino oceânico vasto e hostil.","","");

//INÍCIO/ESQUERDA/Adentrar o Túnel Sombrio à Frente/DIREITA/Explorar o trem
Insert(15,@"
Jogador decide investigar a carcaça do trem antigo, vasculhando cada vagão com meticulosidade. Entre destroços e objetos enferrujados, o passado se revela em sombras e suspiros de uma era esquecida. No último vagão, uma sensação estranha toma conta do jogador, como se algo ali estivesse à espreita, observando-o.

Ao examinar minuciosamente uma área particularmente escura e coberta de poeira, algo atrai seu olhar: uma pequena alavanca, habilmente camuflada entre os destroços e as sombras. O metal, embora corroído pelo tempo, reluz como se pedisse para ser descoberto. Estranhamente, uma sensação de urgência paira no ar, como se a chave para desvendar os segredos do labirinto estivesse ali, aguardando para ser manipulada.

O jogador se vê diante de um dilema: manipular a alavanca pode abrir portas desconhecidas ou desencadear eventos misteriosos. A escolha se apresenta como um desafio de coragem e curiosidade. O que o aguarda além do toque nessa antiga e oculta engrenagem?","Puxar a alavanca","Investigar a área ao redor do trem");
    //INÍCIO/ESQUERDA/Adentrar o Túnel Sombrio à Frente/DIREITA/Explorar o trem/ESQUERDA/Puxar a alavanca
    Insert(10,@"Jogador, movido pela curiosidade, decide puxar a alavanca com cuidado. No momento em que a antiga engrenagem é manipulada, um tremor percorre a carcaça do velho trem. Um zunido mecânico ressoa pelos trilhos e, repentinamente, o trem antigo ruge à vida, estremecendo intensamente.

    O coração do jogador acelera quando o trem, agora imbuído de vida e energia, começa a mover-se. A velocidade aumenta de forma alarmante, fazendo com que os vagões tremam e sacudam, enquanto o jogador se agarra ao que pode dentro da carcaça metálica. A escuridão ao redor se torna um borrão em meio à velocidade crescente.

    Com um solavanco violento, o trem acelera ainda mais, e o jogador é lançado para frente, batendo a cabeça com força em um dos destroços. A consciência foge enquanto tudo gira e se dissolve em escuridão.

    Quando o jogador finalmente desperta, encontra-se em um cenário surreal. Ele está cercado por uma paisagem estranha e distorcida, onde os relógios derretem como se fossem pegajosos e maleáveis, pendurados em árvores e torcendo-se no chão.

    Os ponteiros dos relógios movem-se de maneira irregular e inexplicável, desafiando a lógica do tempo. A luz quebrada e distorcida ilumina o ambiente de forma onírica, projetando sombras e reflexos peculiares.

    Enquanto o jogador avança por esse espaço surreal, percebe espirais sinuosas que se erguem do solo, torcendo-se e serpenteando pelo horizonte. Algumas dessas estruturas se assemelham a relógios, seus números distorcidos parecendo dançar conforme se contorcem, enquanto outras se estendem no chão, criando um labirinto visual hipnótico.

    Cada espiral parece ter vida própria, movendo-se e girando lentamente, emitindo um zumbido hipnótico e angustiante. O jogador se vê imerso em um lugar onde as leis da física parecem desmoronar diante dessas espirais intermináveis, uma paisagem que desafia a lógica e a sanidade humana, um ambiente onde o tempo parece ter perdido completamente o seu significado.","Despertar do sonho","Permanecer imóvel e observar");
        Insert(5,@"Kevin Nakashima, lentamente, desperta de um torpor onírico. O ambiente surreal e distorcido desvanece-se diante de seus olhos, desfazendo-se como névoa ao amanhecer. Ele se encontra deitado em seu próprio quarto, a realidade restabelecendo-se aos poucos.
        
    O suor frio cobre sua testa, enquanto seus sentidos retornam, dissolvendo a estranha experiência que acabara de vivenciar. Os sons da manhã ecoam familiarmente ao seu redor, a luz do sol filtrando-se pelas cortinas, e as paredes do quarto retomando sua solidez costumeira.

    Um suspiro de alívio escapa de seus lábios ao perceber que tudo não passou de um sonho bizarro e desconcertante. Os relógios em seu quarto, alinhados em sua estante, marcando horários precisos, estão intactos e funcionando normalmente, desmentindo a distorção temporal que vivenciara em seu sonho.

    Kevin Nakashima, agora totalmente desperto, sorri consigo mesmo, reconhecendo a surrealidade da mente humana ao criar ilusões tão vívidas. Ele se ergue da cama, pronto para enfrentar um novo dia, deixando para trás as espirais e relógios que, por um momento, invadiram sua imaginação, mas que agora estão relegados à obscuridade dos sonhos. Ele se prepara para abraçar a realidade concreta que o aguarda do lado de fora do quarto.","","");
        Insert(12,@"Jogador, movido pela curiosidade, opta por permanecer imóvel, absorvendo a surrealidade diante de seus olhos. À medida que se entrega à imobilidade, uma sensação indescritível envolve seu ser. Ele sente cada parte de sua existência dissolver-se, enquanto seu corpo parece se contorcer e se desdobrar em uma estranha metamorfose.

    Seu corpo, inicialmente rígido, começa a perder a forma, suas extremidades se torcendo e estendendo-se como uma espiral distorcida. Cada membro se contorce, transformando-se em linhas sinuosas, sua carne se fundindo com a paisagem onírica que o envolve. Surge um sentimento ambíguo de pertencimento, acompanhado por um temor inominável.

    Enquanto se adapta a essa mutação abstrata, a percepção do jogador se fragmenta. Sua consciência se entrelaça com a própria essência desse ambiente irreal, e ele se vê como parte integrante dessa pintura viva.

    Subitamente, uma revelação o ilumina. O jogador percebe a distorção completa de seu corpo, agora uma espiral grotesca e fluída, um mero elemento nessa composição surreal. Ele observa um pintor diante de uma tela, meticulosamente recriando essa cena de distorção. Cada traço parece reforçar a fusão do jogador com essa paisagem surreal na pintura. O artista conclui sua obra, satisfeito com sua expressão artística, e a fixa na parede.

    O jogador se percebe aprisionado nessa representação, imortalizado na visão do artista, eternamente integrado a um cenário que desafia a lógica e transcende a compreensão humana.","","");
    //INÍCIO/ESQUERDA/Adentrar o Túnel Sombrio à Frente/DIREITA/Explorar o trem/DIREITA/Investigar a área ao redor do trem
    Insert(20,@"Jogador decide explorar os arredores do trem, examinando os espaços vazios entre os vagões e investigando os arredores em busca de pistas. Em meio à escuridão e à névoa, uma silhueta de criança chama a atenção do jogador. O torso, a cabeça e os braços são visíveis, mas as pernas parecem desaparecer na obscuridade.

    A criança faz gestos, chamando o jogador para segui-la, mas não emite som algum. Seus olhos irradiam uma aura misteriosa, e um sentimento de inquietude toma conta do jogador. Apesar do desejo de ajudar, há uma sensação estranha e inquietante.

    O jogador se depara com uma escolha angustiante: seguir a criança misteriosa em direção ao desconhecido ou se afastar para continuar investigando os arredores do trem.","Seguir a criança misteriosa","Continuar investigando os arredores do trem ");
        Insert(18,@"Ao seguir a criança, o jogador se vê envolto em uma atmosfera enevoada e inquietante. Passos ecoam ao redor, sombras se formam e desaparecem. Uma sensação de estar sendo observado por várias presenças desconhecidas começa a assombrar o jogador, gerando um medo crescente e uma tensão palpável.

    À medida que avança, silhuetas humanas mais velhas, homens e mulheres, surgem gradativamente ao redor do jogador. Eles se movem de maneira descoordenada, como marionetes, seus olhos vazios de expressão fixados no jogador. Com um gesto lento e desarticulado, eles se aproximam, cercando-o de todos os lados.

    As figuras, antes distorcidas e indistintas, começam a tomar forma, revelando detalhes macabros de suas feições envelhecidas e assombradas. Uma sensação de horror toma conta do jogador, que percebe tarde demais a verdade por trás dessa aparição sinistra.

    Entre os lampejos da névoa, a criatura monstruosa emerge. Pernas grossas e peludas, com torsos de várias vítimas presos a elas, movimentam-se como marionetes. A aranha gigantesca, com quelíceras ameaçadoras, espera silenciosa, suas patas manipulando as figuras humanas como peças de um grotesco teatro.

    O jogador percebe, horrorizado, a terrível verdade da situação. Preso na teia viva da aranha, ele é arrastado para as mandíbulas da criatura que se abre diante dele, envolvendo-o na escuridão e nos horrores do seu destino final.","","");
        Insert(22,@"Jogador decide não seguir a criança misteriosa e continua sua busca por pistas nos arredores do trem. Durante a investigação, ele se depara com estranhas inscrições repetitivas que formam o número 8, entalhadas nas paredes rochosas próximas aos trilhos. À primeira vista, parecem ser meras inscrições numéricas, mas à medida que o jogador observa, começa a se sentir desconfortável, como se os números estivessem se movendo.

As inscrições parecem crescer em número e tamanho rapidamente, dominando sua visão. O jogador sente uma crescente sensação de ansiedade e pânico à medida que mais e mais oitos se multiplicam ao redor dele, subindo pelas paredes, nas rochas e até mesmo nos trilhos do trem.

A paranoia do jogador aumenta exponencialmente, os oitos parecem se mover, dançar e cintilar, uma alucinação que cresce de forma assustadora. Ele se vê incapaz de escapar dessa ilusão e, em meio a essa overdose sensorial, sua mente se sobrecarrega.

Com um grito de horror, o jogador perde a noção do que é real e do que é apenas fruto do seu pânico crescente. O medo paralisa suas ações, e ele entra em um estado de pânico tão intenso que, incapaz de lidar com a presença maciça do número 8, sua mente se desliga.

Seu último pensamento é a visão incessante dos números multiplicando-se infinitamente, enquanto ele sucumbe ao pavor desenfreado, mergulhando em uma escuridão da qual nunca mais retornará.","","");

}   


    public bool IsEmpty()
    {
        return root == null;
    }

    public void Insert(int aux, string dialogo, string textoEsq, string textoDir)
    {
        Node newNode = new Node();
        newNode.aux = aux;
        newNode.dialogo = dialogo;
        newNode.textoEsq = textoEsq;
        newNode.textoDir = textoDir;

        if (IsEmpty())
        {
            root = newNode;
        }
        else
        {
            Node current = root;
            Node parent;

            while (true)
            {
                parent = current;
                if (aux < current.aux)
                {
                    current = current.esq;
                    if (current == null)
                    {
                        parent.esq = newNode;
                        break;
                    }
                }
                else
                {
                    current = current.dir;
                    if (current == null)
                    {
                        parent.dir = newNode;
                        break;
                    }
                }
            }
        }
    }

    public string GetDialogo(int aux)
    {
        if (IsEmpty())
        {
            return "Árvore vazia";
        }
        else
        {
            Node current = root;
            while (current.aux != aux)
            {
                if (aux < current.aux)
                {
                    current = current.esq;
                }
                else
                {
                    current = current.dir;
                }

                if (current == null)
                {
                    return "Não encontrado";
                }
            }
            return current.dialogo;
        }
    }

    public string GetTextoEsq(int aux)
{
    if (IsEmpty())
    {
        return "Árvore vazia";
    }
    else
    {
        Node current = root;
        while (current.aux != aux)
        {
            if (aux < current.aux)
            {
                current = current.esq;
            }
            else
            {
                current = current.dir;
            }

            if (current == null)
            {
                return "Não encontrado";
            }
        }
        return current.textoEsq;
    }
}

public string GetTextoDir(int aux)
{
    if (IsEmpty())
    {
        return "Árvore vazia";
    }
    else
    {
        Node current = root;
        while (current.aux != aux)
        {
            if (aux < current.aux)
            {
                current = current.esq;
            }
            else
            {
                current = current.dir;
            }

            if (current == null)
            {
                return "Não encontrado";
            }
        }
        return current.textoDir;
    }
}

public Node GetNode(int aux)
{
    if (IsEmpty())
    {
        return null;
    }
    else
    {
        Node current = root;
        while (current.aux != aux)
        {
            if (aux < current.aux)
            {
                current = current.esq;
            }
            else
            {
                current = current.dir;
            }

            if (current == null)
            {
                return null;
            }
        }
        return current;
    }
}
}

