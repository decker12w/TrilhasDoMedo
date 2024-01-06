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
        Insert(10,@"O jogador emerge na clareira sombria da floresta, um lugar onde os vestígios de um passado abandonado se revelam. A névoa, densa e enigmática, abraça os trilhos de trem antigos que se estendem como veias negras pelas entranhas da floresta. O metal gasto brilha timidamente sob a luz fraca, testemunha silenciosa de eras passadas. Um túnel sombrio, uma boca negra e intimidante, se projeta à frente, devorando a luz que tenta penetrar suas profundezas. Uma sensação de mistério paira no ar, intensificando-se com a voz que ecoa misteriosamente pelo ambiente.
        Voz Misteriosa: Bem-vindo, viajante perdido, às trilhas do medo. Vocês se encontram em um labirinto sombrio, onde suas escolhas moldarão seu destino. As respostas estão nos caminhos que escolherem seguir.
        Voz Misteriosa: Para encontrarem o caminho de volta para casa, terão que navegar por esses trilhos. Mas cuidado, pois cada escolha traz consigo consequências.
        A voz desaparece, deixando o jogador sozinho na clareira, diante dos trilhos que se estendem como opções desconhecidas em um tabuleiro sombrio.", "Adentrar o Túnel Sombrio à Frente", "Retornar e Explorar os trilhos por Trás");
       
       Insert(9,@"
Jogador, com coragem e determinação, caminha em direção à escuridão do túnel. Os **trilhos** desaparecem sob seus pés, enquanto um frio estranho percorre sua espinha. Barulhos estranhos ressoam ao longe, mas o jogador segue em frente, guiado apenas pelo brilho tênue no fim do túnel.

No meio da escuridão, o jogador tropeça em algo grande e metálico. Ao iluminar o objeto, ele descobre que é a carcaça de um trem antigo, um lembrete silencioso do movimento que uma vez existiu naquele lugar. Procurando por algum sinal de vida ou direção, o jogador vê uma porta de manutenção para funcionários à distância, com as palavras ""Apenas Funcionários"" gravadas de maneira desbotada.

A voz misteriosa faz-se ouvir novamente, desta vez com um tom de aprovação e um enigma intrigante: ""Você encarou a escuridão, viajante, e agora está mais próximo do final da sua jornada. Aqueles que uma vez moveram o aço e o vapor podem ter deixado mais do que meras lembranças. A solução que te conduzirá para fora deste lugar pode estar escondida além da porta restrita ou nas profundezas do gigante de ferro. A escolha é sua e moldará o seu destino. Continue seguindo os **trilhos**, pois eles te conduzirão à verdade.","Explorar o trem","Explorar a porta restrita");
       Insert(11,@"
Jogador opta por dar meia volta, retrocedendo em direção aos **trilhos** que ficam atrás. A névoa parece mais densa nessa direção, tornando a visão ainda mais desafiadora. O jogador sente uma estranha sensação de estar sendo observado enquanto considera suas opções.

[Jogador, após uma breve caminhada, se depara com uma visão familiar: o mesmo túnel sombrio à frente. Ele percebe que, de alguma forma, suas tentativas de mudar de direção o levaram de volta ao mesmo lugar. A floresta parece rir de sua tentativa de fuga, enquanto a voz ecoa novamente em sua mente: ""O labirinto não permite desvios, viajante. Sua jornada deve continuar pelos **trilhos** Sombrios.""]","Entrar novamente nos trilhos Sombrios","Tentar um novo caminho através da floresta");
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

