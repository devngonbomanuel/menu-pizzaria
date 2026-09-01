using System;
using System.Globalization;

namespace MenuPizzaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, escolhaOferta, escolhaTamanho;
            decimal precoTotal = 0;

            Random rnd = new Random();

            //=======================Menu Inicial=======================
            Console.WriteLine("************************* Pizzaria MamaMia *************************");
            Console.WriteLine("\n1- Oferta do Dia \n2- Menu  \n3-Sair");


            Console.Write("\nEscolha: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                //=======================Oferta do Dia=======================
                case 1:
                        Console.Clear();
                    Console.WriteLine("*************************** Pizzaria MamaMia ***************************");
                    Console.WriteLine("\t\t\t*Pizza à Moda Angolana* \nUma pizza feita com os kitutes da " +
                        "nossa terra, pensado nas famílias angolanas. \nPreço: Akz 7.000,00  \nTamanho: Familiar ");
                        Console.WriteLine("\n1- Pedir \n2- Sair");

                        Console.Write("\nEscolha: ");
                        escolhaOferta = Convert.ToInt32(Console.ReadLine());

                        //Opção Pedir Oferta do Dia
                        if (escolhaOferta == 1)
                        {
                            Console.WriteLine("\nQuantidade: \n1 unidade \n2 unidades \n3 unidades \n4 unidades \n5 unidades");

                            Console.Write("\nEscolha: ");
                            decimal quantidade = Convert.ToInt32(Console.ReadLine());
                            if (quantidade == 1 || quantidade == 2 || quantidade == 3 || quantidade == 4 || quantidade == 5)
                             {
                                precoTotal = quantidade * 7000M;
                                Console.Clear();
                                Console.WriteLine("************************* Pizzaria MamaMia *************************");
                                Console.WriteLine($"Pedido: OD-{rnd.Next(1100, 5500)} " +
                                $"\nTotal a pagar: {precoTotal.ToString("C", CultureInfo.CreateSpecificCulture("pt-AO"))}" +
                                $"\n\t\tGuarde o seu número de pedido, obrigado! ");
                        }
                            else
                            {
                                Console.WriteLine("Escolha uma das quantidades válidas: 1, 2, 3, 4, 5");
                                Console.ReadKey();
                                goto case 1;

                            }
                        }
                        //Opção Sair (Menu Oferta do Dia)
                        else if (escolhaOferta == 2)
                        {
                            goto case 3;
                        }
                        else
                        {
                           Console.WriteLine("\nEscolha um dos números válidos: 1 para pedir a pizza, e 2 pra sair.");
                           Console.ReadKey();
                           goto case 1;
                        }
                break;

                //=======================Menu Por Tamanho=======================
                case 2:
                    Console.Clear();
                    Console.WriteLine("************************* Pizzaria MamaMia *************************");
                    Console.WriteLine("\t\t\t\t\n1- Tamanho Familiar  \n2- Tamanho Médio \n3- Tamanho Pequeno \n4- Sair");

                    Console.Write("\nEscolha: ");
                    escolhaTamanho = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    //=================================Opção Tamanho Familiar====================================

                    if (escolhaTamanho == 1)
                    {
                        Console.WriteLine("************************* Pizzaria MamaMia *************************");
                        Console.WriteLine("\n1- Pizza 4 Estações (Quattro Stagioni) \n2- Voltar ao Menu principal");
                        Console.Write("\nEscolha: ");
                        escolhaTamanho = Convert.ToInt32(Console.ReadLine());

                        if (escolhaTamanho == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("************************* Pizzaria MamaMia *************************");
                            Console.WriteLine("\t\t\t\t*Pizza 4 Estações (Quattro Stagioni)* \nDividida em quatro partes, " +
                            "cada uma representando uma estação: presunto (inverno), " +
                            "alcachofra (primavera), \ncogumelos (outono) e azeitonas (verão). Todos com base de molho e queijo. " +
                            "\nPreço: Akz 14.000,00");
                            Console.WriteLine("\n1- Pedir \n2- Voltar ao Menu");

                            Console.Write("\nEscolha: ");
                            escolhaTamanho = Convert.ToInt32(Console.ReadLine());

                            if (escolhaTamanho == 1)
                            {
                                Console.WriteLine("\nQuantidade: \n1 unidade \n2 unidades \n3 unidades \n4 unidades \n5 unidades");

                                Console.Write("\nEscolha: ");
                                decimal quantidade = Convert.ToInt32(Console.ReadLine());
                                if (quantidade == 1 || quantidade == 2 || quantidade == 3 || quantidade == 4 || quantidade == 5)
                                {
                                    precoTotal = quantidade * 14000M;
                                    Console.Clear();
                                    Console.WriteLine("************************* Pizzaria MamaMia *************************");
                                    Console.WriteLine($"Pedido: TF-{rnd.Next(1100, 5500)} " +
                                    $"\nTotal a pagar: {precoTotal.ToString("C", CultureInfo.CreateSpecificCulture("pt-AO"))} " +
                                    $"\n\t\tGuarde o seu número de pedido, obrigado! ");
                                }
                                else
                                {
                                    Console.WriteLine("Escolha uma das quantidades válidas: 1, 2, 3, 4, 5");
                                    Console.ReadKey();
                                    goto case 2;
                                }
                            } 
                            else if (escolhaTamanho == 2)
                            {
                                goto case 2;
                            }
                            else
                            {
                                Console.WriteLine("\nEscolha um dos números válidos: 1 para pedir a pizza, e 2 para voltar ao menu.");
                                Console.ReadKey();
                                goto case 2;

                            }
                        }
                        else if (escolhaTamanho == 2)
                        {
                            goto case 2;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha um dos números válidos: 1 para selecionar  a pizza, e 2 para voltar ao menu.");
                            Console.ReadKey();
                            goto case 2;

                        }
                    }

                    //=================================Opção Tamanho Médio====================================
                    else if (escolhaTamanho == 2)
                    {
                        Console.WriteLine("************************* Pizzaria MamaMia *************************");
                        Console.WriteLine("\n1- Pizza Alla Milanese \n2- Voltar ao Menu principal");
                        Console.Write("\nEscolha: ");
                        escolhaTamanho = Convert.ToInt32(Console.ReadLine());

                        if (escolhaTamanho == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("************************* Pizzaria MamaMia *************************");
                            Console.WriteLine("\t\t\t\t*Pizza Alla Milanese* \nTípica de Milão, " +
                            "tem massa grossa e macia, com uma camada espessa de queijo que cobre todos os outros ingredientes \n" +
                            "Muito popular para comer com um filme no cinema." +
                            "\nPreço: Akz 10.000,00");
                            Console.WriteLine("\n1- Pedir \n2- Voltar ao Menu");

                            Console.Write("\nEscolha: ");
                            escolhaTamanho = Convert.ToInt32(Console.ReadLine());

                            if (escolhaTamanho == 1)
                            {
                                Console.WriteLine("\nQuantidade: \n1 unidade \n2 unidades \n3 unidades \n4 unidades \n5 unidades");

                                Console.Write("\nEscolha: ");
                                decimal quantidade = Convert.ToInt32(Console.ReadLine());
                                if (quantidade == 1 || quantidade == 2 || quantidade == 3 || quantidade == 4 || quantidade == 5)
                                {
                                    precoTotal = quantidade * 10000M;
                                    Console.Clear();
                                    Console.WriteLine("************************* Pizzaria MamaMia *************************");
                                    Console.WriteLine($"Pedido: TM-{rnd.Next(1100, 5500)}" +
                                    $"\nTotal a pagar: {(precoTotal).ToString("C", CultureInfo.CreateSpecificCulture("pt-AO"))} " +
                                    $"\n\t\tGuarde o seu número de pedido, obrigado! ");
                                }
                                else
                                {
                                    Console.WriteLine("Escolha uma das quantidades válidas: 1, 2, 3, 4, 5");
                                    Console.ReadKey();
                                    goto case 2;
                                }
                            }
                            else if (escolhaTamanho == 2)
                            {
                                goto case 2;
                            }
                            else
                            {
                                Console.WriteLine("\nEscolha um dos números válidos: 1 para pedir a pizza, e 2 para voltar ao menu.");
                                Console.ReadKey();
                                goto case 2;

                            }
                        }
                        else if (escolhaTamanho == 2)
                        {
                            goto case 2;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha um dos números válidos: 1 para selecionar  a pizza, e 2 para voltar ao menu.");
                            Console.ReadKey();
                            goto case 2;

                        }
                    }

                    
                    //=================================Opção Tamanho Pequeno====================================
                    else if (escolhaTamanho == 3)
                    {
                        Console.WriteLine("************************* Pizzaria MamaMia *************************");
                        Console.WriteLine("\n1- Pizza Boscaiola \n2- Voltar ao Menu principal");
                        Console.Write("\nEscolha: ");
                        escolhaTamanho = Convert.ToInt32(Console.ReadLine());

                        if (escolhaTamanho == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("************************* Pizzaria MamaMia *************************");
                            Console.WriteLine("\t\t\t\t*Pizza Boscaiolae* \nCombinada com muçarela, cogumelos e linguiça. " +
                            "Sabor intensamente saboroso, ideal para quem gosta de sabores fortes" +
                            "\nPreço: Akz 6.000,00");
                            Console.WriteLine("\n1- Pedir \n2- Voltar ao Menu");

                            Console.Write("\nEscolha: ");
                            escolhaTamanho = Convert.ToInt32(Console.ReadLine());

                            if (escolhaTamanho == 1)
                            {
                                Console.WriteLine("\nQuantidade: \n1 unidade \n2 unidades \n3 unidades \n4 unidades \n5 unidades");

                                Console.Write("\nEscolha: ");
                                decimal quantidade = Convert.ToInt32(Console.ReadLine());
                                if (quantidade == 1 || quantidade == 2 || quantidade == 3 || quantidade == 4 || quantidade == 5)
                                {
                                    precoTotal = quantidade * 6000M ;
                                    Console.Clear();
                                    Console.WriteLine("************************* Pizzaria MamaMia *************************");
                                    Console.WriteLine($"\t\t\t\tPedido: TP-{rnd.Next(1100, 5500)} " +
                                    $"\nTotal a pagar: {precoTotal.ToString("C", CultureInfo.CreateSpecificCulture("pt-AO"))} " +
                                    $"\n\t\tGuarde o seu número de pedido, obrigado!");
                                }
                                else
                                {
                                    Console.WriteLine("Escolha uma das quantidades válidas: 1, 2, 3, 4, 5");
                                    Console.ReadKey();
                                    goto case 2;
                                }
                            }
                            else if (escolhaTamanho == 2)
                            {
                                goto case 2;
                            }
                            else
                            {
                                Console.WriteLine("\nEscolha um dos números válidos: 1 para pedir a pizza, e 2 para voltar ao menu.");
                                Console.ReadKey();
                                goto case 2;

                            }
                        }
                        else if (escolhaTamanho == 2)
                        {
                            goto case 2;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha um dos números válidos: 1 para selecionar  a pizza, e 2 para voltar ao menu.");
                            Console.ReadKey();
                            goto case 2;

                        }

                    }
                    else if (escolhaTamanho == 4)
                    {
                        goto case 3;
                    }
                    else
                    {
                        Console.WriteLine("\nEscolha uma das opções válidas: 1 para Tamanho Familiar, 2 para Tamanho Médio" +
                        " 3 para Tamanho Pequeno e 4 para Sair");
                        Console.ReadKey();
                        goto case 2;
                    }

                    break;


                //=======================Sair do programa=======================
                case 3:
                        Console.Clear();
                        Console.WriteLine("Obrigado, e volte sempre!");
                break;


                //=======================Tratamento de entrada inválida=======================
                default:
                      Console.WriteLine("\nEscolha um dos números válidos: 1 para ver " +
                      "oferta do dia, 2 para o menu, e 0 pra sair.");
                 break;
            }
        }
    }
}
