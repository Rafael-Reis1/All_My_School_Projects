import os
clear = lambda: os.system('cls')

nomes = []
senhaConta = []
numConta = []
saldoConta = []
escolhaMenuInicial = 0
escolhaMenuConta = 0
numContaAcesso = 0
quantContasCriadas = 0
senhaContaAcesso = str
quant = 0
posic = 0

while (True):
    clear()
    print("Melhor banco do mundo!")
    print("\n|  1. Acessar conta  |  2. Criar conta  |")
    try:
        escolhaMenuInicial = int(input("Opção: "))
    except:
        continue 
    if (escolhaMenuInicial == 1):
        clear()
        print("Acessar conta")
        try:
            numContaAcesso = int(input("\nDigite o codigo da sua conta: "))
        except:
            continue
        posic = -1
        quant = 0
        escolhaMenuConta = 0
        for i in numConta:
            if (numContaAcesso == i):
                posic = quant
            quant += 1
        if (posic >= 0):
            senhaContaAcesso = input("Digite sua senha: ")

            if (senhaContaAcesso == senhaConta[posic]):
                while (escolhaMenuConta != 4):
                    clear()
                    print(f"Bem Vindo {nomes[posic]} ({numConta[posic]})")
                    print("\n|  1. Transferência  |  2. Deposito  |  3. Saldo na conta  |  4. Sair  |")
                    try:
                        escolhaMenuConta = int(input("Opção: "))
                    except:
                        continue        
                    if (escolhaMenuConta == 1):
                        clear()
                        print("Transferência")
                        try:
                            numContaDestino = int(input("\nDigite o número da conta destinataria: "))
                        except:
                            continue
                        posicDestino = -1
                        quant = 0
                        if (numContaDestino != numConta[posic]):
                            for i in numConta:
                                if (numContaDestino == i):
                                  posicDestino = quant
                                quant += 1

                            if (posicDestino >= 0): 
                                try:
                                    valorTrans = float(input("Digite o valor da transferência: "))
                                except:
                                    continue
                                if (valorTrans > 0):
                                    if (saldoConta[posic] >= valorTrans):
                                        confirm = input(f"\nConfirma que deseja transferir {valorTrans} reais para {nomes[posicDestino]}? (s/n) ")

                                        if(confirm == "s" or confirm == "S"):
                                            saldoConta[posic] -= valorTrans
                                            saldoConta[posicDestino] += valorTrans
                                    else:
                                        print(f"\nSaldo insuficiente, saldo atual é de {saldoConta[posic]}")
                                        pause = input("\nAperte qualquer tecla para continuar ")
                                else:
                                    print("\nValor da transferência deve ser maior que 0.00")
                                    pause = input("\nAperte qualquer tecla para continuar ")
                            else:
                                print("\nConta não encontrada")
                                pause = input("\nAperte qualquer tecla para continuar ")
                        else:
                            print("\nConta destino deve ser diferente")
                            pause = input("\nAperte qualquer tecla para continuar ")
                    elif (escolhaMenuConta == 2):
                        clear()
                        print("Deposito")
                        try:
                            valorDeposito = float(input("\nDigite o valor a ser depositado: "))
                        except:
                            continue
                        if(valorDeposito > 0):
                            confirm = input(f"Confirma que deseja depositar {valorDeposito} reais? (s/n) ")
                            if (confirm == "s" or confirm == "S"):
                                saldoConta[posic] += valorDeposito
                        else:
                            print("\nValor de deposito deve ser maior que 0.00")
                            pause = input("\nAperte qualquer tecla para continuar ")  
                    elif (escolhaMenuConta == 3):
                        clear()
                        print("Saldo")
                        print(f"\nSeu saldo na conta é de {saldoConta[posic]} reais")
                        pause = input("\nAperte qualquer tecla para continuar ")
            else:
                print("\nSenha incorreta ")
                pause = input("\nAperte qualquer tecla para continuar ")
        else:
            print("\nConta não encontrada ")
            pause = input("\nAperte qualquer tecla para continuar ")       
    elif (escolhaMenuInicial == 2):
        clear()
        print("Criar conta")
        nomes.append(str(input("\nDigite seu nome: ")))
        if (nomes[quantContasCriadas] != ""):  
            senhaConta.append(str(input("Digite sua senha: ")))
            if (senhaConta[quantContasCriadas] != ""):
                numConta.append(quantContasCriadas + 1)
                saldoConta.append(0)
                print(f"\nO número da sua conta é: {numConta[quantContasCriadas]}")
                pause = input("\nAperte qualquer tecla para continuar ")
                quantContasCriadas += 1
            else:
                nomes.pop()
                senhaConta.pop()
                print("\nConta não criada (Deve conter senha)")
                pause = input("\nAperte qualquer tecla para continuar ")
        else:
            nomes.pop()
            print("\nConta não criada (Deve conter nome)")
            pause = input("\nAperte qualquer tecla para continuar ")