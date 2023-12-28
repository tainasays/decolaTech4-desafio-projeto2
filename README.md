# 🚀 Decola Tech 2024 - Orientação a Objetos com C#
www.dio.me

## 🌟 Desafio de projeto II - Criando um Sistema e Abstraindo um Celular com POO em C#
Este é o segundo desafio de projeto do Bootcamp Decola Tech 2024, módulo III - Orientação a Objetos com C#. Para este projeto, desenvolvi os requisitos solicitados e obrigatórios para o desafio, começando aqui pela versão 1.0, pois pretendo, conforme avanço no conhecimento da linguagem, aprimorá-lo.

## ❓ Contexto
Para esse segundo projeto, foi preciso criar uma abstração para representar a classe genérica dos celulares e, em seguida, os tipos específicos de celulares. O objetivo era possibilitar o máximo de reutilização do código, respeitando os diferentes tipos de comportamento e trabalhando com orientação ao objeto.

## 📌 Proposta
A criação de um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone, conforme o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## ❗ Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.
___________________________________________________________

### 💻 Saída no console

![image](https://github.com/tainasays/decolaTech4-desafio-projeto2/assets/102188509/df31c623-81b3-46ed-b3e5-42fdcd52d5b9)

### ⚙️ Código

* [Classe abstrata Smartphone.cs](https://github.com/tainasays/decolaTech4-desafio-projeto2/blob/main/Models/Smartphone.cs);
* [Classe Iphone.cs](https://github.com/tainasays/decolaTech4-desafio-projeto2/blob/main/Models/Iphone.cs);
* [Classe Nokia.cs](https://github.com/tainasays/decolaTech4-desafio-projeto2/blob/main/Models/Nokia.cs);
* [Program.cs](https://github.com/tainasays/decolaTech4-desafio-projeto2/blob/main/Program.cs).
